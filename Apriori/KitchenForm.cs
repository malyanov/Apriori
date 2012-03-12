using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
            startDateField.ValueChanged += new EventHandler(updateFilter);
            endDateField.ValueChanged+=new EventHandler(updateFilter);
            dishField.TextChanged+=new EventHandler(updateFilter);
            departmentField.SelectedValueChanged+=new EventHandler(updateFilter);
            haveField.SelectedValueChanged+=new EventHandler(updateFilter);
        }

        void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("add_time >= #{0:yyyy-MM-dd} 00:00# AND add_time <= #{1:yyyy-MM-dd} 23:59#",
                startDateField.Value, endDateField.Value);
            if (dishField.Text.Trim() != "")
                filter += (" AND dish_name like '%" + dishField.Text + "%'");
            filter += (" AND dep_name='" + departmentField.Text + "'");
            if(haveField.SelectedIndex==0)
                filter+=(" AND current_amount>0");
            else filter += (" AND current_amount<=0");
            kitchenViewBindingSource.Filter = filter;
            updateSum();
        }

        private void KitchenIncomesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.cafeDataSet.departments);
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenView' table. You can move, or remove it, as needed.
            this.kitchenViewTableAdapter.Fill(this.cafeDataSet.KitchenView);
            departmentField.SelectedIndex = 0;
            endDateField.Value = DateTime.Now;
            startDateField.Value = DateTime.Now.AddDays(-30);
            haveField.SelectedIndex = 0;
            updateSum();

        }
        private void updateSum()
        {
            float sum = 0;
            foreach (DataGridViewRow row in kitchenGridView.Rows)
                sum += ((float)row.Cells[4].Value * (int)row.Cells[6].Value);
            sumField.Text = sum.ToString();
        }
    }
}
