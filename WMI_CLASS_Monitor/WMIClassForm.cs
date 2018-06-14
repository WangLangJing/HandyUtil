using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace WMI_CLASS_Monitor
{
    public partial class WMIClassForm : Form
    {
        private Dictionary<String, ManagementClass> _managementClassMapping = new Dictionary<String, ManagementClass>();
        private Dictionary<String, TreeNode> _treeNodeMapping = new Dictionary<String, TreeNode>();
  
        /**************/
        public WMIClassForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            this._bgdWorkerFetchNameSpace.DoWork += _bgdWorkerFetchNameSpace_DoWork;
            this._bgdWorkerFetchNameSpace.RunWorkerCompleted += _bgdWorkerFetchNameSpace_RunWorkerCompleted;


            this.LoadNamesapceNode();
 
        }

        private void _bgdWorkerFetchNameSpace_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                this._labelQueryStateInfo.Text = "WMI名空间信息获取成功，正在加载...";
                IList<String> namespaceStrList = e.Result as IList<String>;
                foreach (String single in namespaceStrList)
                {
                    TreeNode node = new TreeNode(single);
                    this._tvWmiClassInfo.Nodes.Add(node);
                    this._treeNodeMapping.Add(single, node);
                }
                this._tvWmiClassInfo.Sort();
                this._labelQueryStateInfo.Text = "";
            }
            else if (e.Error != null)
            {
                this._labelQueryStateInfo.Text = "WMI名空间信息获取失败," + e.Error.Message;
            }
        }

        private void _bgdWorkerFetchNameSpace_DoWork(Object sender, DoWorkEventArgs e)
        {
            this._labelQueryStateInfo.Text = "正在获取WMI名空间信息...";
            e.Result = WMIFetcher.FetchWMINamespace();

        }

        public void LoadNamesapceNode()
        {
            this._bgdWorkerFetchNameSpace.RunWorkerAsync();
        }

        private void _tvWmiClassInfo_NodeMouseClick(Object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Parent == null)
                {
                    this._labelAddressInfo.Text = e.Node.Text;
                    this.LoadWMIClassInfo(e.Node.Text);
                }
                else
                {
                    this.LoadAddressInfo(e.Node);
                    if (this._managementClassMapping.ContainsKey(e.Node.Text))
                    {
                        this.LoadClassPropertiesInfo(this._managementClassMapping[e.Node.Text]);
                    }
                }
            }
            else
            {
                if (e.Node.Parent != null)
                {
                    e.Node.ContextMenuStrip = this._cmsQueryClassValue;
                }
            }
        }
        private void LoadClassPropertiesInfo(ManagementClass mgtClass)
        {
            this._pannelContent.Controls.Clear();
            WMIClassProteriesBoard board = new WMIClassProteriesBoard(mgtClass);
            board.Dock = DockStyle.Fill;
            this._pannelContent.Controls.Add(board);
        }
        private void LoadAddressInfo(TreeNode strat)
        {
            TreeNode node = strat;
            this._labelAddressInfo.Text = String.Empty;
            while (node.Parent != null)
            {
                this._labelAddressInfo.Text = this._labelAddressInfo.Text.Insert(0, "->" + node.Text);
                node = node.Parent;
            }
            this._labelAddressInfo.Text = this._labelAddressInfo.Text.Insert(0, node.Text);
        }
        public void LoadWMIClassInfo(String namespaceStr)
        {
            if (this._treeNodeMapping.ContainsKey(namespaceStr) && this._treeNodeMapping[namespaceStr].Nodes.Count <= 0)
            {
                if (!this._bgdWorkerFetchWMIClass.IsBusy)
                {
                    this._bgdWorkerFetchWMIClass.RunWorkerAsync(namespaceStr);
                }
            }
        }
        private void _bgdWorkerFetchWMIClass_DoWork(Object sender, DoWorkEventArgs e)
        {
            String namespaceStr = e.Argument as String;
            if (null != namespaceStr)
            {
                this._labelQueryStateInfo.Text = String.Format("正在获取 {0} 名空间下的WMI 类信息...", namespaceStr);
                e.Result = new { WMIClassList = WMIFetcher.FetchWMIClass(namespaceStr), Namespace = namespaceStr };
            }
        }

        private void _bgdWorkerFetchWMIClass_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                this._labelQueryStateInfo.Text = "WMI类信息获取成功，正在加载...";
                dynamic reuslt = e.Result;
                IList<ManagementClass> wmiClassList = reuslt.WMIClassList;
                String namesapceStr = reuslt.Namespace;
                foreach (ManagementClass single in wmiClassList)
                {
                    String className = single["__CLASS"].ToString();
                    if (className != null)
                    {
                        if (this._treeNodeMapping.ContainsKey(namesapceStr))
                        {
                            TreeNode node = new TreeNode(className);
                            this._treeNodeMapping[namesapceStr].Nodes.Add(className);
                            if (!this._managementClassMapping.ContainsKey(className))
                            {
                                this._managementClassMapping.Add(className, single);
                            }
                            if (!this._treeNodeMapping.ContainsKey(className))
                            {
                                this._treeNodeMapping.Add(className, node);
                            }
                        }
                    }
                }
                this._tvWmiClassInfo.Sort();
                this._labelQueryStateInfo.Text = "";
            }
            else if (e.Error != null)
            {
                this._labelQueryStateInfo.Text = "WMI类信息获取失败," + e.Error.Message;
            }
        }
        private void QueryWMIClassInstance(String namespaceStr,String className)
        {
            WMIClassInstanceForm instanceFrom = new WMIClassInstanceForm(namespaceStr,className);
            instanceFrom.Show();
        }
        private void _tsmiQuery_Click(Object sender, EventArgs e)
        {
            TreeNode node = this._tvWmiClassInfo.SelectedNode;
            if (node != null && node.Parent!=null)
            {
                this.QueryWMIClassInstance(node.Parent.Text, node.Text);
            }
            else
            {
                MessageBox.Show("无效的节点选择");
            }
        }


    }
}
