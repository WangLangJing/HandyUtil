namespace Takout
{
    partial class TakeoutCalcForm
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
            this._tbCommodityAndPrice = new System.Windows.Forms.TextBox();
            this._tbDiscountsThreshold = new System.Windows.Forms.Label();
            this._numDiscountsThreshold = new System.Windows.Forms.NumericUpDown();
            this._output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._numDiscounts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._numDiscountsThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // _tbCommodityAndPrice
            // 
            this._tbCommodityAndPrice.Location = new System.Drawing.Point(24, 39);
            this._tbCommodityAndPrice.Multiline = true;
            this._tbCommodityAndPrice.Name = "_tbCommodityAndPrice";
            this._tbCommodityAndPrice.Size = new System.Drawing.Size(233, 476);
            this._tbCommodityAndPrice.TabIndex = 0;
            // 
            // _tbDiscountsThreshold
            // 
            this._tbDiscountsThreshold.AutoSize = true;
            this._tbDiscountsThreshold.Location = new System.Drawing.Point(286, 122);
            this._tbDiscountsThreshold.Name = "_tbDiscountsThreshold";
            this._tbDiscountsThreshold.Size = new System.Drawing.Size(126, 17);
            this._tbDiscountsThreshold.TabIndex = 2;
            this._tbDiscountsThreshold.Text = "Discounts Threshold";
            // 
            // _numDiscountsThreshold
            // 
            this._numDiscountsThreshold.Location = new System.Drawing.Point(418, 119);
            this._numDiscountsThreshold.Name = "_numDiscountsThreshold";
            this._numDiscountsThreshold.Size = new System.Drawing.Size(102, 23);
            this._numDiscountsThreshold.TabIndex = 4;
            // 
            // _output
            // 
            this._output.Location = new System.Drawing.Point(284, 241);
            this._output.Multiline = true;
            this._output.Name = "_output";
            this._output.Size = new System.Drawing.Size(459, 274);
            this._output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Discounts ";
            // 
            // _numDiscounts
            // 
            this._numDiscounts.Location = new System.Drawing.Point(418, 155);
            this._numDiscounts.Name = "_numDiscounts";
            this._numDiscounts.Size = new System.Drawing.Size(102, 23);
            this._numDiscounts.TabIndex = 7;
            // 
            // TakeoutCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 546);
            this.Controls.Add(this._numDiscounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._output);
            this.Controls.Add(this._numDiscountsThreshold);
            this.Controls.Add(this._tbDiscountsThreshold);
            this.Controls.Add(this._tbCommodityAndPrice);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TakeoutCalcForm";
            this.Text = "TakeoutCalc";
            ((System.ComponentModel.ISupportInitialize)(this._numDiscountsThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbCommodityAndPrice;
        private System.Windows.Forms.Label _tbDiscountsThreshold;
        private System.Windows.Forms.NumericUpDown _numDiscountsThreshold;
        private System.Windows.Forms.TextBox _output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numDiscounts;
    }
}

