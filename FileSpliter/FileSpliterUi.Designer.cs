namespace FileSpliter
{
    partial class FileSpliterUi
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectBeSplitFile = new System.Windows.Forms.Label();
            this.TXT_BeSplited = new System.Windows.Forms.TextBox();
            this.groupBoxSpliteFile = new System.Windows.Forms.GroupBox();
            this.labelSplitePro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSpliteOfNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonSpliteOfSize = new System.Windows.Forms.RadioButton();
            this.numericUpDownSpliteCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSpliteSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSpliteUnit = new System.Windows.Forms.ComboBox();
            this.buttonSelectFileOfStore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxＤepositary = new System.Windows.Forms.TextBox();
            this.buttonSpliteStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarSpliteProgress = new System.Windows.Forms.ProgressBar();
            this.buttonSelectFileOfSplite = new System.Windows.Forms.Button();
            this.groupBoxFileCombinFile = new System.Windows.Forms.GroupBox();
            this.progressBarCombineProcesser = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCombineStart = new System.Windows.Forms.Button();
            this.buttonSelectStoragePathOfCombine = new System.Windows.Forms.Button();
            this.textBoxCombinedFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSelectedCombinFile = new System.Windows.Forms.Button();
            this.textBoxCombinFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTaskInfo = new System.Windows.Forms.TextBox();
            this.labelCombinePro = new System.Windows.Forms.Label();
            this.groupBoxSpliteFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpliteCount)).BeginInit();
            this.groupBoxFileCombinFile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectBeSplitFile
            // 
            this.labelSelectBeSplitFile.AutoSize = true;
            this.labelSelectBeSplitFile.Location = new System.Drawing.Point(19, 47);
            this.labelSelectBeSplitFile.Name = "labelSelectBeSplitFile";
            this.labelSelectBeSplitFile.Size = new System.Drawing.Size(148, 20);
            this.labelSelectBeSplitFile.TabIndex = 0;
            this.labelSelectBeSplitFile.Text = "选择要被分割的文件:";
            this.labelSelectBeSplitFile.Click += new System.EventHandler(this.labelSelectBeSplitFile_Click);
            // 
            // TXT_BeSplited
            // 
            this.TXT_BeSplited.BackColor = System.Drawing.Color.White;
            this.TXT_BeSplited.Location = new System.Drawing.Point(23, 70);
            this.TXT_BeSplited.Name = "TXT_BeSplited";
            this.TXT_BeSplited.ReadOnly = true;
            this.TXT_BeSplited.Size = new System.Drawing.Size(490, 27);
            this.TXT_BeSplited.TabIndex = 1;
            this.TXT_BeSplited.TextChanged += new System.EventHandler(this.textBoxBeSplited_TextChanged);
            // 
            // groupBoxSpliteFile
            // 
            this.groupBoxSpliteFile.Controls.Add(this.labelSplitePro);
            this.groupBoxSpliteFile.Controls.Add(this.groupBox1);
            this.groupBoxSpliteFile.Controls.Add(this.buttonSelectFileOfStore);
            this.groupBoxSpliteFile.Controls.Add(this.label2);
            this.groupBoxSpliteFile.Controls.Add(this.textBoxＤepositary);
            this.groupBoxSpliteFile.Controls.Add(this.buttonSpliteStart);
            this.groupBoxSpliteFile.Controls.Add(this.label1);
            this.groupBoxSpliteFile.Controls.Add(this.progressBarSpliteProgress);
            this.groupBoxSpliteFile.Controls.Add(this.buttonSelectFileOfSplite);
            this.groupBoxSpliteFile.Controls.Add(this.TXT_BeSplited);
            this.groupBoxSpliteFile.Controls.Add(this.labelSelectBeSplitFile);
            this.groupBoxSpliteFile.Location = new System.Drawing.Point(26, 62);
            this.groupBoxSpliteFile.Name = "groupBoxSpliteFile";
            this.groupBoxSpliteFile.Size = new System.Drawing.Size(896, 271);
            this.groupBoxSpliteFile.TabIndex = 2;
            this.groupBoxSpliteFile.TabStop = false;
            this.groupBoxSpliteFile.Text = "文件分割";
            // 
            // labelSplitePro
            // 
            this.labelSplitePro.AutoSize = true;
            this.labelSplitePro.Location = new System.Drawing.Point(98, 202);
            this.labelSplitePro.Name = "labelSplitePro";
            this.labelSplitePro.Size = new System.Drawing.Size(0, 20);
            this.labelSplitePro.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSpliteOfNumber);
            this.groupBox1.Controls.Add(this.radioButtonSpliteOfSize);
            this.groupBox1.Controls.Add(this.numericUpDownSpliteCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSpliteSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxSpliteUnit);
            this.groupBox1.Location = new System.Drawing.Point(656, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分割方式";
            // 
            // radioButtonSpliteOfNumber
            // 
            this.radioButtonSpliteOfNumber.AutoSize = true;
            this.radioButtonSpliteOfNumber.Location = new System.Drawing.Point(6, 93);
            this.radioButtonSpliteOfNumber.Name = "radioButtonSpliteOfNumber";
            this.radioButtonSpliteOfNumber.Size = new System.Drawing.Size(17, 16);
            this.radioButtonSpliteOfNumber.TabIndex = 15;
            this.radioButtonSpliteOfNumber.TabStop = true;
            this.radioButtonSpliteOfNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpliteOfSize
            // 
            this.radioButtonSpliteOfSize.AutoSize = true;
            this.radioButtonSpliteOfSize.Location = new System.Drawing.Point(6, 36);
            this.radioButtonSpliteOfSize.Name = "radioButtonSpliteOfSize";
            this.radioButtonSpliteOfSize.Size = new System.Drawing.Size(17, 16);
            this.radioButtonSpliteOfSize.TabIndex = 14;
            this.radioButtonSpliteOfSize.TabStop = true;
            this.radioButtonSpliteOfSize.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSpliteCount
            // 
            this.numericUpDownSpliteCount.BackColor = System.Drawing.Color.White;
            this.numericUpDownSpliteCount.Location = new System.Drawing.Point(35, 112);
            this.numericUpDownSpliteCount.Name = "numericUpDownSpliteCount";
            this.numericUpDownSpliteCount.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownSpliteCount.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "数量:";
            // 
            // textBoxSpliteSize
            // 
            this.textBoxSpliteSize.BackColor = System.Drawing.Color.White;
            this.textBoxSpliteSize.Location = new System.Drawing.Point(35, 54);
            this.textBoxSpliteSize.Name = "textBoxSpliteSize";
            this.textBoxSpliteSize.Size = new System.Drawing.Size(81, 27);
            this.textBoxSpliteSize.TabIndex = 11;
            this.textBoxSpliteSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "大小               （单位）:";
            // 
            // comboBoxSpliteUnit
            // 
            this.comboBoxSpliteUnit.BackColor = System.Drawing.Color.White;
            this.comboBoxSpliteUnit.FormattingEnabled = true;
            this.comboBoxSpliteUnit.Items.AddRange(new object[] {
            "Byte",
            "KB",
            "MB",
            "GB"});
            this.comboBoxSpliteUnit.Location = new System.Drawing.Point(122, 53);
            this.comboBoxSpliteUnit.Name = "comboBoxSpliteUnit";
            this.comboBoxSpliteUnit.Size = new System.Drawing.Size(65, 28);
            this.comboBoxSpliteUnit.TabIndex = 9;
            this.comboBoxSpliteUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpliteUnit_SelectedIndexChanged);
            // 
            // buttonSelectFileOfStore
            // 
            this.buttonSelectFileOfStore.Location = new System.Drawing.Point(529, 151);
            this.buttonSelectFileOfStore.Name = "buttonSelectFileOfStore";
            this.buttonSelectFileOfStore.Size = new System.Drawing.Size(98, 31);
            this.buttonSelectFileOfStore.TabIndex = 8;
            this.buttonSelectFileOfStore.Text = "选择路径";
            this.buttonSelectFileOfStore.UseVisualStyleBackColor = true;
            this.buttonSelectFileOfStore.Click += new System.EventHandler(this.buttonSelectFileOfStore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "选择存放路径:";
            // 
            // textBoxＤepositary
            // 
            this.textBoxＤepositary.BackColor = System.Drawing.Color.White;
            this.textBoxＤepositary.Location = new System.Drawing.Point(23, 155);
            this.textBoxＤepositary.Name = "textBoxＤepositary";
            this.textBoxＤepositary.ReadOnly = true;
            this.textBoxＤepositary.Size = new System.Drawing.Size(490, 27);
            this.textBoxＤepositary.TabIndex = 6;
            this.textBoxＤepositary.TextChanged += new System.EventHandler(this.textBoxＤepositary_TextChanged);
            // 
            // buttonSpliteStart
            // 
            this.buttonSpliteStart.Location = new System.Drawing.Point(788, 216);
            this.buttonSpliteStart.Name = "buttonSpliteStart";
            this.buttonSpliteStart.Size = new System.Drawing.Size(87, 35);
            this.buttonSpliteStart.TabIndex = 5;
            this.buttonSpliteStart.Text = "开始";
            this.buttonSpliteStart.UseVisualStyleBackColor = true;
            this.buttonSpliteStart.Click += new System.EventHandler(this.buttonSpliteStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "分割进度:";
            // 
            // progressBarSpliteProgress
            // 
            this.progressBarSpliteProgress.Location = new System.Drawing.Point(43, 225);
            this.progressBarSpliteProgress.Name = "progressBarSpliteProgress";
            this.progressBarSpliteProgress.Size = new System.Drawing.Size(607, 23);
            this.progressBarSpliteProgress.TabIndex = 3;
            this.progressBarSpliteProgress.Click += new System.EventHandler(this.progressBarSpliteProgress_Click);
            // 
            // buttonSelectFileOfSplite
            // 
            this.buttonSelectFileOfSplite.Location = new System.Drawing.Point(529, 66);
            this.buttonSelectFileOfSplite.Name = "buttonSelectFileOfSplite";
            this.buttonSelectFileOfSplite.Size = new System.Drawing.Size(98, 31);
            this.buttonSelectFileOfSplite.TabIndex = 2;
            this.buttonSelectFileOfSplite.Text = "选择文件";
            this.buttonSelectFileOfSplite.UseVisualStyleBackColor = true;
            this.buttonSelectFileOfSplite.Click += new System.EventHandler(this.buttonSelectFileOfSplite_Click);
            // 
            // groupBoxFileCombinFile
            // 
            this.groupBoxFileCombinFile.Controls.Add(this.labelCombinePro);
            this.groupBoxFileCombinFile.Controls.Add(this.progressBarCombineProcesser);
            this.groupBoxFileCombinFile.Controls.Add(this.label7);
            this.groupBoxFileCombinFile.Controls.Add(this.buttonCombineStart);
            this.groupBoxFileCombinFile.Controls.Add(this.buttonSelectStoragePathOfCombine);
            this.groupBoxFileCombinFile.Controls.Add(this.textBoxCombinedFilePath);
            this.groupBoxFileCombinFile.Controls.Add(this.label6);
            this.groupBoxFileCombinFile.Controls.Add(this.label5);
            this.groupBoxFileCombinFile.Controls.Add(this.buttonSelectedCombinFile);
            this.groupBoxFileCombinFile.Controls.Add(this.textBoxCombinFile);
            this.groupBoxFileCombinFile.Location = new System.Drawing.Point(26, 354);
            this.groupBoxFileCombinFile.Name = "groupBoxFileCombinFile";
            this.groupBoxFileCombinFile.Size = new System.Drawing.Size(895, 262);
            this.groupBoxFileCombinFile.TabIndex = 3;
            this.groupBoxFileCombinFile.TabStop = false;
            this.groupBoxFileCombinFile.Text = "文件合并";
            // 
            // progressBarCombineProcesser
            // 
            this.progressBarCombineProcesser.Location = new System.Drawing.Point(43, 220);
            this.progressBarCombineProcesser.Name = "progressBarCombineProcesser";
            this.progressBarCombineProcesser.Size = new System.Drawing.Size(626, 23);
            this.progressBarCombineProcesser.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "合并进度:";
            // 
            // buttonCombineStart
            // 
            this.buttonCombineStart.Location = new System.Drawing.Point(791, 208);
            this.buttonCombineStart.Name = "buttonCombineStart";
            this.buttonCombineStart.Size = new System.Drawing.Size(87, 35);
            this.buttonCombineStart.TabIndex = 10;
            this.buttonCombineStart.Text = "开始";
            this.buttonCombineStart.UseVisualStyleBackColor = true;
            this.buttonCombineStart.Click += new System.EventHandler(this.buttonCombineStart_Click);
            // 
            // buttonSelectStoragePathOfCombine
            // 
            this.buttonSelectStoragePathOfCombine.Location = new System.Drawing.Point(777, 61);
            this.buttonSelectStoragePathOfCombine.Name = "buttonSelectStoragePathOfCombine";
            this.buttonSelectStoragePathOfCombine.Size = new System.Drawing.Size(98, 31);
            this.buttonSelectStoragePathOfCombine.TabIndex = 9;
            this.buttonSelectStoragePathOfCombine.Text = "选择路径";
            this.buttonSelectStoragePathOfCombine.UseVisualStyleBackColor = true;
            this.buttonSelectStoragePathOfCombine.Click += new System.EventHandler(this.buttonSelectStoragePathOfCombine_Click);
            // 
            // textBoxCombinedFilePath
            // 
            this.textBoxCombinedFilePath.BackColor = System.Drawing.Color.White;
            this.textBoxCombinedFilePath.Location = new System.Drawing.Point(330, 63);
            this.textBoxCombinedFilePath.Name = "textBoxCombinedFilePath";
            this.textBoxCombinedFilePath.ReadOnly = true;
            this.textBoxCombinedFilePath.Size = new System.Drawing.Size(442, 27);
            this.textBoxCombinedFilePath.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = " 选择合并后文件存放的路径:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "选择要被合并的文件:";
            // 
            // buttonSelectedCombinFile
            // 
            this.buttonSelectedCombinFile.Location = new System.Drawing.Point(213, 26);
            this.buttonSelectedCombinFile.Name = "buttonSelectedCombinFile";
            this.buttonSelectedCombinFile.Size = new System.Drawing.Size(98, 31);
            this.buttonSelectedCombinFile.TabIndex = 3;
            this.buttonSelectedCombinFile.Text = "选择文件集";
            this.buttonSelectedCombinFile.UseVisualStyleBackColor = true;
            this.buttonSelectedCombinFile.Click += new System.EventHandler(this.buttonSelectedCombinFile_Click);
            // 
            // textBoxCombinFile
            // 
            this.textBoxCombinFile.BackColor = System.Drawing.Color.White;
            this.textBoxCombinFile.Location = new System.Drawing.Point(23, 63);
            this.textBoxCombinFile.Multiline = true;
            this.textBoxCombinFile.Name = "textBoxCombinFile";
            this.textBoxCombinFile.ReadOnly = true;
            this.textBoxCombinFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCombinFile.Size = new System.Drawing.Size(288, 121);
            this.textBoxCombinFile.TabIndex = 2;
            this.textBoxCombinFile.WordWrap = false;
            this.textBoxCombinFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTaskInfo);
            this.groupBox2.Location = new System.Drawing.Point(931, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 553);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "任务信息";
            // 
            // textBoxTaskInfo
            // 
            this.textBoxTaskInfo.BackColor = System.Drawing.Color.White;
            this.textBoxTaskInfo.Location = new System.Drawing.Point(11, 28);
            this.textBoxTaskInfo.Multiline = true;
            this.textBoxTaskInfo.Name = "textBoxTaskInfo";
            this.textBoxTaskInfo.ReadOnly = true;
            this.textBoxTaskInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTaskInfo.Size = new System.Drawing.Size(283, 519);
            this.textBoxTaskInfo.TabIndex = 0;
            this.textBoxTaskInfo.WordWrap = false;
            // 
            // labelCombinePro
            // 
            this.labelCombinePro.AutoSize = true;
            this.labelCombinePro.Location = new System.Drawing.Point(89, 197);
            this.labelCombinePro.Name = "labelCombinePro";
            this.labelCombinePro.Size = new System.Drawing.Size(0, 20);
            this.labelCombinePro.TabIndex = 13;
            // 
            // FileSpliterUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1238, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFileCombinFile);
            this.Controls.Add(this.groupBoxSpliteFile);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileSpliterUi";
            this.Text = "文件分割器";
            this.groupBoxSpliteFile.ResumeLayout(false);
            this.groupBoxSpliteFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpliteCount)).EndInit();
            this.groupBoxFileCombinFile.ResumeLayout(false);
            this.groupBoxFileCombinFile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSelectBeSplitFile;
        private System.Windows.Forms.TextBox TXT_BeSplited;
        private System.Windows.Forms.GroupBox groupBoxSpliteFile;
        private System.Windows.Forms.Button buttonSpliteStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarSpliteProgress;
        private System.Windows.Forms.Button buttonSelectFileOfSplite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSpliteUnit;
        private System.Windows.Forms.Button buttonSelectFileOfStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxＤepositary;
        private System.Windows.Forms.TextBox textBoxSpliteSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpliteCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxFileCombinFile;
        private System.Windows.Forms.TextBox textBoxCombinFile;
        private System.Windows.Forms.Button buttonSelectedCombinFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSelectStoragePathOfCombine;
        private System.Windows.Forms.TextBox textBoxCombinedFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCombineStart;
        private System.Windows.Forms.ProgressBar progressBarCombineProcesser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonSpliteOfNumber;
        private System.Windows.Forms.RadioButton radioButtonSpliteOfSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTaskInfo;
        private System.Windows.Forms.Label labelSplitePro;
        private System.Windows.Forms.Label labelCombinePro;
    }
}

