﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class KitchenWriteoffsForm : Form
    {
        public KitchenWriteoffsForm()
        {
            InitializeComponent();
            startDateField.ValueChanged += new EventHandler(updateFilter);
            endDateField.ValueChanged+=new EventHandler(updateFilter);
            nameField.TextChanged+=new EventHandler(updateFilter);
        }

        void updateFilter(object sender, EventArgs e)
        {
            String filter = String.Format("writeoff_time >= #{0:yyyy-MM-dd} 00:00# AND writeoff_time <= #{1:yyyy-MM-dd} 23:59#",
                startDateField.Value, endDateField.Value);
            if (nameField.Text.Trim() != "")
                filter += (" AND name like '%" + nameField.Text + "%'");
            kitchenWriteoffsViewBindingSource.Filter = filter;
            updateSum();
        }

        private void KitchenWriteoffsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.KitchenWriteoffsView' table. You can move, or remove it, as needed.
            this.kitchenWriteoffsViewTableAdapter.Fill(this.cafeDataSet.KitchenWriteoffsView);
            endDateField.Value = DateTime.Now;
            startDateField.Value = DateTime.Now.AddDays(-30);
            updateSum();
        }
        private void updateSum()
        {
            float sum = 0;
            foreach (DataGridViewRow row in writeoffsGrid.Rows)
                sum += ((float)row.Cells[5].Value);
            sumField.Text = String.Format("{0:0.00}", sum);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
