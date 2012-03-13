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
        private WriteOffForm form;
        public KitchenForm()
        {
            InitializeComponent();
            haveField.SelectedIndex = 0;
            startDateField.ValueChanged += new EventHandler(updateFilter);
            endDateField.ValueChanged+=new EventHandler(updateFilter);
            dishField.TextChanged+=new EventHandler(updateFilter);
            haveField.SelectedValueChanged+=new EventHandler(updateFilter);
        }

        void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("add_time >= #{0:yyyy-MM-dd} 00:00# AND add_time <= #{1:yyyy-MM-dd} 23:59#",
                startDateField.Value, endDateField.Value);
            if (dishField.Text.Trim() != "")
                filter += (" AND dish_name like '%" + dishField.Text + "%'");            
            if(haveField.SelectedIndex==0)
                filter+=(" AND current_amount>0");
            else filter += (" AND current_amount<=0");
            kitchenViewBindingSource.Filter = filter;
            updateSum();
        }

        private void KitchenIncomesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenView' table. You can move, or remove it, as needed.
            this.kitchenViewTableAdapter.Fill(this.cafeDataSet.KitchenView);            
            endDateField.Value = DateTime.Now;
            startDateField.Value = DateTime.Now.AddDays(-30);            
            updateSum();

        }
        private void updateSum()
        {
            float realSum = 0, fixSum=0, diffSum=0;
            int index = 7 - haveField.SelectedIndex;
            foreach (DataGridViewRow row in kitchenGridView.Rows)
            {
                realSum += ((float)row.Cells[3].Value * (int)row.Cells[index].Value);
                fixSum += ((float)row.Cells[4].Value * (int)row.Cells[index].Value);
                diffSum += (float)row.Cells[5].Value;
            }
            fixSumField.Text = String.Format("{0:##.##}", fixSum);
            diffField.Text = String.Format("{0:##.##}", diffSum);
            realSumField.Text = String.Format("{0:##.##}", realSum);
        }

        private void writeOffBtn_Click(object sender, EventArgs e)
        {
            form = new WriteOffForm((int)kitchenGridView.SelectedRows[0].Cells[8].Value);
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog(this);
        }

        void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!form.isCanceled())
            {
                int amount = (int)form.getAmount();
                int id = (int)kitchenGridView.SelectedRows[0].Cells[0].Value;
                int result = kitchenIncomesTableAdapter.writeOffDishes(amount, id);
                if (result > 0)
                {
                    cafeDataSet.kitchen_writeoffsRow r = cafeDataSet.kitchen_writeoffs.Newkitchen_writeoffsRow();
                    r.amount = amount;
                    r.reason = form.getReason();
                    r.kitchen_id = id;
                    r.writeoff_time = DateTime.Now;
                    cafeDataSet.kitchen_writeoffs.Addkitchen_writeoffsRow(r);
                    kitchenWriteoffsTableAdapter.Update(cafeDataSet.kitchen_writeoffs);
                    this.kitchenViewTableAdapter.Fill(this.cafeDataSet.KitchenView);
                }
            }
        }
    }
}
