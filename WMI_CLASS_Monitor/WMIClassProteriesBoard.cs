using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
namespace WMI_CLASS_Monitor
{
    public partial class WMIClassProteriesBoard : UserControl
    {
        public WMIClassProteriesBoard()
        {
            InitializeComponent();
        }
        public WMIClassProteriesBoard(ManagementClass mgtClass):this()
        {
            foreach (var property in mgtClass.Properties)
            {
                this._dgvPropertiesInfo.Rows.Add(
                    property.Name,
                    property.Type.ToString(),
                    property.Value?.ToString(),
                    property.IsArray?"是":"否"
                    );
            }
        }
    }
}
