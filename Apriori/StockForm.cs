using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class StockForm : Form
    {
        private WriteOffForm form;
        public StockForm()
        {
            InitializeComponent();
            typeField.SelectedValueChanged += new EventHandler(changeEvent);
            startDateField.ValueChanged += new EventHandler(changeEvent);
            endDateField.ValueChanged += new EventHandler(changeEvent);
            typeField.SelectedIndex = 0;
            endDateField.Value=DateTime.Now;
            startDateField.Value=DateTime.Now.AddDays(-30);
        }

        void changeEvent(object sender, EventArgs e)
        {
            updateFilter();
        }

        void updateFilter()
        {
            String filter = String.Format("add_time >= #{0:yyyy-MM-dd} 00:00# and add_time <= #{1:yyyy-MM-dd} 23:59#", 
                startDateField.Value, endDateField.Value);
            if (typeField.SelectedIndex == 1)
                filter += " and current_amount<=0";
            else filter += " and current_amount>0";
            stockincomesBindingSource.Filter = filter;
            updateSum();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.stock_writeoffs' table. You can move, or remove it, as needed.
            this.stock_writeoffsTableAdapter.Fill(this.cafeDataSet.stock_writeoffs);
            // TODO: This line of code loads data into the 'cafeDataSet.stock_incomes' table. You can move, or remove it, as needed.
            this.stock_incomesTableAdapter.Fill(this.cafeDataSet.stock_incomes);
            // TODO: This line of code loads data into the 'cafeDataSet.resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.cafeDataSet.resources);
            updateSum();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (amountField.Value==0 || priceField.Value==0)
            {
                MessageBox.Show("Введите количество и цену единицы!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cafeDataSet.stock_incomesRow r = cafeDataSet.stock_incomes.Newstock_incomesRow();
                r.income_amount = (float)amountField.Value;
                r.current_amount = (float)amountField.Value;
                r.add_time = DateTime.Now;
                r.resource_id = (int)resourceField.SelectedValue;
                r.item_price = (float)priceField.Value;
                cafeDataSet.stock_incomes.Addstock_incomesRow(r);
                updateSum();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            stock_incomesTableAdapter.Update(cafeDataSet.stock_incomes);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void updateSum()
        {
            float sum = 0;
            int index = 4-typeField.SelectedIndex;
            foreach (DataGridViewRow row in stockGridView.Rows)
                sum += ((float)row.Cells[5].Value*(float)row.Cells[index].Value);
            sumField.Text = sum.ToString();
        }

        private void writeOffBtn_Click(object sender, EventArgs e)
        {
            form = new WriteOffForm((float)stockGridView.SelectedRows[0].Cells[4].Value);
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog(this);
        }

        void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!form.isCanceled())
            {
                float amount = form.getAmount();
                int id = (int)stockGridView.SelectedRows[0].Cells[0].Value;
                int result=stock_incomesTableAdapter.writeOffResources(amount, id);
                if (result > 0)
                {
                    cafeDataSet.stock_writeoffsRow r = cafeDataSet.stock_writeoffs.Newstock_writeoffsRow();
                    r.amount = amount;
                    r.reason = form.getReason();
                    r.stock_id = id;
                    r.writeoff_time = DateTime.Now;
                    cafeDataSet.stock_writeoffs.Addstock_writeoffsRow(r);
                    stock_writeoffsTableAdapter.Update(cafeDataSet.stock_writeoffs);
                    this.stock_incomesTableAdapter.Fill(this.cafeDataSet.stock_incomes);
                }
            }
        }
    }
}
