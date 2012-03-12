namespace Apriori
{
    partial class DishesForm
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
            this.dishesGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dishesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishesTableAdapter();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resourcesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dishesGrid
            // 
            this.dishesGrid.AllowUserToAddRows = false;
            this.dishesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dishesGrid.AutoGenerateColumns = false;
            this.dishesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dishesGrid.DataSource = this.dishesBindingSource;
            this.dishesGrid.Location = new System.Drawing.Point(12, 12);
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.Size = new System.Drawing.Size(531, 254);
            this.dishesGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Навание";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MaxInputLength = 400;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.continueBtn);
            this.groupBox1.Controls.Add(this.descriptionField);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление блюда";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.continueBtn.Location = new System.Drawing.Point(365, 53);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(85, 23);
            this.continueBtn.TabIndex = 3;
            this.continueBtn.Text = "Продолжить";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // descriptionField
            // 
            this.descriptionField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.descriptionField.Location = new System.Drawing.Point(169, 50);
            this.descriptionField.MaxLength = 400;
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(171, 73);
            this.descriptionField.TabIndex = 2;
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameField.Location = new System.Drawing.Point(169, 18);
            this.nameField.MaxLength = 200;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(171, 20);
            this.nameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(468, 272);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(468, 444);
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
            this.saveBtn.Location = new System.Drawing.Point(387, 444);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "ОК";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resourcesBtn
            // 
            this.resourcesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcesBtn.Location = new System.Drawing.Point(364, 272);
            this.resourcesBtn.Name = "resourcesBtn";
            this.resourcesBtn.Size = new System.Drawing.Size(98, 23);
            this.resourcesBtn.TabIndex = 5;
            this.resourcesBtn.Text = "Ингридиенты";
            this.resourcesBtn.UseVisualStyleBackColor = true;
            this.resourcesBtn.Click += new System.EventHandler(this.resourcesBtn_Click);
            // 
            // DishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 479);
            this.Controls.Add(this.resourcesBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dishesGrid);
            this.Name = "DishesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блюда";
            this.Load += new System.EventHandler(this.DishesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dishesGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private cafeDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resourcesBtn;
    }
}