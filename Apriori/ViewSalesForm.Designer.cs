namespace Apriori
{
    partial class ViewSalesForm
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
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saletimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.salesViewTableAdapter = new Apriori.cafeDataSetTableAdapters.SalesViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new Apriori.cafeDataSetTableAdapters.departmentsTableAdapter();
            this.sumField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salesGridView
            // 
            this.salesGridView.AllowUserToAddRows = false;
            this.salesGridView.AllowUserToDeleteRows = false;
            this.salesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.salesGridView.AutoGenerateColumns = false;
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.saletimeDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.marginDataGridViewTextBoxColumn,
            this.dishnameDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.salesGridView.DataSource = this.salesViewBindingSource;
            this.salesGridView.Location = new System.Drawing.Point(12, 38);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.ReadOnly = true;
            this.salesGridView.Size = new System.Drawing.Size(867, 455);
            this.salesGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saletimeDataGridViewTextBoxColumn
            // 
            this.saletimeDataGridViewTextBoxColumn.DataPropertyName = "sale_time";
            this.saletimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.saletimeDataGridViewTextBoxColumn.Name = "saletimeDataGridViewTextBoxColumn";
            this.saletimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marginDataGridViewTextBoxColumn
            // 
            this.marginDataGridViewTextBoxColumn.DataPropertyName = "margin";
            this.marginDataGridViewTextBoxColumn.HeaderText = "Наценка, %";
            this.marginDataGridViewTextBoxColumn.Name = "marginDataGridViewTextBoxColumn";
            this.marginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishnameDataGridViewTextBoxColumn
            // 
            this.dishnameDataGridViewTextBoxColumn.DataPropertyName = "dish_name";
            this.dishnameDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.dishnameDataGridViewTextBoxColumn.Name = "dishnameDataGridViewTextBoxColumn";
            this.dishnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesViewBindingSource
            // 
            this.salesViewBindingSource.DataMember = "SalesView";
            this.salesViewBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesViewTableAdapter
            // 
            this.salesViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата с";
            // 
            // startDateField
            // 
            this.startDateField.Location = new System.Drawing.Point(57, 12);
            this.startDateField.Name = "startDateField";
            this.startDateField.Size = new System.Drawing.Size(145, 20);
            this.startDateField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "по";
            // 
            // endDateField
            // 
            this.endDateField.Location = new System.Drawing.Point(233, 12);
            this.endDateField.Name = "endDateField";
            this.endDateField.Size = new System.Drawing.Size(145, 20);
            this.endDateField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отдел";
            // 
            // departmentField
            // 
            this.departmentField.DataSource = this.departmentsBindingSource;
            this.departmentField.DisplayMember = "name";
            this.departmentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Location = new System.Drawing.Point(458, 10);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(150, 21);
            this.departmentField.TabIndex = 4;
            this.departmentField.ValueMember = "name";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.cafeDataSet;
            // 
            // dishField
            // 
            this.dishField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dishField.Location = new System.Drawing.Point(731, 11);
            this.dishField.Name = "dishField";
            this.dishField.Size = new System.Drawing.Size(148, 20);
            this.dishField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Блюдо";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(804, 499);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(432, 502);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(136, 26);
            this.sumField.TabIndex = 7;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сумма продаж, руб.";
            // 
            // ViewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dishField);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateField);
            this.Controls.Add(this.startDateField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesGridView);
            this.Name = "ViewSalesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История продаж";
            this.Load += new System.EventHandler(this.ViewSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGridView;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource salesViewBindingSource;
        private cafeDataSetTableAdapters.SalesViewTableAdapter salesViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saletimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmentField;
        private System.Windows.Forms.TextBox dishField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cafeDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Label label5;
    }
}