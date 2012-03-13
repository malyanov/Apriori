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
            updateSum();
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {            
            endDateField.Value = DateTime.Now;
            startDateField.Value = DateTime.Now.AddDays(-30);
            updateSum();
        }
        private void updateSum()
        {
            float sum=0;
            foreach (DataGridViewRow row in salesGridView.Rows)            
                sum += ((float)row.Cells[5].Value * (int)row.Cells[6].Value);
            sumField.Text = sum.ToString();
        }
    }
}
