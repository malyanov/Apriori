namespace Apriori
{
    partial class SalesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dishDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.kitchenIncomesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dishField = new System.Windows.Forms.ComboBox();
            this.departmentField = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.saleBtn = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new Apriori.cafeDataSetTableAdapters.departmentsTableAdapter();
            this.kitchenIncomesViewTableAdapter = new Apriori.cafeDataSetTableAdapters.KitchenIncomesViewTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.sumPriceField = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salesTableAdapter = new Apriori.cafeDataSetTableAdapters.salesTableAdapter();
            this.kitchenIncomesTableAdapter = new Apriori.cafeDataSetTableAdapters.kitchen_incomesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIncomesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dishDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amountField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dishField);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор блюда";
            // 
            // dishDate
            // 
            this.dishDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenIncomesViewBindingSource, "add_time", true));
            this.dishDate.Location = new System.Drawing.Point(106, 82);
            this.dishDate.Name = "dishDate";
            this.dishDate.ReadOnly = true;
            this.dishDate.Size = new System.Drawing.Size(195, 20);
            this.dishDate.TabIndex = 5;
            this.dishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата";
            // 
            // amountField
            // 
            this.amountField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amountField.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.kitchenIncomesViewBindingSource, "current_amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.amountField.Location = new System.Drawing.Point(210, 57);
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
            this.amountField.Size = new System.Drawing.Size(91, 20);
            this.amountField.TabIndex = 3;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kitchenIncomesViewBindingSource
            // 
            this.kitchenIncomesViewBindingSource.DataMember = "KitchenIncomesView";
            this.kitchenIncomesViewBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Блюдо";
            // 
            // dishField
            // 
            this.dishField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dishField.DataSource = this.kitchenIncomesViewBindingSource;
            this.dishField.DisplayMember = "dish_name";
            this.dishField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishField.FormattingEnabled = true;
            this.dishField.Location = new System.Drawing.Point(106, 30);
            this.dishField.Name = "dishField";
            this.dishField.Size = new System.Drawing.Size(195, 21);
            this.dishField.TabIndex = 1;
            this.dishField.ValueMember = "id";
            // 
            // departmentField
            // 
            this.departmentField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departmentField.DataSource = this.departmentsBindingSource;
            this.departmentField.DisplayMember = "name";
            this.departmentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentField.FormattingEnabled = true;
            this.departmentField.Location = new System.Drawing.Point(145, 12);
            this.departmentField.Name = "departmentField";
            this.departmentField.Size = new System.Drawing.Size(144, 21);
            this.departmentField.TabIndex = 1;
            this.departmentField.ValueMember = "id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.cafeDataSet;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отдел";
            // 
            // priceField
            // 
            this.priceField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitchenIncomesViewBindingSource, "item_price", true));
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.Location = new System.Drawing.Point(78, 24);
            this.priceField.Name = "priceField";
            this.priceField.ReadOnly = true;
            this.priceField.Size = new System.Drawing.Size(80, 20);
            this.priceField.TabIndex = 4;
            // 
            // saleBtn
            // 
            this.saleBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleBtn.Location = new System.Drawing.Point(104, 240);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(163, 35);
            this.saleBtn.TabIndex = 5;
            this.saleBtn.Text = "Продать";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // kitchenIncomesViewTableAdapter
            // 
            this.kitchenIncomesViewTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Общая";
            // 
            // sumPriceField
            // 
            this.sumPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumPriceField.Location = new System.Drawing.Point(252, 24);
            this.sumPriceField.Name = "sumPriceField";
            this.sumPriceField.ReadOnly = true;
            this.sumPriceField.Size = new System.Drawing.Size(80, 20);
            this.sumPriceField.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sumPriceField);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 62);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Единицы";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // kitchenIncomesTableAdapter
            // 
            this.kitchenIncomesTableAdapter.ClearBeforeFill = true;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIncomesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dishField;
        private System.Windows.Forms.ComboBox departmentField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Button saleBtn;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cafeDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource kitchenIncomesViewBindingSource;
        private cafeDataSetTableAdapters.KitchenIncomesViewTableAdapter kitchenIncomesViewTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sumPriceField;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private cafeDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private cafeDataSetTableAdapters.kitchen_incomesTableAdapter kitchenIncomesTableAdapter;
        private System.Windows.Forms.TextBox dishDate;
        private System.Windows.Forms.Label label6;
    }
}