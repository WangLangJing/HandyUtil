using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NoSleepHD.Properties;
namespace NoSleepHD
{
    public partial class NoSleepHDForm : Form
    {
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
        public NoSleepHDForm()
        {
            InitializeComponent();
            this.BeginActivate();
            this.HideView();
        }


        private void _buttonClose_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = Resources.Close_Down;
        }

        private void _buttonClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = Resources.Close_Normal;
        }





        private void ShowView()
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void HideView()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

        }






        private void _notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.ShowView();
        }

        private void _buttonClose_Click(object sender, EventArgs e)
        {
            this.HideView();
        }

        private void _tsmiShow_Click(object sender, EventArgs e)
        {
            this.ShowView();
        }

        private void _tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _timeractivate_Tick(object sender, EventArgs e)
        {
            HdActivator.ActivateHd();
        }

        private void _buttonBegin_Click(object sender, EventArgs e)
        {
            this.EndActivate();
            this.BeginActivate();
        }

        private void _buttonEnd_Click(object sender, EventArgs e)
        {
            this.EndActivate();
        }
        private void EndActivate()
        {
            if (this._timerActivate.Enabled)
            {
                this._timerActivate.Stop();
                this._buttonBegin.BackColor = Color.FromArgb(255, this._buttonBegin.BackColor);
                this._buttonEnd.BackColor = Color.FromArgb(100, this._buttonEnd.BackColor);
            }
        }
        private void BeginActivate()
        {
            this._timerActivate.Interval = (Int32)this._nudSleepInterval.Value;
            this._timerActivate.Start();
            this._buttonBegin.BackColor = Color.FromArgb(100, this._buttonBegin.BackColor);
            this._buttonEnd.BackColor = Color.FromArgb(255, this._buttonEnd.BackColor);
        }

        private void NoSleepHDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.EndActivate();
        }
    }
}
