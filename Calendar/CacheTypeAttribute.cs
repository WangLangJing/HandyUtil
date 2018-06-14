using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    /*-------------------------------------------------------------------------
 * 版权所有：王浪静
 * 作者：王浪静
 * 联系方式：932444208@qq.com
 * 创建时间： 2017/8/24 9:25:43
 * 版本号：v1.0
 * .NET 版本：4.0
 * 本类主要用途描述：
 *  -------------------------------------------------------------------------*/
    public class CacheTypeAttribute : System.Attribute
    {
        private String _name = null;
        public CacheTypeAttribute()
        {
            Int32 i = 0;
            Int32 j = 0;
        }
        public CacheTypeAttribute(String name)
        {
            this._name = name;
        }
    }
}
