namespace Apriori
{
    partial class TechCardsForm
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.weightField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dishField = new System.Windows.Forms.ComboBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Apriori.cafeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculationsGrid = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dishesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishesTableAdapter();
            this.dishesResourcesTableAdapter = new Apriori.cafeDataSetTableAdapters.dishes_resourcesTableAdapter();
            this.dishCookingsTableAdapter = new Apriori.cafeDataSetTableAdapters.dish_cookingsTableAdapter();
            this.sumField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.calcBtn);
            this.groupBox1.Controls.Add(this.weightField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dishField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Блюдо";
            // 
            // calcBtn
            // 
            this.calcBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calcBtn.Location = new System.Drawing.Point(377, 34);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Рассчитать";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // weightField
            // 
            this.weightField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightField.Location = new System.Drawing.Point(214, 52);
            this.weightField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.weightField.Name = "weightField";
            this.weightField.Size = new System.Drawing.Size(141, 20);
            this.weightField.TabIndex = 3;
            this.weightField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масса нетто, г";
            // 
            // dishField
            // 
            this.dishField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dishField.DataSource = this.dishesBindingSource;
            this.dishField.DisplayMember = "name";
            this.dishField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishField.FormattingEnabled = true;
            this.dishField.Location = new System.Drawing.Point(214, 19);
            this.dishField.Name = "dishField";
            this.dishField.Size = new System.Drawing.Size(141, 21);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.calculationsGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчёт";
            // 
            // calculationsGrid
            // 
            this.calculationsGrid.AllowUserToAddRows = false;
            this.calculationsGrid.AllowUserToDeleteRows = false;
            this.calculationsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculationsGrid.Location = new System.Drawing.Point(6, 19);
            this.calculationsGrid.Name = "calculationsGrid";
            this.calculationsGrid.ReadOnly = true;
            this.calculationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calculationsGrid.Size = new System.Drawing.Size(573, 315);
            this.calculationsGrid.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(522, 453);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesResourcesTableAdapter
            // 
            this.dishesResourcesTableAdapter.ClearBeforeFill = true;
            // 
            // dishCookingsTableAdapter
            // 
            this.dishCookingsTableAdapter.ClearBeforeFill = true;
            // 
            // sumField
            // 
            this.sumField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(277, 451);
            this.sumField.Name = "sumField";
            this.sumField.ReadOnly = true;
            this.sumField.Size = new System.Drawing.Size(100, 26);
            this.sumField.TabIndex = 3;
            this.sumField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Общая масса брутто, г";
            // 
            // TechCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TechCardsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расcчёт технологических карт";
            this.Load += new System.EventHandler(this.TechCardsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown weightField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dishField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView calculationsGrid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button calcBtn;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private cafeDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private cafeDataSetTableAdapters.dishes_resourcesTableAdapter dishesResourcesTableAdapter;
        private cafeDataSetTableAdapters.dish_cookingsTableAdapter dishCookingsTableAdapter;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Label label3;
    }
}