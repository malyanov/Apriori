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
            this.kitchenViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.kitchenViewTableAdapter = new Apriori.cafeDataSetTableAdapters.KitchenViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dishField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.realSumField = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.haveField = new System.Windows.Forms.ComboBox();
            this.writeOffBtn = new System.Windows.Forms.Button();
            this.kitchenIncomesTableAdapter = new Apriori.cafeDataSetTableAdapters.kitchen_incomesTableAdapter();
            this.kitchenWriteoffsTableAdapter = new Apriori.cafeDataSetTableAdapters.kitchen_writeoffsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.fixSumField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diffField = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diff_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whole_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
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
            this.kitchenGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitchenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchenGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addtimeDataGridViewTextBoxColumn,
            this.dishnameDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.fix_price,
            this.diff_price,
            this.incomeamountDataGridViewTextBoxColumn,
            this.currentamountDataGridViewTextBoxColumn,
            this.whole_price});
            this.kitchenGridView.DataSource = this.kitchenViewBindingSource;
            this.kitchenGridView.Location = new System.Drawing.Point(12, 33);
            this.kitchenGridView.Name = "kitchenGridView";
            this.kitchenGridView.ReadOnly = true;
            this.kitchenGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kitchenGridView.Size = new System.Drawing.Size(801, 423);
            this.kitchenGridView.TabIndex = 0;
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
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сумма(реал. цена), руб.";
            // 
            // realSumField
            // 
            this.realSumField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.realSumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realSumField.Location = new System.Drawing.Point(145, 462);
            this.realSumField.Name = "realSumField";
            this.realSumField.ReadOnly = true;
            this.realSumField.Size = new System.Drawing.Size(100, 26);
            this.realSumField.TabIndex = 8;
            this.realSumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Location = new System.Drawing.Point(372, 494);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // haveField
            // 
            this.haveField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.haveField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.haveField.FormattingEnabled = true;
            this.haveField.Items.AddRange(new object[] {
            "В наличии",
            "Израсходованы"});
            this.haveField.Location = new System.Drawing.Point(449, 4);
            this.haveField.Name = "haveField";
            this.haveField.Size = new System.Drawing.Size(141, 21);
            this.haveField.TabIndex = 10;
            // 
            // writeOffBtn
            // 
            this.writeOffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writeOffBtn.Location = new System.Drawing.Point(738, 459);
            this.writeOffBtn.Name = "writeOffBtn";
            this.writeOffBtn.Size = new System.Drawing.Size(75, 23);
            this.writeOffBtn.TabIndex = 11;
            this.writeOffBtn.Text = "Списать";
            this.writeOffBtn.UseVisualStyleBackColor = true;
            this.writeOffBtn.Click += new System.EventHandler(this.writeOffBtn_Click);
            // 
            // kitchenIncomesTableAdapter
            // 
            this.kitchenIncomesTableAdapter.ClearBeforeFill = true;
            // 
            // kitchenWriteoffsTableAdapter
            // 
            this.kitchenWriteoffsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма(фикс. цена), руб.";
            // 
            // fixSumField
            // 
            this.fixSumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fixSumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fixSumField.Location = new System.Drawing.Point(402, 462);
            this.fixSumField.Name = "fixSumField";
            this.fixSumField.ReadOnly = true;
            this.fixSumField.Size = new System.Drawing.Size(100, 26);
            this.fixSumField.TabIndex = 8;
            this.fixSumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Разница, руб.";
            // 
            // diffField
            // 
            this.diffField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diffField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffField.Location = new System.Drawing.Point(608, 462);
            this.diffField.Name = "diffField";
            this.diffField.ReadOnly = true;
            this.diffField.Size = new System.Drawing.Size(100, 26);
            this.diffField.TabIndex = 8;
            this.diffField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.addtimeDataGridViewTextBoxColumn.FillWeight = 79.28299F;
            this.addtimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.addtimeDataGridViewTextBoxColumn.Name = "addtimeDataGridViewTextBoxColumn";
            this.addtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishnameDataGridViewTextBoxColumn
            // 
            this.dishnameDataGridViewTextBoxColumn.DataPropertyName = "dish_name";
            this.dishnameDataGridViewTextBoxColumn.FillWeight = 79.28299F;
            this.dishnameDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.dishnameDataGridViewTextBoxColumn.Name = "dishnameDataGridViewTextBoxColumn";
            this.dishnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.FillWeight = 79.28299F;
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Реал. цена, руб.";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fix_price
            // 
            this.fix_price.DataPropertyName = "fix_price";
            this.fix_price.FillWeight = 79.28299F;
            this.fix_price.HeaderText = "Фикс. цена, руб.";
            this.fix_price.Name = "fix_price";
            this.fix_price.ReadOnly = true;
            // 
            // diff_price
            // 
            this.diff_price.DataPropertyName = "diff_price";
            this.diff_price.FillWeight = 79.28299F;
            this.diff_price.HeaderText = "Разница, руб.";
            this.diff_price.Name = "diff_price";
            this.diff_price.ReadOnly = true;
            // 
            // incomeamountDataGridViewTextBoxColumn
            // 
            this.incomeamountDataGridViewTextBoxColumn.DataPropertyName = "income_amount";
            this.incomeamountDataGridViewTextBoxColumn.FillWeight = 79.28299F;
            this.incomeamountDataGridViewTextBoxColumn.HeaderText = "Поступившее кол-во";
            this.incomeamountDataGridViewTextBoxColumn.Name = "incomeamountDataGridViewTextBoxColumn";
            this.incomeamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentamountDataGridViewTextBoxColumn
            // 
            this.currentamountDataGridViewTextBoxColumn.DataPropertyName = "current_amount";
            this.currentamountDataGridViewTextBoxColumn.FillWeight = 79.28299F;
            this.currentamountDataGridViewTextBoxColumn.HeaderText = "Тукущее кол-во";
            this.currentamountDataGridViewTextBoxColumn.Name = "currentamountDataGridViewTextBoxColumn";
            this.currentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // whole_price
            // 
            this.whole_price.DataPropertyName = "whole_price";
            this.whole_price.FillWeight = 79.28299F;
            this.whole_price.HeaderText = "Общая цена, руб.";
            this.whole_price.Name = "whole_price";
            this.whole_price.ReadOnly = true;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 529);
            this.Controls.Add(this.writeOffBtn);
            this.Controls.Add(this.haveField);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.diffField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fixSumField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.realSumField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dishField);
            this.Controls.Add(this.label4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kitchenGridView;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource kitchenViewBindingSource;
        private cafeDataSetTableAdapters.KitchenViewTableAdapter kitchenViewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dishField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox realSumField;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox haveField;
        private System.Windows.Forms.Button writeOffBtn;
        private cafeDataSetTableAdapters.kitchen_incomesTableAdapter kitchenIncomesTableAdapter;
        private cafeDataSetTableAdapters.kitchen_writeoffsTableAdapter kitchenWriteoffsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fixSumField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diffField;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn diff_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whole_price;
    }
}