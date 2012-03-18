namespace Apriori
{
    partial class AuthForm
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.adminUsersTableAdapter = new Apriori.cafeDataSetTableAdapters.admin_usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(101, 25);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(126, 20);
            this.loginField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(101, 60);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(126, 20);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(101, 98);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 3;
            this.enterBtn.Text = "Войти";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminUsersTableAdapter
            // 
            this.adminUsersTableAdapter.ClearBeforeFill = true;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 133);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button enterBtn;
        private cafeDataSet cafeDataSet;
        private cafeDataSetTableAdapters.admin_usersTableAdapter adminUsersTableAdapter;
    }
}