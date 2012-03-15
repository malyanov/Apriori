namespace Apriori
{
    partial class NavigationForm
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
            this.processesBtn = new System.Windows.Forms.Button();
            this.resourcesBtn = new System.Windows.Forms.Button();
            this.dishesBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.stockTransactionsBtn = new System.Windows.Forms.Button();
            this.kitchenBtn = new System.Windows.Forms.Button();
            this.saleBtn = new System.Windows.Forms.Button();
            this.salesHistoryBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockWriteoffsBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitchenWriteoffsBtn = new System.Windows.Forms.Button();
            this.kitchenViewBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resProcessingBtn = new System.Windows.Forms.Button();
            this.calcCardsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // processesBtn
            // 
            this.processesBtn.Location = new System.Drawing.Point(6, 19);
            this.processesBtn.Name = "processesBtn";
            this.processesBtn.Size = new System.Drawing.Size(177, 33);
            this.processesBtn.TabIndex = 0;
            this.processesBtn.Text = "Процессы";
            this.processesBtn.UseVisualStyleBackColor = true;
            this.processesBtn.Click += new System.EventHandler(this.processesBtn_Click);
            // 
            // resourcesBtn
            // 
            this.resourcesBtn.Location = new System.Drawing.Point(213, 19);
            this.resourcesBtn.Name = "resourcesBtn";
            this.resourcesBtn.Size = new System.Drawing.Size(177, 33);
            this.resourcesBtn.TabIndex = 1;
            this.resourcesBtn.Text = "Ингридиенты";
            this.resourcesBtn.UseVisualStyleBackColor = true;
            this.resourcesBtn.Click += new System.EventHandler(this.resourcesBtn_Click);
            // 
            // dishesBtn
            // 
            this.dishesBtn.Location = new System.Drawing.Point(212, 19);
            this.dishesBtn.Name = "dishesBtn";
            this.dishesBtn.Size = new System.Drawing.Size(177, 33);
            this.dishesBtn.TabIndex = 3;
            this.dishesBtn.Text = "Блюда";
            this.dishesBtn.UseVisualStyleBackColor = true;
            this.dishesBtn.Click += new System.EventHandler(this.dishesBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.Location = new System.Drawing.Point(6, 19);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(177, 33);
            this.stockBtn.TabIndex = 4;
            this.stockBtn.Text = "Склад";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // stockTransactionsBtn
            // 
            this.stockTransactionsBtn.Location = new System.Drawing.Point(6, 58);
            this.stockTransactionsBtn.Name = "stockTransactionsBtn";
            this.stockTransactionsBtn.Size = new System.Drawing.Size(177, 33);
            this.stockTransactionsBtn.TabIndex = 5;
            this.stockTransactionsBtn.Text = "Поступления на кухню";
            this.stockTransactionsBtn.UseVisualStyleBackColor = true;
            this.stockTransactionsBtn.Click += new System.EventHandler(this.stockTransactionsBtn_Click);
            // 
            // kitchenBtn
            // 
            this.kitchenBtn.Location = new System.Drawing.Point(6, 19);
            this.kitchenBtn.Name = "kitchenBtn";
            this.kitchenBtn.Size = new System.Drawing.Size(177, 33);
            this.kitchenBtn.TabIndex = 6;
            this.kitchenBtn.Text = "Заказы кухни";
            this.kitchenBtn.UseVisualStyleBackColor = true;
            this.kitchenBtn.Click += new System.EventHandler(this.kitchenBtn_Click);
            // 
            // saleBtn
            // 
            this.saleBtn.Location = new System.Drawing.Point(6, 19);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(177, 33);
            this.saleBtn.TabIndex = 7;
            this.saleBtn.Text = "Продажа";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // salesHistoryBtn
            // 
            this.salesHistoryBtn.Location = new System.Drawing.Point(213, 19);
            this.salesHistoryBtn.Name = "salesHistoryBtn";
            this.salesHistoryBtn.Size = new System.Drawing.Size(177, 33);
            this.salesHistoryBtn.TabIndex = 8;
            this.salesHistoryBtn.Text = "История продаж";
            this.salesHistoryBtn.UseVisualStyleBackColor = true;
            this.salesHistoryBtn.Click += new System.EventHandler(this.salesHistoryBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockWriteoffsBtn);
            this.groupBox1.Controls.Add(this.stockBtn);
            this.groupBox1.Controls.Add(this.stockTransactionsBtn);
            this.groupBox1.Controls.Add(this.resourcesBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление складом";
            // 
            // stockWriteoffsBtn
            // 
            this.stockWriteoffsBtn.Location = new System.Drawing.Point(213, 58);
            this.stockWriteoffsBtn.Name = "stockWriteoffsBtn";
            this.stockWriteoffsBtn.Size = new System.Drawing.Size(176, 33);
            this.stockWriteoffsBtn.TabIndex = 6;
            this.stockWriteoffsBtn.Text = "Списания";
            this.stockWriteoffsBtn.UseVisualStyleBackColor = true;
            this.stockWriteoffsBtn.Click += new System.EventHandler(this.stockWriteoffsBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kitchenWriteoffsBtn);
            this.groupBox2.Controls.Add(this.kitchenViewBtn);
            this.groupBox2.Controls.Add(this.kitchenBtn);
            this.groupBox2.Controls.Add(this.dishesBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление кухней";
            // 
            // kitchenWriteoffsBtn
            // 
            this.kitchenWriteoffsBtn.Location = new System.Drawing.Point(213, 58);
            this.kitchenWriteoffsBtn.Name = "kitchenWriteoffsBtn";
            this.kitchenWriteoffsBtn.Size = new System.Drawing.Size(176, 33);
            this.kitchenWriteoffsBtn.TabIndex = 8;
            this.kitchenWriteoffsBtn.Text = "Списания";
            this.kitchenWriteoffsBtn.UseVisualStyleBackColor = true;
            this.kitchenWriteoffsBtn.Click += new System.EventHandler(this.kitchenWriteoffsBtn_Click);
            // 
            // kitchenViewBtn
            // 
            this.kitchenViewBtn.Location = new System.Drawing.Point(6, 58);
            this.kitchenViewBtn.Name = "kitchenViewBtn";
            this.kitchenViewBtn.Size = new System.Drawing.Size(176, 33);
            this.kitchenViewBtn.TabIndex = 7;
            this.kitchenViewBtn.Text = "Кухня";
            this.kitchenViewBtn.UseVisualStyleBackColor = true;
            this.kitchenViewBtn.Click += new System.EventHandler(this.kitchenViewBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saleBtn);
            this.groupBox3.Controls.Add(this.salesHistoryBtn);
            this.groupBox3.Location = new System.Drawing.Point(11, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 68);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Продажи";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStrip,
            this.closeToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // settingsToolStrip
            // 
            this.settingsToolStrip.Name = "settingsToolStrip";
            this.settingsToolStrip.Size = new System.Drawing.Size(134, 22);
            this.settingsToolStrip.Text = "Настройки";
            this.settingsToolStrip.Click += new System.EventHandler(this.settingsToolStrip_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // оПрограммаToolStripMenuItem
            // 
            this.оПрограммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.оПрограммаToolStripMenuItem.Name = "оПрограммаToolStripMenuItem";
            this.оПрограммаToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммаToolStripMenuItem.Text = "О программе";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "Автор";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resProcessingBtn);
            this.groupBox4.Controls.Add(this.calcCardsBtn);
            this.groupBox4.Controls.Add(this.processesBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 107);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Технологические карты";
            // 
            // resProcessingBtn
            // 
            this.resProcessingBtn.Location = new System.Drawing.Point(7, 58);
            this.resProcessingBtn.Name = "resProcessingBtn";
            this.resProcessingBtn.Size = new System.Drawing.Size(176, 33);
            this.resProcessingBtn.TabIndex = 2;
            this.resProcessingBtn.Text = "Обработка ингридиентов";
            this.resProcessingBtn.UseVisualStyleBackColor = true;
            this.resProcessingBtn.Click += new System.EventHandler(this.resProcessingBtn_Click);
            // 
            // calcCardsBtn
            // 
            this.calcCardsBtn.Location = new System.Drawing.Point(212, 19);
            this.calcCardsBtn.Name = "calcCardsBtn";
            this.calcCardsBtn.Size = new System.Drawing.Size(177, 33);
            this.calcCardsBtn.TabIndex = 1;
            this.calcCardsBtn.Text = "Рассчёт карт";
            this.calcCardsBtn.UseVisualStyleBackColor = true;
            this.calcCardsBtn.Click += new System.EventHandler(this.calcCardsBtn_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 440);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "NavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apriori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processesBtn;
        private System.Windows.Forms.Button resourcesBtn;
        private System.Windows.Forms.Button dishesBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button stockTransactionsBtn;
        private System.Windows.Forms.Button kitchenBtn;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.Button salesHistoryBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button kitchenViewBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button stockWriteoffsBtn;
        private System.Windows.Forms.Button kitchenWriteoffsBtn;
        private System.Windows.Forms.Button calcCardsBtn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStrip;
        private System.Windows.Forms.Button resProcessingBtn;
    }
}