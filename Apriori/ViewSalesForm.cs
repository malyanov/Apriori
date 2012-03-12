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
            departmentField.SelectedValueChanged+=new EventHandler(updateFilter);
            dishField.TextChanged+=new EventHandler(updateFilter);            
        }

        void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("sale_time >= #{0:yyyy-MM-dd} 00:00# AND sale_time <= #{1:yyyy-MM-dd} 23:59#",
                startDateField.Value, endDateField.Value);
            if (dishField.Text.Trim() != "")
                filter += (" AND dish_name like '%" + dishField.Text + "%'");
            filter += (" AND dep_name='" + departmentField.Text + "'");
            salesViewBindingSource.Filter = filter;
            updateSum();
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.cafeDataSet.departments);
            // TODO: This line of code loads data into the 'cafeDataSet.SalesView' table. You can move, or remove it, as needed.
            this.salesViewTableAdapter.Fill(this.cafeDataSet.SalesView);
            departmentField.SelectedIndex = 0;
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
