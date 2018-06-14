namespace Calendar
{
    partial class MonthCalendar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this._pnlTop = new System.Windows.Forms.Panel();
            this._pnlBottom = new System.Windows.Forms.Panel();
            this._pnlMiddle = new System.Windows.Forms.Panel();
            this._flpDays = new System.Windows.Forms.FlowLayoutPanel();
            this._pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlTop
            // 
            this._pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlTop.Location = new System.Drawing.Point(0, 0);
            this._pnlTop.Name = "_pnlTop";
            this._pnlTop.Size = new System.Drawing.Size(639, 42);
            this._pnlTop.TabIndex = 0;
            // 
            // _pnlBottom
            // 
            this._pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnlBottom.Location = new System.Drawing.Point(0, 614);
            this._pnlBottom.Name = "_pnlBottom";
            this._pnlBottom.Size = new System.Drawing.Size(639, 30);
            this._pnlBottom.TabIndex = 1;
            // 
            // _pnlMiddle
            // 
            this._pnlMiddle.Controls.Add(this._flpDays);
            this._pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMiddle.Location = new System.Drawing.Point(0, 42);
            this._pnlMiddle.Name = "_pnlMiddle";
            this._pnlMiddle.Size = new System.Drawing.Size(639, 572);
            this._pnlMiddle.TabIndex = 2;
            // 
            // _flpDays
            // 
            this._flpDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpDays.Location = new System.Drawing.Point(0, 0);
            this._flpDays.Name = "_flpDays";
            this._flpDays.Size = new System.Drawing.Size(639, 572);
            this._flpDays.TabIndex = 0;
            // 
            // MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this._pnlMiddle);
            this.Controls.Add(this._pnlBottom);
            this.Controls.Add(this._pnlTop);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MonthCalendar";
            this.Size = new System.Drawing.Size(639, 644);
            this._pnlMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.Panel _pnlBottom;
        private System.Windows.Forms.Panel _pnlMiddle;
        private System.Windows.Forms.FlowLayoutPanel _flpDays;
    }
}
