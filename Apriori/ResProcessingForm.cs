using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class ResProcessingForm : Form
    {
        public ResProcessingForm()
        {
            InitializeComponent();
            resAndProcGrid.DataError += new DataGridViewDataErrorEventHandler(resAndProcGrid_DataError);
            resourceField.SelectedValueChanged += new EventHandler(resourceField_SelectedValueChanged);
        }

        void resourceField_SelectedValueChanged(object sender, EventArgs e)
        {
            if(resourceField.SelectedValue!=null)
                restechprocessesBindingSource.Filter = "resource_id="+resourceField.SelectedValue;
        }

        void resAndProcGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено неверное значение", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResAndProcForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.tech_processes' table. You can move, or remove it, as needed.
            this.tech_processesTableAdapter.Fill(this.cafeDataSet.tech_processes);
            // TODO: This line of code loads data into the 'cafeDataSet.res_tech_processes' table. You can move, or remove it, as needed.
            this.res_tech_processesTableAdapter.Fill(this.cafeDataSet.res_tech_processes);
            // TODO: This line of code loads data into the 'cafeDataSet.resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.cafeDataSet.resources);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (resAndProcGrid.CurrentRow != null)
                resAndProcGrid.Rows.RemoveAt(resAndProcGrid.SelectedRows[0].Index);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cafeDataSet.res_tech_processesRow r = cafeDataSet.res_tech_processes.Newres_tech_processesRow();
                r.factor = (float)factorField.Value;
                r.tech_process_id = (int)processField.SelectedValue;
                r.resource_id = (int)resourceField.SelectedValue;
                cafeDataSet.res_tech_processes.Addres_tech_processesRow(r);
                factorField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            res_tech_processesTableAdapter.Update(cafeDataSet.res_tech_processes);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
