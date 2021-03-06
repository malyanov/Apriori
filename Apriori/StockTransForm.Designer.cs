﻿namespace Apriori
{
    partial class StockTransForm
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
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.stockTransViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.closeBtn = new System.Windows.Forms.Button();
            this.stockTransViewTableAdapter = new Apriori.cafeDataSetTableAdapters.StockTransViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.transStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.transEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.resourseField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sumField = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resource_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dish_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTransViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToDeleteRows = false;
            this.transactionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsGrid.AutoGenerateColumns = false;
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.transtimeDataGridViewTextBoxColumn,
            this.resource_name,
            this.amountDataGridViewTextBoxColumn,
            this.stock_time,
            this.stock_item_price,
            this.dish_name,
            this.stockidDataGridViewTextBoxColumn,
            this.kitchenidDataGridViewTextBoxColumn});
            this.transactionsGrid.DataSource = this.stockTransViewBindingSource;
            this.transactionsGrid.Location = new System.Drawing.Point(12, 43);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(882, 565);
            this.transactionsGrid.TabIndex = 0;
            // 
            // stockTransViewBindingSource
            // 
            this.stockTransViewBindingSource.DataMember = "StockTransView";
            this.stockTransViewBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(819, 614);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // stockTransViewTableAdapter
            // 
            this.stockTransViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Списание с";
            // 
            // transStartDate
            // 
            this.transStartDate.Location = new System.Drawing.Point(80, 12);
            this.transStartDate.Name = "transStartDate";
            this.transStartDate.Size = new System.Drawing.Size(143, 20);
            this.transStartDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // transEndDate
            // 
            this.transEndDate.Location = new System.Drawing.Point(254, 12);
            this.transEndDate.Name = "transEndDate";
            this.transEndDate.Size = new System.Drawing.Size(143, 20);
            this.transEndDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование";
            // 
            // resourseField
            // 
            this.resourseField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resourseField.Location = new System.Drawing.Point(690, 11);
            this.resourseField.Name = "resourseField";
            this.resourseField.Size = new System.Drawing.Size(204, 20);
            this.resourseField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сумма поступлений, руб.";
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(449, 617);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(118, 26);
            this.sumField.TabIndex = 9;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transtimeDataGridViewTextBoxColumn
            // 
            this.transtimeDataGridViewTextBoxColumn.DataPropertyName = "trans_time";
            this.transtimeDataGridViewTextBoxColumn.FillWeight = 82.08122F;
            this.transtimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.transtimeDataGridViewTextBoxColumn.Name = "transtimeDataGridViewTextBoxColumn";
            this.transtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resource_name
            // 
            this.resource_name.DataPropertyName = "resource_name";
            this.resource_name.FillWeight = 82.08122F;
            this.resource_name.HeaderText = "Наименование";
            this.resource_name.Name = "resource_name";
            this.resource_name.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 82.08122F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stock_time
            // 
            this.stock_time.DataPropertyName = "stock_time";
            this.stock_time.FillWeight = 82.08122F;
            this.stock_time.HeaderText = "Дата партии(склад)";
            this.stock_time.Name = "stock_time";
            this.stock_time.ReadOnly = true;
            // 
            // stock_item_price
            // 
            this.stock_item_price.DataPropertyName = "stock_item_price";
            this.stock_item_price.FillWeight = 82.08122F;
            this.stock_item_price.HeaderText = "Цена единицы(склад)";
            this.stock_item_price.Name = "stock_item_price";
            this.stock_item_price.ReadOnly = true;
            // 
            // dish_name
            // 
            this.dish_name.DataPropertyName = "dish_name";
            this.dish_name.FillWeight = 82.08122F;
            this.dish_name.HeaderText = "Блюдо";
            this.dish_name.Name = "dish_name";
            this.dish_name.ReadOnly = true;
            // 
            // stockidDataGridViewTextBoxColumn
            // 
            this.stockidDataGridViewTextBoxColumn.DataPropertyName = "stock_id";
            this.stockidDataGridViewTextBoxColumn.HeaderText = "Складской номер";
            this.stockidDataGridViewTextBoxColumn.Name = "stockidDataGridViewTextBoxColumn";
            this.stockidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitchenidDataGridViewTextBoxColumn
            // 
            this.kitchenidDataGridViewTextBoxColumn.DataPropertyName = "kitchen_id";
            this.kitchenidDataGridViewTextBoxColumn.HeaderText = "Номер поступления на кухню";
            this.kitchenidDataGridViewTextBoxColumn.Name = "kitchenidDataGridViewTextBoxColumn";
            this.kitchenidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitchenidDataGridViewTextBoxColumn.Visible = false;
            // 
            // StockTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 649);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resourseField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.transactionsGrid);
            this.Name = "StockTransForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступления со склада на кухню";
            this.Load += new System.EventHandler(this.StockTransForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTransViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsGrid;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource stockTransViewBindingSource;
        private cafeDataSetTableAdapters.StockTransViewTableAdapter stockTransViewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker transStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker transEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resourseField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resource_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchenidDataGridViewTextBoxColumn;
    }
}