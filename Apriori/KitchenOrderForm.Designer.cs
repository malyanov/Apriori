namespace Apriori
{
    partial class KitchenOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dishField = new System.Windows.Forms.ComboBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kitchenGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.margCostField = new System.Windows.Forms.TextBox();
            this.marginField = new System.Windows.Forms.TextBox();
            this.costField = new System.Windows.Forms.TextBox();
            this.sumCostMargField = new System.Windows.Forms.TextBox();
            this.sumCostField = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.dishesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishesTableAdapter();
            this.departmentsTableAdapter = new Apriori.cafeDataSetTableAdapters.departmentsTableAdapter();
            this.dishesResourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishes_resourcesTableAdapter();
            this.stockIncomesTableAdapter = new Apriori.cafeDataSetTableAdapters.stock_incomesTableAdapter();
            this.resetBtn = new System.Windows.Forms.Button();
            this.kitchenIncomesTableAdapter = new Apriori.cafeDataSetTableAdapters.kitchen_incomesTableAdapter();
            this.stockTransactionsTableAdapter = new Apriori.cafeDataSetTableAdapters.stock_transactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Блюдо";
            // 
            // dishField
            // 
            this.dishField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dishField.DataSource = this.dishesBindingSource;
            this.dishField.DisplayMember = "name";
            this.dishField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishField.FormattingEnabled = true;
            this.dishField.Location = new System.Drawing.Point(188, 20);
            this.dishField.Name = "dishField";
            this.dishField.Size = new System.Drawing.Size(162, 21);
            this.dishField.TabIndex = 1;
            this.dishField.ValueMember = "id";
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "dishes";
            this.dishesBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amountField
            // 
            this.amountField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amountField.Location = new System.Drawing.Point(188, 74);
            this.amountField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(162, 20);
            this.amountField.TabIndex = 2;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.calculateBtn);
            this.groupBox1.Controls.Add(this.departmentField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dishField);
            this.groupBox1.Controls.Add(this.amountField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculateBtn.Location = new System.Drawing.Point(394, 47);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(90, 24);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Рассчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // departmentField
            // 
            this.departmentField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departmentField.DataSource = this.departmentsBindingSource;
            this.departmentField.DisplayMember = "name";
            this.departmentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Location = new System.Drawing.Point(188, 47);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(162, 21);
            this.departmentField.TabIndex = 4;
            this.departmentField.ValueMember = "id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.cafeDataSet;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отдел";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество";
            // 
            // kitchenGrid
            // 
            this.kitchenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kitchenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchenGrid.Location = new System.Drawing.Point(6, 19);
            this.kitchenGrid.Name = "kitchenGrid";
            this.kitchenGrid.Size = new System.Drawing.Size(580, 247);
            this.kitchenGrid.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.margCostField);
            this.groupBox2.Controls.Add(this.marginField);
            this.groupBox2.Controls.Add(this.costField);
            this.groupBox2.Controls.Add(this.sumCostMargField);
            this.groupBox2.Controls.Add(this.sumCostField);
            this.groupBox2.Controls.Add(this.kitchenGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 416);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Составляющие";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость с наценкой, руб.";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Единицы";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Суммарная";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Текущая наценка отдела, %";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Себестоимость, руб.";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Единицы";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Суммарная";
            // 
            // margCostField
            // 
            this.margCostField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.margCostField.Location = new System.Drawing.Point(346, 376);
            this.margCostField.Name = "margCostField";
            this.margCostField.ReadOnly = true;
            this.margCostField.Size = new System.Drawing.Size(75, 20);
            this.margCostField.TabIndex = 5;
            this.margCostField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marginField
            // 
            this.marginField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.marginField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "margin", true));
            this.marginField.Location = new System.Drawing.Point(320, 272);
            this.marginField.Name = "marginField";
            this.marginField.ReadOnly = true;
            this.marginField.Size = new System.Drawing.Size(75, 20);
            this.marginField.TabIndex = 5;
            this.marginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costField
            // 
            this.costField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.costField.Location = new System.Drawing.Point(346, 329);
            this.costField.Name = "costField";
            this.costField.ReadOnly = true;
            this.costField.Size = new System.Drawing.Size(75, 20);
            this.costField.TabIndex = 5;
            this.costField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sumCostMargField
            // 
            this.sumCostMargField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumCostMargField.Location = new System.Drawing.Point(258, 376);
            this.sumCostMargField.Name = "sumCostMargField";
            this.sumCostMargField.ReadOnly = true;
            this.sumCostMargField.Size = new System.Drawing.Size(75, 20);
            this.sumCostMargField.TabIndex = 5;
            this.sumCostMargField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sumCostField
            // 
            this.sumCostField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumCostField.Location = new System.Drawing.Point(257, 329);
            this.sumCostField.Name = "sumCostField";
            this.sumCostField.ReadOnly = true;
            this.sumCostField.Size = new System.Drawing.Size(75, 20);
            this.sumCostField.TabIndex = 5;
            this.sumCostField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(529, 607);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmBtn.Location = new System.Drawing.Point(139, 556);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(162, 43);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Подтвердить";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dishesResourcesTableAdapter
            // 
            this.dishesResourcesTableAdapter.ClearBeforeFill = true;
            // 
            // stockIncomesTableAdapter
            // 
            this.stockIncomesTableAdapter.ClearBeforeFill = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(307, 556);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(162, 43);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Сбросить";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // kitchenIncomesTableAdapter
            // 
            this.kitchenIncomesTableAdapter.ClearBeforeFill = true;
            // 
            // stockTransactionsTableAdapter
            // 
            this.stockTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // KitchenTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 642);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KitchenTransForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы кухни";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dishField;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private cafeDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.ComboBox departmentField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView kitchenGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sumCostMargField;
        private System.Windows.Forms.TextBox sumCostField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marginField;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cafeDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private cafeDataSetTableAdapters.dishes_resourcesTableAdapter dishesResourcesTableAdapter;
        private cafeDataSetTableAdapters.stock_incomesTableAdapter stockIncomesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox margCostField;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button resetBtn;
        private cafeDataSetTableAdapters.kitchen_incomesTableAdapter kitchenIncomesTableAdapter;
        private cafeDataSetTableAdapters.stock_transactionsTableAdapter stockTransactionsTableAdapter;
    }
}