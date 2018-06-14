using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace ChartByExcelData
{
    /*-------------------------------------------------------------------------
    * 作者：王浪静
    * 联系方式：932444208@qq.com
    * 创建时间： 2017/8/30 9:36:24
    * 版本号：v1.0
    * .NET 版本：4.0
    * 本接口规范描述：图表图形绘制接口
    *  -------------------------------------------------------------------------*/
    /// <summary>
    /// 图表图形绘制接口
    /// </summary>
    public interface IGraphDraw
    {
        /// <summary>
        /// 根据指定的数据绘制图像信息，并按指定图像格式返回图像的二进制数据
        /// </summary>
        /// <param name="title">图表标题</param>
        /// <param name="xdata">X轴数据</param>
        /// <param name="ydata">Y轴数据</param>
        /// <param name="format">图像格式，默认请使用png格式</param>
        /// <returns>含有指定格式的图像的二进制数据</returns>
        Byte[] DrawGraph(String title,String unitInfo,IEnumerable<String> xdata,IEnumerable<Double> ydata,ImageFormat format);

    }
}
