namespace Apriori
{
    partial class KitchenWriteoffsForm
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
            this.sumField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.writeoffsGrid = new System.Windows.Forms.DataGridView();
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.kitchenWriteoffsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenWriteoffsViewTableAdapter = new Apriori.cafeDataSetTableAdapters.KitchenWriteoffsViewTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeofftimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.writeoffsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenWriteoffsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(393, 513);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(106, 26);
            this.sumField.TabIndex = 16;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сумма, руб.";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(751, 516);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(678, 7);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(148, 20);
            this.nameField.TabIndex = 13;
            // 
            // endDateField
            // 
            this.endDateField.Location = new System.Drawing.Point(290, 6);
            this.endDateField.Name = "endDateField";
            this.endDateField.Size = new System.Drawing.Size(148, 20);
            this.endDateField.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "по";
            // 
            // startDateField
            // 
            this.startDateField.Location = new System.Drawing.Point(111, 6);
            this.startDateField.Name = "startDateField";
            this.startDateField.Size = new System.Drawing.Size(148, 20);
            this.startDateField.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата списания с";
            // 
            // writeoffsGrid
            // 
            this.writeoffsGrid.AllowUserToAddRows = false;
            this.writeoffsGrid.AllowUserToDeleteRows = false;
            this.writeoffsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.writeoffsGrid.AutoGenerateColumns = false;
            this.writeoffsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.writeoffsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.writeoffsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.writeofftimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.wholepriceDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.kitchenidDataGridViewTextBoxColumn,
            this.addtimeDataGridViewTextBoxColumn});
            this.writeoffsGrid.DataSource = this.kitchenWriteoffsViewBindingSource;
            this.writeoffsGrid.Location = new System.Drawing.Point(12, 33);
            this.writeoffsGrid.Name = "writeoffsGrid";
            this.writeoffsGrid.ReadOnly = true;
            this.writeoffsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.writeoffsGrid.Size = new System.Drawing.Size(814, 474);
            this.writeoffsGrid.TabIndex = 7;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitchenWriteoffsViewBindingSource
            // 
            this.kitchenWriteoffsViewBindingSource.DataMember = "KitchenWriteoffsView";
            this.kitchenWriteoffsViewBindingSource.DataSource = this.cafeDataSet;
            // 
            // kitchenWriteoffsViewTableAdapter
            // 
            this.kitchenWriteoffsViewTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writeofftimeDataGridViewTextBoxColumn
            // 
            this.writeofftimeDataGridViewTextBoxColumn.DataPropertyName = "writeoff_time";
            this.writeofftimeDataGridViewTextBoxColumn.HeaderText = "Дата списания";
            this.writeofftimeDataGridViewTextBoxColumn.Name = "writeofftimeDataGridViewTextBoxColumn";
            this.writeofftimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Цена единицы, руб.";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wholepriceDataGridViewTextBoxColumn
            // 
            this.wholepriceDataGridViewTextBoxColumn.DataPropertyName = "whole_price";
            this.wholepriceDataGridViewTextBoxColumn.HeaderText = "Общая цена, руб.";
            this.wholepriceDataGridViewTextBoxColumn.Name = "wholepriceDataGridViewTextBoxColumn";
            this.wholepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitchenidDataGridViewTextBoxColumn
            // 
            this.kitchenidDataGridViewTextBoxColumn.DataPropertyName = "kitchen_id";
            this.kitchenidDataGridViewTextBoxColumn.HeaderText = "№ партии";
            this.kitchenidDataGridViewTextBoxColumn.Name = "kitchenidDataGridViewTextBoxColumn";
            this.kitchenidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addtimeDataGridViewTextBoxColumn
            // 
            this.addtimeDataGridViewTextBoxColumn.DataPropertyName = "add_time";
            this.addtimeDataGridViewTextBoxColumn.HeaderText = "Дата партии";
            this.addtimeDataGridViewTextBoxColumn.Name = "addtimeDataGridViewTextBoxColumn";
            this.addtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KitchenWriteoffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 551);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.endDateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeoffsGrid);
            this.Name = "KitchenWriteoffsForm";
            this.Text = "KitchenWriteoffsForm";
            this.Load += new System.EventHandler(this.KitchenWriteoffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.writeoffsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenWriteoffsViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView writeoffsGrid;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource kitchenWriteoffsViewBindingSource;
        private cafeDataSetTableAdapters.KitchenWriteoffsViewTableAdapter kitchenWriteoffsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeofftimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtimeDataGridViewTextBoxColumn;
    }
}