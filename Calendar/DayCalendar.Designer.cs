namespace Calendar
{
    partial class DayCalendar
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
            this._lblDay = new System.Windows.Forms.Label();
            this._lblYearMonth = new System.Windows.Forms.Label();
            this._lblWeek = new System.Windows.Forms.Label();
            this._lblHoliday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblDay
            // 
            this._lblDay.AutoSize = true;
            this._lblDay.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblDay.ForeColor = System.Drawing.Color.White;
            this._lblDay.Location = new System.Drawing.Point(8, 36);
            this._lblDay.Name = "_lblDay";
            this._lblDay.Size = new System.Drawing.Size(52, 31);
            this._lblDay.TabIndex = 0;
            this._lblDay.Text = "DD";
            // 
            // _lblYearMonth
            // 
            this._lblYearMonth.AutoSize = true;
            this._lblYearMonth.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblYearMonth.ForeColor = System.Drawing.Color.White;
            this._lblYearMonth.Location = new System.Drawing.Point(8, 10);
            this._lblYearMonth.Name = "_lblYearMonth";
            this._lblYearMonth.Size = new System.Drawing.Size(75, 19);
            this._lblYearMonth.TabIndex = 1;
            this._lblYearMonth.Text = "yyyy-MM";
            // 
            // _lblWeek
            // 
            this._lblWeek.AutoSize = true;
            this._lblWeek.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblWeek.ForeColor = System.Drawing.Color.White;
            this._lblWeek.Location = new System.Drawing.Point(16, 74);
            this._lblWeek.Name = "_lblWeek";
            this._lblWeek.Size = new System.Drawing.Size(46, 19);
            this._lblWeek.TabIndex = 2;
            this._lblWeek.Text = "星期#";
            // 
            // _lblHoliday
            // 
            this._lblHoliday.AutoSize = true;
            this._lblHoliday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblHoliday.ForeColor = System.Drawing.Color.Red;
            this._lblHoliday.Location = new System.Drawing.Point(61, 49);
            this._lblHoliday.Name = "_lblHoliday";
            this._lblHoliday.Size = new System.Drawing.Size(20, 17);
            this._lblHoliday.TabIndex = 3;
            this._lblHoliday.Text = "假";
            // 
            // DayCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Controls.Add(this._lblHoliday);
            this.Controls.Add(this._lblWeek);
            this.Controls.Add(this._lblYearMonth);
            this.Controls.Add(this._lblDay);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DayCalendar";
            this.Size = new System.Drawing.Size(85, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDay;
        private System.Windows.Forms.Label _lblYearMonth;
        private System.Windows.Forms.Label _lblWeek;
        private System.Windows.Forms.Label _lblHoliday;
    }
}
