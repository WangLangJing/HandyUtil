namespace WMI_CLASS_Monitor
{
    partial class WMIClassForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMIClassForm));
            this._labelQueryResultInfo = new System.Windows.Forms.Label();
            this._labelAddressInfo = new System.Windows.Forms.Label();
            this._labelQueryStateInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this._tvWmiClassInfo = new System.Windows.Forms.TreeView();
            this._pannelContent = new System.Windows.Forms.Panel();
            this._bgdWorkerFetchNameSpace = new System.ComponentModel.BackgroundWorker();
            this._bgdWorkerFetchWMIClass = new System.ComponentModel.BackgroundWorker();
            this._cmsQueryClassValue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this._cmsQueryClassValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelQueryResultInfo
            // 
            this._labelQueryResultInfo.AutoSize = true;
            this._labelQueryResultInfo.Location = new System.Drawing.Point(17, 4);
            this._labelQueryResultInfo.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this._labelQueryResultInfo.Name = "_labelQueryResultInfo";
            this._labelQueryResultInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._labelQueryResultInfo.Size = new System.Drawing.Size(23, 17);
            this._labelQueryResultInfo.TabIndex = 2;
            this._labelQueryResultInfo.Text = "*";
            // 
            // _labelAddressInfo
            // 
            this._labelAddressInfo.AutoSize = true;
            this._labelAddressInfo.Location = new System.Drawing.Point(19, 11);
            this._labelAddressInfo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._labelAddressInfo.Name = "_labelAddressInfo";
            this._labelAddressInfo.Size = new System.Drawing.Size(13, 17);
            this._labelAddressInfo.TabIndex = 2;
            this._labelAddressInfo.Text = "*";
            // 
            // _labelQueryStateInfo
            // 
            this._labelQueryStateInfo.AutoSize = true;
            this._labelQueryStateInfo.Location = new System.Drawing.Point(19, 11);
            this._labelQueryStateInfo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._labelQueryStateInfo.Name = "_labelQueryStateInfo";
            this._labelQueryStateInfo.Size = new System.Drawing.Size(13, 17);
            this._labelQueryStateInfo.TabIndex = 2;
            this._labelQueryStateInfo.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this._labelQueryStateInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 31);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this._labelAddressInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 31);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this._labelQueryResultInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 31);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 528);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._tvWmiClassInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 528);
            this.panel5.TabIndex = 0;
            // 
            // _tvWmiClassInfo
            // 
            this._tvWmiClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tvWmiClassInfo.Location = new System.Drawing.Point(0, 0);
            this._tvWmiClassInfo.Name = "_tvWmiClassInfo";
            this._tvWmiClassInfo.Size = new System.Drawing.Size(302, 528);
            this._tvWmiClassInfo.TabIndex = 0;
            this._tvWmiClassInfo.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._tvWmiClassInfo_NodeMouseClick);
            // 
            // _pannelContent
            // 
            this._pannelContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this._pannelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pannelContent.Location = new System.Drawing.Point(302, 62);
            this._pannelContent.Name = "_pannelContent";
            this._pannelContent.Size = new System.Drawing.Size(582, 528);
            this._pannelContent.TabIndex = 8;
            // 
            // _bgdWorkerFetchWMIClass
            // 
            this._bgdWorkerFetchWMIClass.DoWork += new System.ComponentModel.DoWorkEventHandler(this._bgdWorkerFetchWMIClass_DoWork);
            this._bgdWorkerFetchWMIClass.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._bgdWorkerFetchWMIClass_RunWorkerCompleted);
            // 
            // _cmsQueryClassValue
            // 
            this._cmsQueryClassValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cmsQueryClassValue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiQuery});
            this._cmsQueryClassValue.Name = "_cmsQueryClassValue";
            this._cmsQueryClassValue.Size = new System.Drawing.Size(137, 26);
            // 
            // _tsmiQuery
            // 
            this._tsmiQuery.Image = ((System.Drawing.Image)(resources.GetObject("_tsmiQuery.Image")));
            this._tsmiQuery.Name = "_tsmiQuery";
            this._tsmiQuery.Size = new System.Drawing.Size(136, 22);
            this._tsmiQuery.Text = "查询类实例";
            this._tsmiQuery.Click += new System.EventHandler(this._tsmiQuery_Click);
            // 
            // WMIClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this._pannelContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 660);
            this.Name = "WMIClassForm";
            this.Text = "WMIClass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this._cmsQueryClassValue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _labelAddressInfo;
        private System.Windows.Forms.Label _labelQueryStateInfo;
        private System.Windows.Forms.Label _labelQueryResultInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel _pannelContent;
        private System.Windows.Forms.TreeView _tvWmiClassInfo;
        private System.ComponentModel.BackgroundWorker _bgdWorkerFetchNameSpace;
        private System.ComponentModel.BackgroundWorker _bgdWorkerFetchWMIClass;
        private System.Windows.Forms.ContextMenuStrip _cmsQueryClassValue;
        private System.Windows.Forms.ToolStripMenuItem _tsmiQuery;
    }
}

