namespace PowerOnRegister
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._tbPowerOnPath = new System.Windows.Forms.TextBox();
            this._tbPoweronParameter = new System.Windows.Forms.TextBox();
            this._btnSelectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._tbPowerOnName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "启动路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "启动参数：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(358, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "确 认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _tbPowerOnPath
            // 
            this._tbPowerOnPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this._tbPowerOnPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._tbPowerOnPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this._tbPowerOnPath.Location = new System.Drawing.Point(111, 75);
            this._tbPowerOnPath.Name = "_tbPowerOnPath";
            this._tbPowerOnPath.Size = new System.Drawing.Size(307, 23);
            this._tbPowerOnPath.TabIndex = 3;
            // 
            // _tbPoweronParameter
            // 
            this._tbPoweronParameter.BackColor = System.Drawing.Color.WhiteSmoke;
            this._tbPoweronParameter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._tbPoweronParameter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this._tbPoweronParameter.Location = new System.Drawing.Point(111, 126);
            this._tbPoweronParameter.Name = "_tbPoweronParameter";
            this._tbPoweronParameter.Size = new System.Drawing.Size(307, 23);
            this._tbPoweronParameter.TabIndex = 4;
            // 
            // _btnSelectPath
            // 
            this._btnSelectPath.Location = new System.Drawing.Point(422, 75);
            this._btnSelectPath.Name = "_btnSelectPath";
            this._btnSelectPath.Size = new System.Drawing.Size(26, 24);
            this._btnSelectPath.TabIndex = 5;
            this._btnSelectPath.Text = "...";
            this._btnSelectPath.UseVisualStyleBackColor = true;
            this._btnSelectPath.Click += new System.EventHandler(this._btnSelectPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "启动名称：";
            // 
            // _tbPowerOnName
            // 
            this._tbPowerOnName.BackColor = System.Drawing.Color.WhiteSmoke;
            this._tbPowerOnName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._tbPowerOnName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this._tbPowerOnName.Location = new System.Drawing.Point(111, 29);
            this._tbPowerOnName.Name = "_tbPowerOnName";
            this._tbPowerOnName.Size = new System.Drawing.Size(307, 23);
            this._tbPowerOnName.TabIndex = 7;
            this._tbPowerOnName.Text = "PowerOn1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "|*.exe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(461, 219);
            this.Controls.Add(this._tbPowerOnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnSelectPath);
            this.Controls.Add(this._tbPoweronParameter);
            this.Controls.Add(this._tbPowerOnPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 258);
            this.Name = "MainForm";
            this.Text = "Power On(Nssc)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _tbPowerOnPath;
        private System.Windows.Forms.TextBox _tbPoweronParameter;
        private System.Windows.Forms.Button _btnSelectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbPowerOnName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

