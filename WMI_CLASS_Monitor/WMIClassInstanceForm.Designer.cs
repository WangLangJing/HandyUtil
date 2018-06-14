namespace WMI_CLASS_Monitor
{
    partial class WMIClassInstanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMIClassInstanceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this._labelNamespaceStr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._labelCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this._labelStatus = new System.Windows.Forms.Label();
            this._tbValues = new System.Windows.Forms.TextBox();
            this._bgwQuery = new System.ComponentModel.BackgroundWorker();
            this._btnLast = new System.Windows.Forms.Button();
            this._btnNext = new System.Windows.Forms.Button();
            this._labelCurrentPageTitle = new System.Windows.Forms.Label();
            this._labelCurrentIndex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._labelNamespaceStr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 33);
            this.panel1.TabIndex = 0;
            // 
            // _labelNamespaceStr
            // 
            this._labelNamespaceStr.AutoSize = true;
            this._labelNamespaceStr.Location = new System.Drawing.Point(99, 9);
            this._labelNamespaceStr.Name = "_labelNamespaceStr";
            this._labelNamespaceStr.Size = new System.Drawing.Size(13, 17);
            this._labelNamespaceStr.TabIndex = 2;
            this._labelNamespaceStr.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "所属名空间：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._labelCurrentIndex);
            this.panel2.Controls.Add(this._labelCurrentPageTitle);
            this.panel2.Controls.Add(this._labelCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 32);
            this.panel2.TabIndex = 1;
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(87, 8);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(13, 17);
            this._labelCount.TabIndex = 1;
            this._labelCount.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "实例个数：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._btnNext);
            this.panel3.Controls.Add(this._btnLast);
            this.panel3.Controls.Add(this._labelStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 32);
            this.panel3.TabIndex = 2;
            // 
            // _labelStatus
            // 
            this._labelStatus.AutoSize = true;
            this._labelStatus.Location = new System.Drawing.Point(9, 8);
            this._labelStatus.Name = "_labelStatus";
            this._labelStatus.Size = new System.Drawing.Size(13, 17);
            this._labelStatus.TabIndex = 2;
            this._labelStatus.Text = "*";
            // 
            // _tbValues
            // 
            this._tbValues.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._tbValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbValues.Location = new System.Drawing.Point(0, 65);
            this._tbValues.Multiline = true;
            this._tbValues.Name = "_tbValues";
            this._tbValues.ReadOnly = true;
            this._tbValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._tbValues.Size = new System.Drawing.Size(584, 564);
            this._tbValues.TabIndex = 3;
            // 
            // _bgwQuery
            // 
            this._bgwQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this._gbwQuery_DoWork);
            this._bgwQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._gbwQuery_RunWorkerCompleted);
            // 
            // _btnLast
            // 
            this._btnLast.Location = new System.Drawing.Point(485, 5);
            this._btnLast.Name = "_btnLast";
            this._btnLast.Size = new System.Drawing.Size(37, 22);
            this._btnLast.TabIndex = 3;
            this._btnLast.Text = "←";
            this._btnLast.UseVisualStyleBackColor = true;
            this._btnLast.Click += new System.EventHandler(this._btnLast_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(535, 5);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(37, 22);
            this._btnNext.TabIndex = 4;
            this._btnNext.Text = "→";
            this._btnNext.UseVisualStyleBackColor = true;
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _labelCurrentPageTitle
            // 
            this._labelCurrentPageTitle.AutoSize = true;
            this._labelCurrentPageTitle.Location = new System.Drawing.Point(172, 8);
            this._labelCurrentPageTitle.Name = "_labelCurrentPageTitle";
            this._labelCurrentPageTitle.Size = new System.Drawing.Size(56, 17);
            this._labelCurrentPageTitle.TabIndex = 3;
            this._labelCurrentPageTitle.Text = "当前页：";
            // 
            // _labelCurrentIndex
            // 
            this._labelCurrentIndex.AutoSize = true;
            this._labelCurrentIndex.Location = new System.Drawing.Point(240, 8);
            this._labelCurrentIndex.Name = "_labelCurrentIndex";
            this._labelCurrentIndex.Size = new System.Drawing.Size(13, 17);
            this._labelCurrentIndex.TabIndex = 4;
            this._labelCurrentIndex.Text = "*";
            // 
            // WMIClassInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this._tbValues);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "WMIClassInstanceForm";
            this.Text = "WMIClassInstanceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox _tbValues;
        private System.Windows.Forms.Label _labelCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _labelNamespaceStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _labelStatus;
        private System.ComponentModel.BackgroundWorker _bgwQuery;
        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.Button _btnLast;
        private System.Windows.Forms.Label _labelCurrentIndex;
        private System.Windows.Forms.Label _labelCurrentPageTitle;
    }
}