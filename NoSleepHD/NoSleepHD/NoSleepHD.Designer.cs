namespace NoSleepHD
{
    partial class NoSleepHDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoSleepHDForm));
            this._buttonClose = new System.Windows.Forms.Button();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this._timerActivate = new System.Windows.Forms.Timer(this.components);
            this._buttonEnd = new System.Windows.Forms.Button();
            this._buttonBegin = new System.Windows.Forms.Button();
            this._nudSleepInterval = new System.Windows.Forms.NumericUpDown();
            this._contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSleepInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonClose
            // 
            this._buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonClose.BackgroundImage = global::NoSleepHD.Properties.Resources.Close_Normal;
            this._buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonClose.Location = new System.Drawing.Point(215, 12);
            this._buttonClose.Name = "_buttonClose";
            this._buttonClose.Size = new System.Drawing.Size(20, 20);
            this._buttonClose.TabIndex = 0;
            this._buttonClose.UseVisualStyleBackColor = false;
            this._buttonClose.Click += new System.EventHandler(this._buttonClose_Click);
            this._buttonClose.MouseEnter += new System.EventHandler(this._buttonClose_MouseEnter);
            this._buttonClose.MouseLeave += new System.EventHandler(this._buttonClose_MouseLeave);
            // 
            // _notifyIcon
            // 
            this._notifyIcon.ContextMenuStrip = this._contextMenuStrip;
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "NoSleepHD";
            this._notifyIcon.Visible = true;
            this._notifyIcon.DoubleClick += new System.EventHandler(this._notifyIcon_DoubleClick);
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiShow,
            this._tsmiExit});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // _tsmiShow
            // 
            this._tsmiShow.Name = "_tsmiShow";
            this._tsmiShow.Size = new System.Drawing.Size(107, 22);
            this._tsmiShow.Text = "Show";
            this._tsmiShow.Click += new System.EventHandler(this._tsmiShow_Click);
            // 
            // _tsmiExit
            // 
            this._tsmiExit.Name = "_tsmiExit";
            this._tsmiExit.Size = new System.Drawing.Size(107, 22);
            this._tsmiExit.Text = "Exit";
            this._tsmiExit.Click += new System.EventHandler(this._tsmiExit_Click);
            // 
            // _timerActivate
            // 
            this._timerActivate.Interval = 5000;
            this._timerActivate.Tick += new System.EventHandler(this._timeractivate_Tick);
            // 
            // _buttonEnd
            // 
            this._buttonEnd.Location = new System.Drawing.Point(53, 10);
            this._buttonEnd.Name = "_buttonEnd";
            this._buttonEnd.Size = new System.Drawing.Size(25, 25);
            this._buttonEnd.TabIndex = 2;
            this._buttonEnd.Text = "E";
            this._buttonEnd.UseVisualStyleBackColor = true;
            this._buttonEnd.Click += new System.EventHandler(this._buttonEnd_Click);
            // 
            // _buttonBegin
            // 
            this._buttonBegin.Location = new System.Drawing.Point(12, 10);
            this._buttonBegin.Name = "_buttonBegin";
            this._buttonBegin.Size = new System.Drawing.Size(25, 25);
            this._buttonBegin.TabIndex = 3;
            this._buttonBegin.Text = "B";
            this._buttonBegin.UseVisualStyleBackColor = true;
            this._buttonBegin.Click += new System.EventHandler(this._buttonBegin_Click);
            // 
            // _nudSleepInterval
            // 
            this._nudSleepInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._nudSleepInterval.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._nudSleepInterval.Location = new System.Drawing.Point(100, 11);
            this._nudSleepInterval.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this._nudSleepInterval.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._nudSleepInterval.Name = "_nudSleepInterval";
            this._nudSleepInterval.Size = new System.Drawing.Size(109, 23);
            this._nudSleepInterval.TabIndex = 4;
            this._nudSleepInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // NoSleepHDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(243, 44);
            this.Controls.Add(this._nudSleepInterval);
            this.Controls.Add(this._buttonBegin);
            this.Controls.Add(this._buttonEnd);
            this.Controls.Add(this._buttonClose);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NoSleepHDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoSleepHd";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoSleepHDForm_FormClosed);
            this._contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._nudSleepInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonClose;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem _tsmiExit;
        private System.Windows.Forms.Timer _timerActivate;
        private System.Windows.Forms.Button _buttonEnd;
        private System.Windows.Forms.Button _buttonBegin;
        private System.Windows.Forms.NumericUpDown _nudSleepInterval;
    }
}

