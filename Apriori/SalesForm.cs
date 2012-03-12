using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            departmentField.SelectedValueChanged += new EventHandler(departmentField_SelectedValueChanged);
            amountField.ValueChanged += new EventHandler(recalcPrice);
            priceField.TextChanged+=new EventHandler(recalcPrice);
            kitchenIncomesViewBindingSource.Filter = "current_amount>0";
        }

        void recalcPrice(object sender, EventArgs e)
        {
            try
            {
                sumPriceField.Text = (double.Parse(priceField.Text) * (int)amountField.Value).ToString();
            }
            catch
            {
            }
        }

        void departmentField_SelectedValueChanged(object sender, EventArgs e)
        {
            kitchenIncomesViewBindingSource.Filter = "current_amount>0";
            if (departmentField.SelectedValue!=null)
                kitchenIncomesViewBindingSource.Filter += " AND department_id="+departmentField.SelectedValue;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenIncomesView' table. You can move, or remove it, as needed.
            this.kitchenIncomesViewTableAdapter.Fill(this.cafeDataSet.KitchenIncomesView);
            // TODO: This line of code loads data into the 'cafeDataSet.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.cafeDataSet.departments);
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenIncomesView' table. You can move, or remove it, as needed.
            this.kitchenIncomesViewTableAdapter.Fill(this.cafeDataSet.KitchenIncomesView);
            amountField.Value = 1;

        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            int id=(int)dishField.SelectedValue;
            int amount = (int)amountField.Value;
            kitchenIncomesTableAdapter.writeOffDishes(amount, id);
            cafeDataSet.salesRow row = cafeDataSet.sales.NewsalesRow();
            row.amount = amount;
            row.kitchen_id=id;
            row.sale_time = DateTime.Now;
            cafeDataSet.sales.AddsalesRow(row);
            salesTableAdapter.Update(cafeDataSet.sales);
            SalesForm_Load(null, null);
        }
    }
}
