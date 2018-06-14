#define COMPILER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace ChartByExcelData
{
#if COMPILER
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //GraphsDrawForm form = new GraphsDrawForm();

            //String sourceExcel = @".\数据源文件1.xls";
            //String templateFile = @".\数据提取模板1.xml";

            //ExcelDataExtractTemplate template = ExcelDataExtractTemplate.Load(templateFile);
            //ExcelGraphs excelGraphs = new ExcelGraphs();
            //IGraphDraw graphDraw = form;

            //var dataCollection = excelGraphs.ExtractDataByTemplate(sourceExcel, template);
            //List<Byte[]> graphDataList = new List<Byte[]>();

            //foreach (var data in dataCollection)
            //{
            //    Byte[] graphData = graphDraw.DrawGraph(data.Item1, data.Item2, data.Item3, null);
            //    graphDataList.Add(graphData);
            //}
            //excelGraphs.DrawGraphsCollection(sourceExcel, template, graphDataList.ToArray());

            Application.Run(new Form1());

        }
    }
#endif
}
