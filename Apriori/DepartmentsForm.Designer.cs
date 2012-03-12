namespace Apriori
{
    partial class DepartmentsForm
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
            this.components = new System.ComponentModel.Container();
            this.departmentsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.departmentsTableAdapter = new Apriori.cafeDataSetTableAdapters.departmentsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.marginField = new System.Windows.Forms.NumericUpDown();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginField)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentsGrid
            // 
            this.departmentsGrid.AllowUserToAddRows = false;
            this.departmentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentsGrid.AutoGenerateColumns = false;
            this.departmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.marginDataGridViewTextBoxColumn});
            this.departmentsGrid.DataSource = this.departmentsBindingSource;
            this.departmentsGrid.Location = new System.Drawing.Point(12, 12);
            this.departmentsGrid.Name = "departmentsGrid";
            this.departmentsGrid.Size = new System.Drawing.Size(423, 251);
            this.departmentsGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // marginDataGridViewTextBoxColumn
            // 
            this.marginDataGridViewTextBoxColumn.DataPropertyName = "margin";
            this.marginDataGridViewTextBoxColumn.HeaderText = "Наценка, %";
            this.marginDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.marginDataGridViewTextBoxColumn.Name = "marginDataGridViewTextBoxColumn";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.marginField);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление отдела";
            // 
            // marginField
            // 
            this.marginField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.marginField.Location = new System.Drawing.Point(156, 53);
            this.marginField.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.marginField.Name = "marginField";
            this.marginField.Size = new System.Drawing.Size(120, 20);
            this.marginField.TabIndex = 2;
            this.marginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameField.Location = new System.Drawing.Point(156, 19);
            this.nameField.MaxLength = 100;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(120, 20);
            this.nameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наценка, %";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(296, 34);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(360, 395);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(279, 395);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(360, 269);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 430);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.departmentsGrid);
            this.Name = "DepartmentsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView departmentsGrid;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cafeDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.NumericUpDown marginField;
    }
}