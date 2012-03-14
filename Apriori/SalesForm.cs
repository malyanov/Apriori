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
            amountField.ValueChanged += new EventHandler(recalcPrice);
            priceField.TextChanged+=new EventHandler(recalcPrice);
            kitchenViewBindingSource.Filter = "current_amount>0";
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
            kitchenViewBindingSource.Filter = "current_amount>0";            
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenView' table. You can move, or remove it, as needed.
            this.kitchenViewTableAdapter.Fill(this.cafeDataSet.KitchenView);
            amountField.Value = 1;
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            if (dishField.SelectedValue == null)
                return;
            int amount = (int)amountField.Value;
            if (amount == 0)
            {
                MessageBox.Show("Введите количество!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id=(int)dishField.SelectedValue;            
            kitchenIncomesTableAdapter.writeOffDishes(amount, id);
            cafeDataSet.salesRow row = cafeDataSet.sales.NewsalesRow();
            row.amount = amount;
            row.kitchen_id=id;
            row.sale_time = DateTime.Now;
            row.sale_price = float.Parse(priceField.Text);
            cafeDataSet.sales.AddsalesRow(row);
            salesTableAdapter.Update(cafeDataSet.sales);
            SalesForm_Load(null, null);
        }
    }
}
