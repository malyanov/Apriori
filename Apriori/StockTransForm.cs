using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class StockTransForm : Form
    {
        public StockTransForm()
        {
            InitializeComponent();
            transStartDate.ValueChanged+=new EventHandler(updateFilter);
            transEndDate.ValueChanged+=new EventHandler(updateFilter);            
            resourseField.TextChanged+=new EventHandler(updateFilter);
        }

        private void StockTransForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.StockTransView' table. You can move, or remove it, as needed.
            this.stockTransViewTableAdapter.Fill(this.cafeDataSet.StockTransView);            
            transEndDate.Value = DateTime.Now;
            transStartDate.Value = DateTime.Now.AddDays(-30);
            updateSum();
        }
        private void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("trans_time >= #{0:yyyy-MM-dd} 00:00# AND trans_time <= #{1:yyyy-MM-dd} 23:59#",
                transStartDate.Value, transEndDate.Value);
            if(resourseField.Text.Trim()!="")
                filter += (" AND resource_name like '%" + resourseField.Text + "%'");            
            stockTransViewBindingSource.Filter = filter;
            updateSum();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void updateSum()
        {
            float sum = 0;
            foreach (DataGridViewRow row in transactionsGrid.Rows)
                sum += ((float)row.Cells[3].Value * (float)row.Cells[5].Value);
            sumField.Text = sum.ToString();
        }
    }    
}
