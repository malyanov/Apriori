namespace Apriori
{
    partial class KitchenForm
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
            this.kitchenGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.kitchenViewTableAdapter = new Apriori.cafeDataSetTableAdapters.KitchenViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dishField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sumField = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new Apriori.cafeDataSetTableAdapters.departmentsTableAdapter();
            this.haveField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kitchenGridView
            // 
            this.kitchenGridView.AllowUserToAddRows = false;
            this.kitchenGridView.AllowUserToDeleteRows = false;
            this.kitchenGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kitchenGridView.AutoGenerateColumns = false;
            this.kitchenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchenGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addtimeDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.dishnameDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.incomeamountDataGridViewTextBoxColumn,
            this.currentamountDataGridViewTextBoxColumn});
            this.kitchenGridView.DataSource = this.kitchenViewBindingSource;
            this.kitchenGridView.Location = new System.Drawing.Point(12, 33);
            this.kitchenGridView.Name = "kitchenGridView";
            this.kitchenGridView.ReadOnly = true;
            this.kitchenGridView.Size = new System.Drawing.Size(801, 411);
            this.kitchenGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // addtimeDataGridViewTextBoxColumn
            // 
            this.addtimeDataGridViewTextBoxColumn.DataPropertyName = "add_time";
            this.addtimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.addtimeDataGridViewTextBoxColumn.Name = "addtimeDataGridViewTextBoxColumn";
            this.addtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Цена единицы, руб.";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeamountDataGridViewTextBoxColumn
            // 
            this.incomeamountDataGridViewTextBoxColumn.DataPropertyName = "income_amount";
            this.incomeamountDataGridViewTextBoxColumn.HeaderText = "Поступившее колв-о";
            this.incomeamountDataGridViewTextBoxColumn.Name = "incomeamountDataGridViewTextBoxColumn";
            this.incomeamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentamountDataGridViewTextBoxColumn
            // 
            this.currentamountDataGridViewTextBoxColumn.DataPropertyName = "current_amount";
            this.currentamountDataGridViewTextBoxColumn.HeaderText = "Тукущее кол-во";
            this.currentamountDataGridViewTextBoxColumn.Name = "currentamountDataGridViewTextBoxColumn";
            this.currentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitchenViewBindingSource
            // 
            this.kitchenViewBindingSource.DataMember = "KitchenView";
            this.kitchenViewBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitchenViewTableAdapter
            // 
            this.kitchenViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата с";
            // 
            // startDateField
            // 
            this.startDateField.Location = new System.Drawing.Point(60, 4);
            this.startDateField.Name = "startDateField";
            this.startDateField.Size = new System.Drawing.Size(149, 20);
            this.startDateField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "по";
            // 
            // endDateField
            // 
            this.endDateField.Location = new System.Drawing.Point(240, 4);
            this.endDateField.Name = "endDateField";
            this.endDateField.Size = new System.Drawing.Size(149, 20);
            this.endDateField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отдел";
            // 
            // departmentField
            // 
            this.departmentField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departmentField.DataSource = this.departmentsBindingSource;
            this.departmentField.DisplayMember = "name";
            this.departmentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Location = new System.Drawing.Point(464, 6);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(151, 21);
            this.departmentField.TabIndex = 4;
            this.departmentField.ValueMember = "name";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.cafeDataSet;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Блюдо";
            // 
            // dishField
            // 
            this.dishField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dishField.Location = new System.Drawing.Point(689, 4);
            this.dishField.Name = "dishField";
            this.dishField.Size = new System.Drawing.Size(124, 20);
            this.dishField.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сумма, руб.";
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(396, 450);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(100, 26);
            this.sumField.TabIndex = 8;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(738, 453);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // haveField
            // 
            this.haveField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.haveField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.haveField.FormattingEnabled = true;
            this.haveField.Items.AddRange(new object[] {
            "В наличии",
            "Израсходованы"});
            this.haveField.Location = new System.Drawing.Point(12, 449);
            this.haveField.Name = "haveField";
            this.haveField.Size = new System.Drawing.Size(141, 21);
            this.haveField.TabIndex = 10;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 483);
            this.Controls.Add(this.haveField);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dishField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateField);
            this.Controls.Add(this.startDateField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitchenGridView);
            this.Name = "KitchenForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.KitchenIncomesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kitchenGridView;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource kitchenViewBindingSource;
        private cafeDataSetTableAdapters.KitchenViewTableAdapter kitchenViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmentField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dishField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cafeDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.ComboBox haveField;
    }
}