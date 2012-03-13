using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class ResProcessesForm : Form
    {
        private int dishResourceID;
        public ResProcessesForm(int dishResourceID)
        {
            this.dishResourceID = dishResourceID;
            InitializeComponent();
            resProcessesGrid.DataError += new DataGridViewDataErrorEventHandler(resProcessesGrid_DataError);
        }

        void resProcessesGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено неверное значение", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResProcessesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.tech_processes' table. You can move, or remove it, as needed.
            this.tech_processesTableAdapter.Fill(this.cafeDataSet.tech_processes);
            // TODO: This line of code loads data into the 'cafeDataSet.dish_cookings' table. You can move, or remove it, as needed.
            this.dish_cookingsTableAdapter.Fill(this.cafeDataSet.dish_cookings);
            dishcookingsBindingSource.Filter = "dish_resources_id="+dishResourceID;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (resProcessesGrid.CurrentRow != null)
                resProcessesGrid.Rows.RemoveAt(resProcessesGrid.SelectedRows[0].Index);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (factorField.Value==0)
            {
                MessageBox.Show("Введите коэффициент!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cafeDataSet.dish_cookingsRow r = cafeDataSet.dish_cookings.Newdish_cookingsRow();
                r.dish_resources_id = dishResourceID;
                r.factor = (float)factorField.Value;
                r.tech_process_id = (int)processField.SelectedValue;
                cafeDataSet.dish_cookings.Adddish_cookingsRow(r);
                factorField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dish_cookingsTableAdapter.Update(cafeDataSet.dish_cookings);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
