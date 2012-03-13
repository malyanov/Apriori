using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class ViewSalesForm : Form
    {
        public ViewSalesForm()
        {
            InitializeComponent();
            startDateField.ValueChanged += new EventHandler(updateFilter);
            endDateField.ValueChanged+=new EventHandler(updateFilter);
            dishField.TextChanged+=new EventHandler(updateFilter);            
        }

        void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("sale_time >= #{0:yyyy-MM-dd} 00:00# AND sale_time <= #{1:yyyy-MM-dd} 23:59#",
                startDateField.Value, endDateField.Value);
            if (dishField.Text.Trim() != "")
                filter += (" AND dish_name like '%" + dishField.Text + "%'");
            salesViewBindingSource.Filter = filter;
            updateSum();
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.SalesView' table. You can move, or remove it, as needed.
            this.salesViewTableAdapter.Fill(this.cafeDataSet.SalesView);
            endDateField.Value = DateTime.Now;
            startDateField.Value = DateTime.Now.AddDays(-30);
            updateSum();
        }
        private void updateSum()
        {
            float sum=0, realSum=0, diff=0;
            foreach (DataGridViewRow row in salesGridView.Rows)
            {
                sum += ((int)row.Cells[3].Value * (float)row.Cells[4].Value);
                realSum += ((int)row.Cells[3].Value * (float)row.Cells[5].Value);
                diff += (float)row.Cells[6].Value;
            }
            sumField.Text = String.Format("{0:0.00}", sum);
            realSumField.Text = String.Format("{0:0.00}", realSum);
            diffField.Text = String.Format("{0:0.00}", diff);
        }
    }
}
