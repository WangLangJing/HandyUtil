using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChartByExcelData
{
    public partial class Form1 : Form
    {
        public String SourcePath { get; set; }
        public String TemplatePath { get; set; }
        private IGraphDraw _graphDraw = null;
        public Form1()
        {
            InitializeComponent();
            _graphDraw = new GraphsDrawForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ofdSelect.FileName = null;
            _ofdSelect.Filter = "Excel文件(*.xls;*xlsx)|*.xls;*.xlsx";
            if (DialogResult.OK==this._ofdSelect.ShowDialog())
            {
                this.SourcePath = this._ofdSelect.FileName;
                this.textBox1.Text = this.SourcePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ofdSelect.FileName = null;
            _ofdSelect.Filter = "数据提取模板 |*.xml";
            if (DialogResult.OK == this._ofdSelect.ShowDialog())
            {
                this.TemplatePath = this._ofdSelect.FileName;
                this.textBox2.Text = this.TemplatePath;
            }
        }

        private void _btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.SourcePath) && !String.IsNullOrEmpty(this.TemplatePath))
                {
                    ExcelDataExtractTemplate template = ExcelDataExtractTemplate.Load(this.TemplatePath);
                    ExcelGraphs excelGraphs = new ExcelGraphs();
                    var dataCollection = excelGraphs.ExtractDataByTemplate(this.SourcePath, template);
                    List<Byte[]> graphDataList = new List<Byte[]>();

                    foreach (var data in dataCollection)
                    {
                        Byte[] graphData = this._graphDraw.DrawGraph(data.Item1, data.Item2, data.Item3, data.Item4, null);
                        graphDataList.Add(graphData);
                    }
                    excelGraphs.DrawGraphsCollection(this.SourcePath, template, graphDataList.ToArray());
                    Process.Start(this.SourcePath);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

          
        }
    }
}
