namespace Apriori
{
    partial class WriteOffForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // amountField
            // 
            this.amountField.DecimalPlaces = 2;
            this.amountField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountField.Location = new System.Drawing.Point(92, 20);
            this.amountField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(150, 20);
            this.amountField.TabIndex = 1;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(153, 126);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(72, 126);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Причина";
            // 
            // reasonField
            // 
            this.reasonField.Location = new System.Drawing.Point(92, 54);
            this.reasonField.MaxLength = 200;
            this.reasonField.Multiline = true;
            this.reasonField.Name = "reasonField";
            this.reasonField.Size = new System.Drawing.Size(150, 57);
            this.reasonField.TabIndex = 5;
            // 
            // WriteOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 173);
            this.Controls.Add(this.reasonField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WriteOffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списание";
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reasonField;
    }
}