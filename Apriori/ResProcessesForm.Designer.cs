namespace Apriori
{
    partial class ResProcessesForm
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
            this.resProcessesGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techprocessidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.techprocessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.dishcookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dish_cookingsTableAdapter = new Apriori.cafeDataSetTableAdapters.dish_cookingsTableAdapter();
            this.tech_processesTableAdapter = new Apriori.cafeDataSetTableAdapters.tech_processesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.processField = new System.Windows.Forms.ComboBox();
            this.techprocessesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resProcessesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishcookingsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // resProcessesGrid
            // 
            this.resProcessesGrid.AllowUserToAddRows = false;
            this.resProcessesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resProcessesGrid.AutoGenerateColumns = false;
            this.resProcessesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resProcessesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resProcessesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.techprocessidDataGridViewTextBoxColumn});
            this.resProcessesGrid.DataSource = this.dishcookingsBindingSource;
            this.resProcessesGrid.Location = new System.Drawing.Point(12, 12);
            this.resProcessesGrid.Name = "resProcessesGrid";
            this.resProcessesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resProcessesGrid.Size = new System.Drawing.Size(378, 218);
            this.resProcessesGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techprocessidDataGridViewTextBoxColumn
            // 
            this.techprocessidDataGridViewTextBoxColumn.DataPropertyName = "tech_process_id";
            this.techprocessidDataGridViewTextBoxColumn.DataSource = this.techprocessesBindingSource;
            this.techprocessidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.techprocessidDataGridViewTextBoxColumn.FillWeight = 149.2386F;
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
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishcookingsBindingSource
            // 
            this.dishcookingsBindingSource.DataMember = "dish_cookings";
            this.dishcookingsBindingSource.DataSource = this.cafeDataSet;
            // 
            // dish_cookingsTableAdapter
            // 
            this.dish_cookingsTableAdapter.ClearBeforeFill = true;
            // 
            // tech_processesTableAdapter
            // 
            this.tech_processesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.processField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление технол. процесса";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Location = new System.Drawing.Point(271, 33);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // processField
            // 
            this.processField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.processField.DataSource = this.techprocessesBindingSource1;
            this.processField.DisplayMember = "name";
            this.processField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processField.FormattingEnabled = true;
            this.processField.Location = new System.Drawing.Point(95, 34);
            this.processField.Name = "processField";
            this.processField.Size = new System.Drawing.Size(155, 21);
            this.processField.TabIndex = 1;
            this.processField.ValueMember = "id";
            // 
            // techprocessesBindingSource1
            // 
            this.techprocessesBindingSource1.DataMember = "tech_processes";
            this.techprocessesBindingSource1.DataSource = this.cafeDataSet;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процесс";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(315, 355);
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
            this.saveBtn.Location = new System.Drawing.Point(234, 355);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(315, 236);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ResProcessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 383);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resProcessesGrid);
            this.Name = "ResProcessesForm";
            this.Text = "Обработка ингридиента блюда";
            this.Load += new System.EventHandler(this.ResProcessesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resProcessesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishcookingsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techprocessesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resProcessesGrid;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource dishcookingsBindingSource;
        private cafeDataSetTableAdapters.dish_cookingsTableAdapter dish_cookingsTableAdapter;
        private System.Windows.Forms.BindingSource techprocessesBindingSource;
        private cafeDataSetTableAdapters.tech_processesTableAdapter tech_processesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox processField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource techprocessesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn techprocessidDataGridViewTextBoxColumn;
    }
}