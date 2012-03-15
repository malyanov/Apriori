namespace Apriori
{
    partial class ResProcessingForm
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
            this.resAndProcGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resourcesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.techprocessidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.techprocessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restechprocessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.factorField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processField = new System.Windows.Forms.ComboBox();
            this.techprocessesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resourceField = new System.Windows.Forms.ComboBox();
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.resourcesTableAdapter();
            this.res_tech_processesTableAdapter = new Apriori.cafeDataSetTableAdapters.res_tech_processesTableAdapter();
            this.tech_processesTableAdapter = new Apriori.cafeDataSetTableAdapters.tech_processesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.resAndProcGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restechprocessesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // resAndProcGrid
            // 
            this.resAndProcGrid.AllowUserToAddRows = false;
            this.resAndProcGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resAndProcGrid.AutoGenerateColumns = false;
            this.resAndProcGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resAndProcGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resAndProcGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.resourceidDataGridViewTextBoxColumn,
            this.techprocessidDataGridViewTextBoxColumn,
            this.factorDataGridViewTextBoxColumn});
            this.resAndProcGrid.DataSource = this.restechprocessesBindingSource;
            this.resAndProcGrid.Location = new System.Drawing.Point(12, 12);
            this.resAndProcGrid.Name = "resAndProcGrid";
            this.resAndProcGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resAndProcGrid.Size = new System.Drawing.Size(752, 365);
            this.resAndProcGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceidDataGridViewTextBoxColumn
            // 
            this.resourceidDataGridViewTextBoxColumn.DataPropertyName = "resource_id";
            this.resourceidDataGridViewTextBoxColumn.DataSource = this.resourcesBindingSource2;
            this.resourceidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.resourceidDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.resourceidDataGridViewTextBoxColumn.HeaderText = "Ингридиент";
            this.resourceidDataGridViewTextBoxColumn.Name = "resourceidDataGridViewTextBoxColumn";
            this.resourceidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resourceidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resourceidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // resourcesBindingSource2
            // 
            this.resourcesBindingSource2.DataMember = "resources";
            this.resourcesBindingSource2.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techprocessidDataGridViewTextBoxColumn
            // 
            this.techprocessidDataGridViewTextBoxColumn.DataPropertyName = "tech_process_id";
            this.techprocessidDataGridViewTextBoxColumn.DataSource = this.techprocessesBindingSource;
            this.techprocessidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.techprocessidDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.techprocessidDataGridViewTextBoxColumn.HeaderText = "Технол. процесс";
            this.techprocessidDataGridViewTextBoxColumn.Name = "techprocessidDataGridViewTextBoxColumn";
            this.techprocessidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.techprocessidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.techprocessidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // techprocessesBindingSource
            // 
            this.techprocessesBindingSource.DataMember = "tech_processes";
            this.techprocessesBindingSource.DataSource = this.cafeDataSet;
            // 
            // factorDataGridViewTextBoxColumn
            // 
            this.factorDataGridViewTextBoxColumn.DataPropertyName = "factor";
            this.factorDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.factorDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.factorDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.factorDataGridViewTextBoxColumn.Name = "factorDataGridViewTextBoxColumn";
            // 
            // restechprocessesBindingSource
            // 
            this.restechprocessesBindingSource.DataMember = "res_tech_processes";
            this.restechprocessesBindingSource.DataSource = this.cafeDataSet;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(689, 383);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.factorField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.processField);
            this.groupBox1.Controls.Add(this.resourceField);
            this.groupBox1.Location = new System.Drawing.Point(12, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(515, 48);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // factorField
            // 
            this.factorField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.factorField.DecimalPlaces = 2;
            this.factorField.Location = new System.Drawing.Point(271, 75);
            this.factorField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.factorField.Name = "factorField";
            this.factorField.Size = new System.Drawing.Size(208, 20);
            this.factorField.TabIndex = 2;
            this.factorField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Коэффициент";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Технол. процесс";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ингридиент";
            // 
            // processField
            // 
            this.processField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.processField.DataSource = this.techprocessesBindingSource1;
            this.processField.DisplayMember = "name";
            this.processField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processField.FormattingEnabled = true;
            this.processField.Location = new System.Drawing.Point(271, 48);
            this.processField.Name = "processField";
            this.processField.Size = new System.Drawing.Size(208, 21);
            this.processField.TabIndex = 0;
            this.processField.ValueMember = "id";
            // 
            // techprocessesBindingSource1
            // 
            this.techprocessesBindingSource1.DataMember = "tech_processes";
            this.techprocessesBindingSource1.DataSource = this.cafeDataSet;
            // 
            // resourceField
            // 
            this.resourceField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resourceField.DataSource = this.resourcesBindingSource1;
            this.resourceField.DisplayMember = "name";
            this.resourceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceField.FormattingEnabled = true;
            this.resourceField.Location = new System.Drawing.Point(271, 21);
            this.resourceField.Name = "resourceField";
            this.resourceField.Size = new System.Drawing.Size(208, 21);
            this.resourceField.TabIndex = 0;
            this.resourceField.ValueMember = "id";
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "resources";
            this.resourcesBindingSource1.DataSource = this.cafeDataSet;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(689, 535);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(608, 535);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // res_tech_processesTableAdapter
            // 
            this.res_tech_processesTableAdapter.ClearBeforeFill = true;
            // 
            // tech_processesTableAdapter
            // 
            this.tech_processesTableAdapter.ClearBeforeFill = true;
            // 
            // ResProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 570);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.resAndProcGrid);
            this.Name = "ResProcessingForm";
            this.Text = "Обработка ингридиентов";
            this.Load += new System.EventHandler(this.ResAndProcForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resAndProcGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restechprocessesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resAndProcGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resourceField;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown factorField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox processField;
        private System.Windows.Forms.Button addBtn;
        private cafeDataSet cafeDataSet;
        private cafeDataSetTableAdapters.resourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
        private System.Windows.Forms.BindingSource restechprocessesBindingSource;
        private cafeDataSetTableAdapters.res_tech_processesTableAdapter res_tech_processesTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource2;
        private System.Windows.Forms.BindingSource techprocessesBindingSource;
        private cafeDataSetTableAdapters.tech_processesTableAdapter tech_processesTableAdapter;
        private System.Windows.Forms.BindingSource techprocessesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn resourceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn techprocessidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorDataGridViewTextBoxColumn;
    }
}