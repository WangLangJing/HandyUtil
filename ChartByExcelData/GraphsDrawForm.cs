using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing.Imaging;

namespace ChartByExcelData
{
    public partial class GraphsDrawForm : Form,IGraphDraw
    {
        public GraphsDrawForm()
        {
            InitializeComponent();
        }

        public Byte[] DrawGraph(String title, String unitInfo, IEnumerable<String> xdata, IEnumerable<Double> ydata, ImageFormat format)
        {
            this.DrawGraphByData(title, unitInfo,xdata, ydata);
            return GetGraphsBytes(format);
        }

        /// <summary>
        /// 通过数据绘制对应的图表
        /// </summary>
        /// <param name="title">图表的标题</param>
        /// <param name="xdata">x轴数据</param>
        /// <param name="ydata">y轴数据</param>
        public void DrawGraphByData(String title, String unitInfo,
            IEnumerable<String> xdata,
            IEnumerable<Double> ydata)
        {
            unitInfo = unitInfo.Trim();
            if (String.IsNullOrEmpty(unitInfo))
            {
                unitInfo = null;
            }
            this._chart.Titles[0].Text = title+(unitInfo==null?String.Empty:String.Format("({0})",unitInfo));
            Series series = this._chart.Series[0];
            series.Points.Clear();
            Int32 count = xdata.Count();
            for (Int32 i = 0; i < count; ++i)
            {
                DataPoint point = new DataPoint(i + 1, ydata.ElementAt(i));
                point.AxisLabel = xdata.ElementAt(i);
                series.Points.Add(point);
            }
        }
        /// <summary>
        /// 获取图表的Bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap GetGraphsBitmap()
        {
            Bitmap bitmap = new Bitmap(this._chart.Width, this._chart.Height);
            this._chart.DrawToBitmap(bitmap, this._chart.ClientRectangle);
            return bitmap;
        }
        /// <summary>
        /// 获取图表的二进制数据，默认使用png格式
        /// </summary>
        public Byte[] GetGraphsBytes(ImageFormat format = null)
        {
            Byte[] buffer = null;
            Bitmap bitmap = this.GetGraphsBitmap();
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, format ?? ImageFormat.Png);
                buffer = stream.GetBuffer();
            }
            return buffer;
        }
    }
}
