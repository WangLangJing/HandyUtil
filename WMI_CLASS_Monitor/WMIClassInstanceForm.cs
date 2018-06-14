using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
namespace WMI_CLASS_Monitor
{
    public partial class WMIClassInstanceForm : Form
    {
        private ManagementObject[] _managementObjectArray = null;
        private Int32 _currentIndex = 0;

        public WMIClassInstanceForm()
        {
            InitializeComponent();
        }
        public WMIClassInstanceForm(String namespaceStr,String className):this()
        {
            this._labelNamespaceStr.Text = namespaceStr;
            this.Text = className;
            this._bgwQuery.RunWorkerAsync();
        }
        private void _gbwQuery_DoWork(Object sender, DoWorkEventArgs e)
        {
            this._labelStatus.Text = "正在查询此类的实例...";
             e.Result = WMIFetcher.FetchWMIClassInstance(
                  this._labelNamespaceStr.Text,
                  this.Text
                );
        }

        private void _gbwQuery_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                RichTextBox tex = new RichTextBox();
                this._labelStatus.Text = "查询完成，正在加载...";
                ManagementObjectCollection mgtObjCollection = e.Result as ManagementObjectCollection;
                List<ManagementObject> mgtObjList = new List<ManagementObject>();
                foreach (System.Management.ManagementObject mo in mgtObjCollection)
                {
                    mgtObjList.Add(mo);
                }
                if (mgtObjList.Count > 0)
                {
                    this._managementObjectArray = new ManagementObject[mgtObjList.Count];
                    mgtObjList.CopyTo(this._managementObjectArray);
                    this.SwitchMgtObjShow(this._currentIndex);
                    this._labelCount.Text = this._managementObjectArray.Length.ToString();
                }
                this._labelStatus.Text = "加载完毕";
            }
            else
            {
                this._labelStatus.Text = "查询失败，" + e.Error.Message;
            }
        }
        private void ShowManagementObj(ManagementObject mgtObj)
        {
            this._tbValues.Text = String.Empty;
            foreach (var pro in mgtObj.Properties)
            {
                String valueInfo = null;
                if (!pro.IsArray)
                {
                    switch (pro.Type)
                    {
                        default:
                            {
                                valueInfo = pro.Value?.ToString();
                            }
                            break;
                    }
                }
                else
                {
                    if (pro.Value != null)
                    {
                        System.Collections.IEnumerable valueArray = pro.Value as System.Collections.IEnumerable;
                        foreach (Object value in valueArray)
                        {
                            valueInfo += value.ToString() + " | ";
                        }
                    }
                }
                if (String.IsNullOrEmpty(valueInfo))
                {
                    this._tbValues.Text += String.Format("属性名称: {0}       " + "\r\n", pro.Name);
                }
                else
                {
                    this._tbValues.Text += String.Format("属性名称: {0}       值 : {1} " + "\r\n", pro.Name, valueInfo);
                }
            }
        }
        private void SwitchMgtObjShow(Int32 index)
        {
            if (this._managementObjectArray != null && index >= 0 && index < this._managementObjectArray.Length)
            {
                this.ShowManagementObj(this._managementObjectArray[index]);
                this._currentIndex = index;
                this._labelCurrentIndex.Text = (this._currentIndex + 1).ToString();
            }
        }
        private void _btnNext_Click(Object sender, EventArgs e)
        {
            this.SwitchMgtObjShow(this._currentIndex+1);
        }

        private void _btnLast_Click(Object sender, EventArgs e)
        {
            this.SwitchMgtObjShow(this._currentIndex-1);
        }
    }
}
