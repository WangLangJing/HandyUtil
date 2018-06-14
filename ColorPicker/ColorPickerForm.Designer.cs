namespace ColorPicker
{
    partial class ColorPickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerForm));
            this._panelColorBoard = new System.Windows.Forms.Panel();
            this._timerCursorPoint = new System.Windows.Forms.Timer(this.components);
            this._labelColorRGBTitle = new System.Windows.Forms.Label();
            this._labelColorRGB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._labelPoint = new System.Windows.Forms.Label();
            this._labelColorHEX = new System.Windows.Forms.Label();
            this._labelColorHEXTitle = new System.Windows.Forms.Label();
            this._panelSelectContent = new System.Windows.Forms.Panel();
            this._panelSelectColor = new System.Windows.Forms.Panel();
            this._labelSelectedColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._labelClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this._panelSelectContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelColorBoard
            // 
            this._panelColorBoard.BackColor = System.Drawing.Color.DarkGray;
            this._panelColorBoard.Location = new System.Drawing.Point(10, 10);
            this._panelColorBoard.Name = "_panelColorBoard";
            this._panelColorBoard.Size = new System.Drawing.Size(50, 50);
            this._panelColorBoard.TabIndex = 0;
            // 
            // _timerCursorPoint
            // 
            this._timerCursorPoint.Interval = 150;
            this._timerCursorPoint.Tick += new System.EventHandler(this._timerCursorPoint_Tick);
            // 
            // _labelColorRGBTitle
            // 
            this._labelColorRGBTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._labelColorRGBTitle.AutoSize = true;
            this._labelColorRGBTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelColorRGBTitle.ForeColor = System.Drawing.Color.White;
            this._labelColorRGBTitle.Location = new System.Drawing.Point(12, 51);
            this._labelColorRGBTitle.Name = "_labelColorRGBTitle";
            this._labelColorRGBTitle.Size = new System.Drawing.Size(36, 17);
            this._labelColorRGBTitle.TabIndex = 1;
            this._labelColorRGBTitle.Text = "RGB:";
            this._labelColorRGBTitle.Click += new System.EventHandler(this._labelColorRGBTitle_Click);
            // 
            // _labelColorRGB
            // 
            this._labelColorRGB.AutoSize = true;
            this._labelColorRGB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelColorRGB.ForeColor = System.Drawing.Color.White;
            this._labelColorRGB.Location = new System.Drawing.Point(54, 51);
            this._labelColorRGB.Name = "_labelColorRGB";
            this._labelColorRGB.Size = new System.Drawing.Size(13, 17);
            this._labelColorRGB.TabIndex = 4;
            this._labelColorRGB.Text = "*";
            this._labelColorRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._panelColorBoard);
            this.panel1.Location = new System.Drawing.Point(141, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 70);
            this.panel1.TabIndex = 6;
            // 
            // _labelPoint
            // 
            this._labelPoint.AutoSize = true;
            this._labelPoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelPoint.ForeColor = System.Drawing.Color.White;
            this._labelPoint.Location = new System.Drawing.Point(15, 9);
            this._labelPoint.Name = "_labelPoint";
            this._labelPoint.Size = new System.Drawing.Size(13, 17);
            this._labelPoint.TabIndex = 7;
            this._labelPoint.Text = "*";
            // 
            // _labelColorHEX
            // 
            this._labelColorHEX.AutoSize = true;
            this._labelColorHEX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelColorHEX.ForeColor = System.Drawing.Color.White;
            this._labelColorHEX.Location = new System.Drawing.Point(54, 80);
            this._labelColorHEX.Name = "_labelColorHEX";
            this._labelColorHEX.Size = new System.Drawing.Size(13, 17);
            this._labelColorHEX.TabIndex = 9;
            this._labelColorHEX.Text = "*";
            this._labelColorHEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelColorHEXTitle
            // 
            this._labelColorHEXTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._labelColorHEXTitle.AutoSize = true;
            this._labelColorHEXTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelColorHEXTitle.ForeColor = System.Drawing.Color.White;
            this._labelColorHEXTitle.Location = new System.Drawing.Point(12, 80);
            this._labelColorHEXTitle.Name = "_labelColorHEXTitle";
            this._labelColorHEXTitle.Size = new System.Drawing.Size(35, 17);
            this._labelColorHEXTitle.TabIndex = 8;
            this._labelColorHEXTitle.Text = "HEX:";
            this._labelColorHEXTitle.Click += new System.EventHandler(this._labelColorHEXTitle_Click);
            // 
            // _panelSelectContent
            // 
            this._panelSelectContent.BackColor = System.Drawing.Color.White;
            this._panelSelectContent.Controls.Add(this._panelSelectColor);
            this._panelSelectContent.Location = new System.Drawing.Point(91, 145);
            this._panelSelectContent.Name = "_panelSelectContent";
            this._panelSelectContent.Size = new System.Drawing.Size(30, 30);
            this._panelSelectContent.TabIndex = 10;
            // 
            // _panelSelectColor
            // 
            this._panelSelectColor.BackColor = System.Drawing.Color.DarkGray;
            this._panelSelectColor.Location = new System.Drawing.Point(5, 5);
            this._panelSelectColor.Name = "_panelSelectColor";
            this._panelSelectColor.Size = new System.Drawing.Size(20, 20);
            this._panelSelectColor.TabIndex = 0;
            // 
            // _labelSelectedColor
            // 
            this._labelSelectedColor.AutoSize = true;
            this._labelSelectedColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelSelectedColor.ForeColor = System.Drawing.Color.White;
            this._labelSelectedColor.Location = new System.Drawing.Point(12, 158);
            this._labelSelectedColor.Name = "_labelSelectedColor";
            this._labelSelectedColor.Size = new System.Drawing.Size(13, 17);
            this._labelSelectedColor.TabIndex = 11;
            this._labelSelectedColor.Text = "*";
            this._labelSelectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selected:";
            // 
            // _labelClose
            // 
            this._labelClose.AutoSize = true;
            this._labelClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelClose.ForeColor = System.Drawing.Color.White;
            this._labelClose.Location = new System.Drawing.Point(201, 5);
            this._labelClose.Name = "_labelClose";
            this._labelClose.Size = new System.Drawing.Size(17, 17);
            this._labelClose.TabIndex = 13;
            this._labelClose.Text = "×";
            this._labelClose.Click += new System.EventHandler(this._labelClose_Click);
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(223, 187);
            this.Controls.Add(this._labelClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._labelSelectedColor);
            this.Controls.Add(this._panelSelectContent);
            this.Controls.Add(this._labelColorHEX);
            this.Controls.Add(this._labelColorHEXTitle);
            this.Controls.Add(this._labelPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._labelColorRGB);
            this.Controls.Add(this._labelColorRGBTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ColorPickerForm";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.panel1.ResumeLayout(false);
            this._panelSelectContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelColorBoard;
        private System.Windows.Forms.Timer _timerCursorPoint;
        private System.Windows.Forms.Label _labelColorRGBTitle;
        private System.Windows.Forms.Label _labelColorRGB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _labelPoint;
        private System.Windows.Forms.Label _labelColorHEX;
        private System.Windows.Forms.Label _labelColorHEXTitle;
        private System.Windows.Forms.Panel _panelSelectContent;
        private System.Windows.Forms.Panel _panelSelectColor;
        private System.Windows.Forms.Label _labelSelectedColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _labelClose;
    }
}

