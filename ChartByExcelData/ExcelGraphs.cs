using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.HSSF.UserModel;

namespace ChartByExcelData
{
    /*-------------------------------------------------------------------------
 * 作者：王浪静
 * 联系方式：932444208@qq.com
 * 创建时间： 2017/8/29 15:24:34
 * 版本号：v1.0
 * .NET 版本：4.0
 * 本类主要用途描述：用于管理Excel文件中的图型数据
 *  -------------------------------------------------------------------------*/
    public class ExcelGraphs
    {
        #region 异常信息
        internal const String ErrorOfCannotGetCellData = "未能获取到指定单元格的数据";
        internal const String ErrorOfCannotOpenExcel = "无法打开指定的Excel文件";
        internal const String ErrorOfCannotOpenSheet = "无法打开指定的工作表";
        #endregion
        #region 信息
        internal const String ExtOfExcel2003 = ".xls";
        internal const String ExtOfExcel2007Plus = ".xlsx";
        internal const PictureType DefaultPictureType = PictureType.PNG;
        #endregion
        private Int32 _defaultOffsetRow = 2;

        /// <summary>
        /// 通过指定的数据提取模板，从文件中提取数据
        /// </summary>
        /// <param name="filePath">指定文件</param>
        /// <param name="template">数据提取模板</param>
        /// <returns>返回从Excel中提取的数据</returns>
        public IEnumerable<Tuple<String,String,IEnumerable<String>, IEnumerable<Double>>> ExtractDataByTemplate(
            String filePath,
            ExcelDataExtractTemplate template)
        {
            List<Tuple<String,String,IEnumerable<String>, IEnumerable<Double>>>
                result = new List<Tuple<String, String, IEnumerable<String>, IEnumerable<Double>>>();
            IWorkbook workBook = this.OpenExcel(filePath);
            ISheet sheet = null;
            if (workBook == null)
            {
                return result;
            }
            sheet = this.OpenSheet(workBook, template.SheetNum); 
            foreach (ExcelGraphCategory category in template.ExcelGraphCategories)
            {
                String title = String.Empty;
                String unit = String.Empty;
                List<String> xdataList = new List<String>();
                List<Double> ydataList = new List<Double>();
                Int32 count = category.XData.Length;

                title = this.GetCellData(sheet, category.Name);
                if (category.Unit != null)
                {
                    unit = this.GetCellData(sheet, category.Unit.Value);
                }
                for (Int32 i = 0; i < count; ++i)
                {
                    Point xdataPoint = category.XData[i];
                    Point ydataPoint = category.YData[i];
                    try
                    {
                        String xdata = this.GetCellData(sheet, xdataPoint);
                        Double ydata = this.GetCellDataDouble(sheet, ydataPoint);
                        xdataList.Add(xdata);
                        ydataList.Add(ydata);
                    }
                    catch (Exception exc)
                    {
                        throw new Exception(ErrorOfCannotGetCellData, exc);
                    }
                }
                result.Add(Tuple.Create(title, unit,
                    xdataList as IEnumerable<String>,
                    ydataList as IEnumerable<Double>));
            }
            return result;
        }
        /// <summary>
        /// 获取工作表上指定单元格的数据，此函数不区分单元格中数据的类型统一返回字符串类型
        /// </summary>
        /// <param name="sheet">工作表对象</param>
        /// <param name="point">单元格坐标</param>
        public String GetCellData(ISheet sheet, Point point)
        {
            return this.GetCellData(sheet, point.X, point.Y);
        }
        public Double GetCellDataDouble(ISheet sheet, Point point)
        {
            return this.GetCellDataDouble(sheet, point.X, point.Y);
        }
        public Double GetCellDataDouble(ISheet sheet, Int32 x, Int32 y)
        {
            Double value = 0;
            ICell cell = sheet.GetRow(x).Cells[y];
            value = cell.NumericCellValue;
            return value;
        }
        public String GetCellData(ISheet sheet, Int32 x, Int32 y)
        {
            String value = null;
            value = sheet.GetRow(x).Cells[y].ToString();
            return value;
        }
        /// <summary>
        /// 保存Excel至指定路径
        /// </summary>
        /// <param name="workBook">Excel对象</param>
        /// <param name="filePath">保存的路径</param>
        public void SaveExcel(IWorkbook workBook, String filePath)
        {
            File.Delete(filePath);
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                workBook.Write(stream);
            }
        }
        /// <summary>
        /// 打开指定路径的Excel
        /// </summary>
        /// <param name="filePath">指定的路径</param>
        /// <returns>返回 IWorkbook 接口以操作Excel</returns>
        public IWorkbook OpenExcel(String filePath)
        {
            IWorkbook workBook = null;
            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open,
                  FileAccess.ReadWrite))
                {
                    try
                    {
                        workBook = GenerationWorkBook(filePath, stream);
                    }
                    catch (Exception exc)
                    {
                        throw new Exception(ErrorOfCannotOpenExcel, exc);
                    }
                }
            }
            return workBook;
        }
        /// <summary>
        /// 将一组图像数据绘制到指定的工作表中
        /// </summary>
        /// <param name="workBook">指定的工作簿对象</param>
        /// <param name="sheet">指定的工作表对象</param>
        /// <param name="template">数据提取模板对象</param>
        /// <param name="graphDatas">图表数据集合</param>
        public void DrawGraphsCollection(IWorkbook workBook, ISheet sheet, ExcelDataExtractTemplate template,
          Byte[][] graphDatas, PictureType type)
        {
            Int32 beginX = template.StartPoint.X;
            Int32 beginY = template.StartPoint.Y == (-1) ? sheet.LastRowNum + this._defaultOffsetRow : template.StartPoint.Y;
            Int32 graphWidth = template.Width;
            Int32 graphHeight = template.Height;
            Int32 graphInterval = template.IntervalWithMulti;

            Int32 count = graphDatas.Length;
            for (Int32 i = 0; i < count; ++i)
            {
                Point point = new Point(beginX,beginY);
                Byte[] graphData = graphDatas[i];
                this.DrawGraphs(workBook,sheet, point, graphWidth, graphHeight, graphData,type);
                beginY += graphHeight + graphInterval;
            }
        }
        /// <summary>
        /// 将图像数据根据指定模板，绘制到指定路径的Excel文件中
        /// </summary>
        /// <param name="filePath">操作的文件的路径</param>
        /// <param name="template">模板对象</param>
        /// <param name="graphDatas">图像数据的集合</param>
        public void DrawGraphsCollection(String filePath, ExcelDataExtractTemplate template, Byte[][] graphDatas,PictureType type=DefaultPictureType)
        {
            IWorkbook workBook = this.OpenExcel(filePath);
            ISheet sheet = this.OpenSheet(workBook,template.SheetNum);
            this.DrawGraphsCollection(workBook, sheet, template, graphDatas, type);
            File.Delete(filePath);
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                workBook.Write(stream);
            }
        }
        /// <summary>
        /// 打开指定索引的工作表，
        /// 请使用此函数获取工作表对象
        /// </summary>
        /// <param name="workBook">工作簿对象</param>
        /// <param name="sheetIndex">工作表索引</param>
        protected ISheet OpenSheet(IWorkbook workBook, Int32 sheetIndex)
        {
            ISheet sheet = null;
            try
            {
                sheet=workBook.GetSheetAt(sheetIndex);
            }
            catch (Exception exc)
            {
                throw new Exception(ErrorOfCannotOpenSheet, exc);
            }
            return sheet;
        }
        /// <summary>
        /// 将指定的图像数据绘制到工作表中
        /// </summary>
        /// <param name="workBook">工作簿对象</param>
        /// <param name="sheet">工作表对象</param>
        /// <param name="start">图像的起始单元格坐标</param>
        /// <param name="width">图像占用的列的数量</param>
        /// <param name="height">图像占用的行的数量</param>
        /// <param name="graphData">图像包含的数据</param>
        /// <param name="type">图像数据源图像的格式，默认使用PNG</param>
        public void DrawGraphs(IWorkbook workBook, ISheet sheet,
            Point start, Int32 width, Int32 height,
            Byte[] graphData,
            PictureType type = DefaultPictureType)
        {
            IClientAnchor anchor = null;
            if (workBook is HSSFWorkbook)
            {
                anchor = new HSSFClientAnchor(0, 0, 0, 0, start.X, start.Y, start.X + width, start.Y + height);
            }
            else
            {
                anchor = new XSSFClientAnchor(0, 0, 0, 0, start.X, start.Y, start.X + width, start.Y + height);
            }
            this.DrawGraphs(workBook, sheet, anchor, graphData, type);
        }
        public void DrawGraphs(IWorkbook workBook, ISheet sheet,
        IClientAnchor anchor,
        Byte[] graphData,
        PictureType type = DefaultPictureType)
        {
            Int32 index = workBook.AddPicture(graphData, type);
            IDrawing patriarch = sheet.CreateDrawingPatriarch();
            patriarch.CreatePicture(anchor, index);
        }
        [Obsolete("请勿使用此函数")]
        private IWorkbook OpenExcel(String filePath, params Byte[][] imageData)
        {
            IWorkbook workBook = null;
            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open,
                    FileAccess.ReadWrite, FileShare.ReadWrite, 8096,
                    FileOptions.WriteThrough))
                {
                    workBook = GenerationWorkBook(filePath, stream);
                    Int32 index = workBook.AddPicture(imageData[0], PictureType.PNG);

                    ISheet sheet = workBook.GetSheetAt(0);
                    IDrawing patriarch = sheet.CreateDrawingPatriarch();

                    Int32 lastRowNum = sheet.LastRowNum;
                    IClientAnchor anchor = GenerationClientAnchor(filePath, 0, 0, 0, 0, 1, lastRowNum + 2, 8, lastRowNum + 25);

                    IPicture pic = patriarch.CreatePicture(anchor, index);
                    File.Delete(filePath);
                    using (FileStream newStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                    {
                        workBook.Write(newStream);
                    }

                }
            }
            return workBook;
        }
        public IClientAnchor GenerationClientAnchor(String filePath,
            Int32 dx1, Int32 dy1, Int32 dx2, Int32 dy2, Int32 col1, Int32 row1, Int32 col2, Int32 row2)
        {
            IClientAnchor clientAnchor = null;
            String ext = Path.GetExtension(filePath);
            switch (ext)
            {
                case ExtOfExcel2003:
                    {
                        clientAnchor = new HSSFClientAnchor(dx1, dy1, dx2, dy2, col1, row1, col2, row2);
                    }
                    break;
                case ExtOfExcel2007Plus:
                default:
                    {
                        clientAnchor = new XSSFClientAnchor(dx1, dy1, dx2, dy2, col1, row1, col2, row2);
                    }
                    break;
            }
            return clientAnchor;
        }
        public IWorkbook GenerationWorkBook(String filePath, Stream stream)
        {
            IWorkbook workBook = null;
            String ext = Path.GetExtension(filePath);
            switch (ext)
            {
                case ExtOfExcel2003:
                    {
                        workBook = new HSSFWorkbook(stream);
                    }
                    break;
                case ExtOfExcel2007Plus:
                default:
                    {
                        workBook = new XSSFWorkbook(stream);
                    }
                    break;
            }
            return workBook;
        }
    }
}
