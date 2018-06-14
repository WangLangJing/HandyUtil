namespace WMI_CLASS_Monitor
{
    partial class WMIClassProteriesBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dgvPropertiesInfo = new System.Windows.Forms.DataGridView();
            this._columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnIsArray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvPropertiesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvPropertiesInfo
            // 
            this._dgvPropertiesInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this._dgvPropertiesInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvPropertiesInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this._dgvPropertiesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvPropertiesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnName,
            this._columnType,
            this._columnValue,
            this._columnIsArray});
            this._dgvPropertiesInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvPropertiesInfo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this._dgvPropertiesInfo.Location = new System.Drawing.Point(0, 0);
            this._dgvPropertiesInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dgvPropertiesInfo.Name = "_dgvPropertiesInfo";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this._dgvPropertiesInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvPropertiesInfo.RowTemplate.Height = 23;
            this._dgvPropertiesInfo.Size = new System.Drawing.Size(625, 533);
            this._dgvPropertiesInfo.TabIndex = 0;
            // 
            // _columnName
            // 
            this._columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._columnName.HeaderText = "名称";
            this._columnName.Name = "_columnName";
            // 
            // _columnType
            // 
            this._columnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._columnType.HeaderText = "类型";
            this._columnType.Name = "_columnType";
            // 
            // _columnValue
            // 
            this._columnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._columnValue.HeaderText = "默认值";
            this._columnValue.Name = "_columnValue";
            // 
            // _columnIsArray
            // 
            this._columnIsArray.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._columnIsArray.HeaderText = "是否数组";
            this._columnIsArray.Name = "_columnIsArray";
            // 
            // WMIClassProteriesBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dgvPropertiesInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WMIClassProteriesBoard";
            this.Size = new System.Drawing.Size(625, 533);
            ((System.ComponentModel.ISupportInitialize)(this._dgvPropertiesInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvPropertiesInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnIsArray;
    }
}
