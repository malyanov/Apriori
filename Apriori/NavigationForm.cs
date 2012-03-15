using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();            
        }

        private void processesBtn_Click(object sender, EventArgs e)
        {
            (new ProcessesForm()).ShowDialog(this);
        }

        private void resourcesBtn_Click(object sender, EventArgs e)
        {
            (new ResourcesForm()).ShowDialog(this);
        }

        private void dishesBtn_Click(object sender, EventArgs e)
        {
            (new DishesForm()).ShowDialog(this);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            (new StockForm()).ShowDialog(this);
        }

        private void stockTransactionsBtn_Click(object sender, EventArgs e)
        {
            (new StockTransForm()).ShowDialog(this);
        }

        private void kitchenBtn_Click(object sender, EventArgs e)
        {
            (new KitchenOrderForm()).ShowDialog(this);
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            (new SalesForm()).ShowDialog(this);
        }

        private void salesHistoryBtn_Click(object sender, EventArgs e)
        {
            (new ViewSalesForm()).ShowDialog(this);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog(this);
        }

        private void kitchenViewBtn_Click(object sender, EventArgs e)
        {
            (new KitchenForm()).ShowDialog(this);
        }

        private void stockWriteoffsBtn_Click(object sender, EventArgs e)
        {
            (new StockWriteoffsForm()).ShowDialog(this);
        }

        private void kitchenWriteoffsBtn_Click(object sender, EventArgs e)
        {
            (new KitchenWriteoffsForm()).ShowDialog(this);
        }

        private void calcCardsBtn_Click(object sender, EventArgs e)
        {
            (new TechCardsForm()).ShowDialog(this);
        }

        private void settingsToolStrip_Click(object sender, EventArgs e)
        {
            (new SettingsForm()).ShowDialog(this);
        }

        private void resProcessingBtn_Click(object sender, EventArgs e)
        {
            (new ResProcessingForm()).ShowDialog(this);
        }
    }
}