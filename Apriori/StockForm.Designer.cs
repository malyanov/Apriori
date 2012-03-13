namespace Apriori
{
    partial class StockForm
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
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.priceField = new System.Windows.Forms.NumericUpDown();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.resourceField = new System.Windows.Forms.ComboBox();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.resourcesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.stockGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incomeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockincomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_incomesTableAdapter = new Apriori.cafeDataSetTableAdapters.stock_incomesTableAdapter();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sumField = new System.Windows.Forms.TextBox();
            this.writeOffBtn = new System.Windows.Forms.Button();
            this.stock_writeoffsTableAdapter = new Apriori.cafeDataSetTableAdapters.stock_writeoffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockincomesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.priceField);
            this.groupBox1.Controls.Add(this.amountField);
            this.groupBox1.Controls.Add(this.resourceField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление поступления";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(559, 57);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // priceField
            // 
            this.priceField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceField.DecimalPlaces = 2;
            this.priceField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceField.Location = new System.Drawing.Point(326, 86);
            this.priceField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(192, 20);
            this.priceField.TabIndex = 2;
            this.priceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountField
            // 
            this.amountField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.amountField.DecimalPlaces = 2;
            this.amountField.Location = new System.Drawing.Point(326, 60);
            this.amountField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(192, 20);
            this.amountField.TabIndex = 2;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resourceField
            // 
            this.resourceField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resourceField.DataSource = this.resourcesBindingSource;
            this.resourceField.DisplayMember = "name";
            this.resourceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceField.FormattingEnabled = true;
            this.resourceField.Location = new System.Drawing.Point(326, 33);
            this.resourceField.Name = "resourceField";
            this.resourceField.Size = new System.Drawing.Size(192, 21);
            this.resourceField.TabIndex = 1;
            this.resourceField.ValueMember = "id";
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "resources";
            this.resourcesBindingSource.DataSource = this.cafeDataSet;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цена единицы";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ингридиент";
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(805, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(724, 619);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // stockGridView
            // 
            this.stockGridView.AllowUserToAddRows = false;
            this.stockGridView.AllowUserToDeleteRows = false;
            this.stockGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGridView.AutoGenerateColumns = false;
            this.stockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addtimeDataGridViewTextBoxColumn,
            this.resourceidDataGridViewTextBoxColumn,
            this.incomeamountDataGridViewTextBoxColumn,
            this.currentamountDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.wholepriceDataGridViewTextBoxColumn});
            this.stockGridView.DataSource = this.stockincomesBindingSource;
            this.stockGridView.Location = new System.Drawing.Point(12, 46);
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.ReadOnly = true;
            this.stockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGridView.Size = new System.Drawing.Size(868, 377);
            this.stockGridView.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addtimeDataGridViewTextBoxColumn
            // 
            this.addtimeDataGridViewTextBoxColumn.DataPropertyName = "add_time";
            this.addtimeDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.addtimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.addtimeDataGridViewTextBoxColumn.Name = "addtimeDataGridViewTextBoxColumn";
            this.addtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceidDataGridViewTextBoxColumn
            // 
            this.resourceidDataGridViewTextBoxColumn.DataPropertyName = "resource_id";
            this.resourceidDataGridViewTextBoxColumn.DataSource = this.resourcesBindingSource1;
            this.resourceidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.resourceidDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.resourceidDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.resourceidDataGridViewTextBoxColumn.Name = "resourceidDataGridViewTextBoxColumn";
            this.resourceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.resourceidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resourceidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resourceidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "resources";
            this.resourcesBindingSource1.DataSource = this.cafeDataSet;
            // 
            // incomeamountDataGridViewTextBoxColumn
            // 
            this.incomeamountDataGridViewTextBoxColumn.DataPropertyName = "income_amount";
            this.incomeamountDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.incomeamountDataGridViewTextBoxColumn.HeaderText = "Поступившее кол-во";
            this.incomeamountDataGridViewTextBoxColumn.Name = "incomeamountDataGridViewTextBoxColumn";
            this.incomeamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentamountDataGridViewTextBoxColumn
            // 
            this.currentamountDataGridViewTextBoxColumn.DataPropertyName = "current_amount";
            this.currentamountDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.currentamountDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во";
            this.currentamountDataGridViewTextBoxColumn.Name = "currentamountDataGridViewTextBoxColumn";
            this.currentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Цена единицы, руб.";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wholepriceDataGridViewTextBoxColumn
            // 
            this.wholepriceDataGridViewTextBoxColumn.DataPropertyName = "whole_price";
            this.wholepriceDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.wholepriceDataGridViewTextBoxColumn.HeaderText = "Общая цена, руб.";
            this.wholepriceDataGridViewTextBoxColumn.Name = "wholepriceDataGridViewTextBoxColumn";
            this.wholepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockincomesBindingSource
            // 
            this.stockincomesBindingSource.DataMember = "stock_incomes";
            this.stockincomesBindingSource.DataSource = this.cafeDataSet;
            // 
            // stock_incomesTableAdapter
            // 
            this.stock_incomesTableAdapter.ClearBeforeFill = true;
            // 
            // typeField
            // 
            this.typeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeField.FormattingEnabled = true;
            this.typeField.Items.AddRange(new object[] {
            "В наличии",
            "Израсходованы"});
            this.typeField.Location = new System.Drawing.Point(12, 12);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(149, 21);
            this.typeField.TabIndex = 5;
            // 
            // startDateField
            // 
            this.startDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateField.Location = new System.Drawing.Point(539, 16);
            this.startDateField.Name = "startDateField";
            this.startDateField.Size = new System.Drawing.Size(154, 20);
            this.startDateField.TabIndex = 6;
            // 
            // endDateField
            // 
            this.endDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateField.Location = new System.Drawing.Point(724, 16);
            this.endDateField.Name = "endDateField";
            this.endDateField.Size = new System.Drawing.Size(154, 20);
            this.endDateField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата с";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "по";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сумма, руб.";
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(403, 617);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(100, 26);
            this.sumField.TabIndex = 9;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writeOffBtn
            // 
            this.writeOffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writeOffBtn.Location = new System.Drawing.Point(805, 429);
            this.writeOffBtn.Name = "writeOffBtn";
            this.writeOffBtn.Size = new System.Drawing.Size(75, 23);
            this.writeOffBtn.TabIndex = 10;
            this.writeOffBtn.Text = "Списать";
            this.writeOffBtn.UseVisualStyleBackColor = true;
            this.writeOffBtn.Click += new System.EventHandler(this.writeOffBtn_Click);
            // 
            // stock_writeoffsTableAdapter
            // 
            this.stock_writeoffsTableAdapter.ClearBeforeFill = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 654);
            this.Controls.Add(this.writeOffBtn);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endDateField);
            this.Controls.Add(this.startDateField);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.stockGridView);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockincomesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown priceField;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.ComboBox resourceField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private cafeDataSetTableAdapters.resourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView stockGridView;
        private cafeDataSetTableAdapters.stock_incomesTableAdapter stock_incomesTableAdapter;
        private System.Windows.Forms.ComboBox typeField;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource stockincomesBindingSource;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn resourceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button writeOffBtn;
        private cafeDataSetTableAdapters.stock_writeoffsTableAdapter stock_writeoffsTableAdapter;
    }
}