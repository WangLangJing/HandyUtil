using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace ChartByExcelData
{
    /*-------------------------------------------------------------------------
 * 作者：王浪静
 * 联系方式：932444208@qq.com
 * 创建时间： 2017/8/29 16:31:17
 * 版本号：v1.0
 * .NET 版本：4.0
 * 本类主要用途描述：Excel 数据获取模板
 * 
 * 生成一个图表需要以下几类数据
 * 1.图表的类型：例如：面积划分（套）、户型结构划分（套）此类数据用于显示在图表头部，以为用户说明
 * 图表中的数据是根据什么划分的
 * 2.图表的横轴数据 例如在 面积划分（套） 中 横轴数据有 60㎡以下(含60)、60~80㎡(含80)等
 * 3.图标的纵轴数据 例如在 面积划分（套） 中 纵轴数据有 76                    、36 等
 * 
 * 而此模板的作用就是为了标识出这些数据所在单元格的索引
 * 使用此方法以抽象不同格式的Excel，日后有新的格式的Excel只需要为其制作对应的数据获取模板，
 * 而不需要改变代码
 *  -------------------------------------------------------------------------*/
    [XmlRoot("excelDataExtractTemplate")]
    public class ExcelDataExtractTemplate
    {
        /// <summary>
        /// 一组分类信息的集合
        /// </summary>
        [XmlArray("excelGraphCategories")]
        public ExcelGraphCategory[] ExcelGraphCategories { get; set; }

        /// <summary>
        /// 操作的工作表的序号，默认为 0
        /// </summary>
        [XmlElement("sheetNum")]
        public Int32 SheetNum
        {
            get
            {
                return this._sheetNum;
            }
            set
            {
                this._sheetNum = value;
            }
        }
        private Int32 _sheetNum = 0;


        /// <summary>
        /// 图像插入的起点，以单元格为单位（注意横纵单元格大小并不一致）,
        /// 默认从文档的最后一行加二，第一列开始插入图像
        /// </summary>
        [XmlElement("startPoint")]
        public Point StartPoint
        {
            get
            {
                return this._startPoint;
            }
            set
            {
                this._startPoint = value;
            }
        }
        private Point _startPoint = new Point(1, -1);


        /// <summary>
        /// 插入图像的宽度，单位：列单元格，默认占用8列
        /// </summary>
        [XmlElement("graphsWidth")]
        public Int32 Width
        {
            get { return this._width; }
            set
            {
                this._width = value;
            }
        }
        private Int32 _width = 8;
        /// <summary>
        /// 插入图像的高度，单位：行单元格，默认占用22行
        /// </summary>
        [XmlElement("graphsHeight")]
        public Int32 Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        private Int32 _height = 22;
        /// <summary>
        /// 假如存在多个图像时，图像之间的间隔（图像垂直排列），默认间隔2行
        /// </summary>
        [XmlElement("intervalWithMulti")]
        public Int32 IntervalWithMulti
        {
            get
            {
                return this._intervalWithMulti;
            }
            set
            {
                this._intervalWithMulti = value;
            }
        }
        private Int32 _intervalWithMulti = 2;
        /// <summary>
        /// 从指定路径加载数据提取模板
        /// </summary>
        public static ExcelDataExtractTemplate Load(String filePath)
        {
            return TKXmlSerializer.DeSerialize<ExcelDataExtractTemplate>(filePath);
        }
    }
    [XmlType("dataGroup")]
    public class DataGroup
    {
        [XmlElement("groupName")]
        public Point Name { get; set; }
        /// <summary>
        /// 数据坐标集合
        /// </summary>
        [XmlArray("dataPosition")]
        public Point[] Data { get; set; }
    }
    [XmlType("excelGraphCategory")]
    public class ExcelGraphCategory
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        [XmlElement("namePosition")]
        public Point Name { get; set; }
        /// <summary>
        /// 单位信息
        /// </summary>
        [XmlElement("unitPosition")]
        public Point? Unit { get; set; }
        /// <summary>
        /// X轴数据坐标集合
        /// </summary>
        [XmlArray("xdataPosition")]
        public Point[] XData { get; set; }
        /// <summary>
        /// X轴数据坐标集合
        /// </summary>
        [XmlArray("ydataPosition")]
        public Point[] YData { get; set; }
        /// <summary>
        /// 数据组集合
        /// </summary>
        [XmlArray("dataGroups")]
        public DataGroup[] Group { get; set; }
    }
    [XmlType("Point")]
    public struct Point
    {
        public Point(Int32 x, Int32 y) : this()
        {
            this.X = x;
            this.Y = y;
        }
        [XmlAttribute("X")]
        public Int32 X { get; set; }
        [XmlAttribute("Y")]
        public Int32 Y { get; set; }
    }
}
