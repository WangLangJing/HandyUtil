using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{

    public partial class ColorPickerForm : Form
    {
        private const String PointShowFormat = "({0},{1})";
        private const String RGBShowFormat = "{0},{1},{2}";
        private const String HEXShowFormat = "#{0}{1}{2}";
        private IntPtr _hDc = IntPtr.Zero;
        private Boolean _isRunning = false;
        private Label _currentSelectedColorLabel = null;
        /********************************/
        public ColorPickerForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.SetCurrentColorLabel(this._labelColorRGB);
            this.FormClosing += ColorPicker_FormClosing;
            this.Shown += ColorPickerForm_Shown;
            this._hDc = Win32Api.GetDC(IntPtr.Zero);
        }

        private void ColorPickerForm_Shown(Object sender, EventArgs e)
        {
            this.Start();
        }

        private void Start()
        {
            this._isRunning = true;
            this._timerCursorPoint.Start();
        }
        private void Stop()
        {
            this._isRunning = false;
            this._timerCursorPoint.Stop();
        }
        private void ColorPicker_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (IntPtr.Zero != this._hDc)
            {
                Win32Api.ReleaseDC(this.Handle, this._hDc);
            }
        }

        private void _timerCursorPoint_Tick(Object sender, EventArgs e)
        {
            this._timerCursorPoint.Enabled = false;
            if (!this._isRunning)
            {
                return;
            }
            Point cursor = new Point();
            if (this.FetchCurrentCursorPoint(ref cursor))
            {
                this.ShowPoint(cursor);
                if (IntPtr.Zero != this._hDc)
                {
                    UInt32 pixel = this.FetchPointColor(this._hDc, cursor);
                    Color color = this.FetchColorByPixel(pixel);
                    this.ShowHEX(color);
                    this.ShowRGB(color);
                    this.DrawColorBoard(color);
                }
            }
            this._timerCursorPoint.Enabled = true;
        }

        private void ShowHEX(Color color)
        {
            this._labelColorHEX.Tag = color;
            this._labelColorHEX.Text = String.Format(HEXShowFormat, color.R.ToString("X2"), color.G.ToString("X2"), color.B.ToString("X2"));
        }

        private void ShowRGB(Color color)
        {
            this._labelColorRGB.Tag = color;
            this._labelColorRGB.Text = String.Format(RGBShowFormat, color.R, color.G, color.B);
        }
        /// <summary>
        /// 获取当前鼠标的坐标
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private Boolean FetchCurrentCursorPoint(ref Point point)
        {
            return 0 != Win32Api.GetCursorPos(ref point);
        }
        /// <summary>
        /// 显示坐标
        /// </summary>
        /// <param name="point"></param>
        private void ShowPoint(Point point)
        {
            this.Text = String.Format(PointShowFormat, point.X, point.Y);
            this._labelPoint.Text = this.Text;
        }
        /// <summary>
        /// 获取指定设备中指定坐标点上的像素
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        private UInt32 FetchPointColor(IntPtr hdc, Point point)
        {
            return Win32Api.GetPixel(hdc, point.X, point.Y);
        }
        /// <summary>
        /// 通过像素点获取Color
        /// </summary>
        /// <param name="pixel"></param>
        /// <returns></returns>
        private Color FetchColorByPixel(UInt32 pixel)
        {
            Color color = Color.FromArgb(
                 (Int32)(pixel & 0x000000FF),
                 (Int32)(pixel & 0x0000FF00) >> 8,
                 (Int32)(pixel & 0x00FF0000) >> 16);
            return color;
        }
        private void DrawColorBoard(Color color)
        {
            this._panelColorBoard.BackColor = color;
        }
        protected override Boolean ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S && this._isRunning)
            {
              
                String colorStr = null;
                Color color = Color.Empty;
                this.LoadCurrentColorInfo(ref color, ref colorStr);
                this.SetClipboard(colorStr);
                this.DrawSelectedColor(color, colorStr);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SetClipboard(String colorStr)
        {
            Clipboard.SetText(colorStr);
        }
        private void DrawSelectedColor(Color color,String colorStr)
        {
            this._panelSelectColor.BackColor = color;
            this._labelSelectedColor.Text = colorStr;
        }
        private void ColorPicker_Load(Object sender, EventArgs e)
        {

        }


        private void LoadCurrentColorInfo(ref Color color,ref String colorStr)
        {
            colorStr=this._currentSelectedColorLabel.Text;
            color = (Color)this._currentSelectedColorLabel.Tag;
        }

        #region<<点击窗体任意位置拖动>>
        private Point _currentMousePoint;
        private Boolean _isMove = false;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                this._currentMousePoint = e.Location;
                this._isMove = true;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this._isMove)
            {
                /**计算Point偏移值*/
                Int32 offsetX = e.Location.X - this._currentMousePoint.X;
                Int32 offsetY = e.Location.Y - this._currentMousePoint.Y;

                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this._isMove = false;
            base.OnMouseUp(e);
        }
        #endregion

        private void SetCurrentColorLabel(Label label)
        {
            if (this._currentSelectedColorLabel != null)
            {
                this._currentSelectedColorLabel.ForeColor = Color.White;
            }
            this._currentSelectedColorLabel = label;
            this._currentSelectedColorLabel.ForeColor = Color.Red;
            if (label.Tag != null)
            {
                this.DrawSelectedColor((Color)label.Tag, label.Text);
                this.SetClipboard(label.Text);
            }
        }

        private void _labelColorRGBTitle_Click(Object sender, EventArgs e)
        {
            this.SetCurrentColorLabel(this._labelColorRGB);
        }

        private void _labelColorHEXTitle_Click(Object sender, EventArgs e)
        {
            this.SetCurrentColorLabel(this._labelColorHEX);
        }

        private void _labelClose_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Win32Api
    {
        /// <summary>
        /// 获取指定窗口的设备场景
        /// </summary>
        /// <param name="hwnd">将获取其设备场景的窗口的句柄。若为0，则要获取整个屏幕的DC</param>
        /// <returns>指定窗口的设备场景句柄，出错则为0</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        /// <summary>
        /// 释放由调用GetDC函数获取的指定设备场景
        /// </summary>
        /// <param name="hwnd">要释放的设备场景相关的窗口句柄</param>
        /// <param name="hdc">要释放的设备场景句柄</param>
        /// <returns>执行成功为1，否则为0</returns>
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /// <summary>
        /// 在指定的设备场景中取得一个像素的
        /// </summary>
        /// <param name="hdc">一个设备场景的句柄</param>
        /// <param name="nXPos">逻辑坐标中要检查的横坐标</param>
        /// <param name="nYPos">逻辑坐标中要检查的纵坐标</param>
        /// <returns>指定点的颜色</returns>
        [DllImport("gdi32.dll")]
        public static extern UInt32 GetPixel(IntPtr hdc, Int32 nXPos, Int32 nYPos);

        [DllImport("user32.dll")]
        public static extern Int32 GetCursorPos(ref Point lpPoint);
    }
}
