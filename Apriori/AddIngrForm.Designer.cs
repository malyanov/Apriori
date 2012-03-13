namespace Apriori
{
    partial class AddIngrForm
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
            this.dishResourcesGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesresourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishes_resourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishes_resourcesTableAdapter();
            this.resourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.resourcesTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.resourceField = new System.Windows.Forms.ComboBox();
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishResourcesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesresourcesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dishResourcesGrid
            // 
            this.dishResourcesGrid.AllowUserToAddRows = false;
            this.dishResourcesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dishResourcesGrid.AutoGenerateColumns = false;
            this.dishResourcesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishResourcesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishResourcesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.resourceidDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.part});
            this.dishResourcesGrid.DataSource = this.dishesresourcesBindingSource;
            this.dishResourcesGrid.Location = new System.Drawing.Point(12, 12);
            this.dishResourcesGrid.Name = "dishResourcesGrid";
            this.dishResourcesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishResourcesGrid.Size = new System.Drawing.Size(528, 258);
            this.dishResourcesGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceidDataGridViewTextBoxColumn
            // 
            this.resourceidDataGridViewTextBoxColumn.DataPropertyName = "resource_id";
            this.resourceidDataGridViewTextBoxColumn.DataSource = this.resourcesBindingSource;
            this.resourceidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.resourceidDataGridViewTextBoxColumn.HeaderText = "Ингридиент";
            this.resourceidDataGridViewTextBoxColumn.Name = "resourceidDataGridViewTextBoxColumn";
            this.resourceidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resourceidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resourceidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "resources";
            this.resourcesBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // part
            // 
            this.part.DataPropertyName = "part";
            this.part.HeaderText = "Часть блюда, %";
            this.part.Name = "part";
            // 
            // dishesresourcesBindingSource
            // 
            this.dishesresourcesBindingSource.DataMember = "dishes_resources";
            this.dishesresourcesBindingSource.DataSource = this.cafeDataSet;
            // 
            // dishes_resourcesTableAdapter
            // 
            this.dishes_resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(465, 276);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(465, 423);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(384, 423);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.amountField);
            this.groupBox1.Controls.Add(this.resourceField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление ингридиента";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(347, 46);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // amountField
            // 
            this.amountField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.amountField.DecimalPlaces = 2;
            this.amountField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountField.Location = new System.Drawing.Point(184, 64);
            this.amountField.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(143, 20);
            this.amountField.TabIndex = 2;
            this.amountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resourceField
            // 
            this.resourceField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resourceField.DataSource = this.resourcesBindingSource1;
            this.resourceField.DisplayMember = "name";
            this.resourceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceField.FormattingEnabled = true;
            this.resourceField.Location = new System.Drawing.Point(185, 31);
            this.resourceField.Name = "resourceField";
            this.resourceField.Size = new System.Drawing.Size(143, 21);
            this.resourceField.TabIndex = 1;
            this.resourceField.ValueMember = "id";
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "resources";
            this.resourcesBindingSource1.DataSource = this.cafeDataSet;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ингридиент";
            // 
            // processingBtn
            // 
            this.processingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.processingBtn.Location = new System.Drawing.Point(374, 276);
            this.processingBtn.Name = "processingBtn";
            this.processingBtn.Size = new System.Drawing.Size(85, 23);
            this.processingBtn.TabIndex = 5;
            this.processingBtn.Text = "Обработка";
            this.processingBtn.UseVisualStyleBackColor = true;
            this.processingBtn.Click += new System.EventHandler(this.processingBtn_Click);
            // 
            // AddIngrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 458);
            this.Controls.Add(this.processingBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dishResourcesGrid);
            this.Name = "AddIngrForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ингридиентов";
            this.Load += new System.EventHandler(this.AddIngrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishResourcesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesresourcesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dishResourcesGrid;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource dishesresourcesBindingSource;
        private cafeDataSetTableAdapters.dishes_resourcesTableAdapter dishes_resourcesTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private cafeDataSetTableAdapters.resourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.ComboBox resourceField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn resourceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn part;
        private System.Windows.Forms.Button processingBtn;
    }
}