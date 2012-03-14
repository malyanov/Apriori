using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();
            measureFiled.SelectedIndex = 0;
            resourcesGrid.DataError += new DataGridViewDataErrorEventHandler(resourcesGrid_DataError);
        }

        void resourcesGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено неверное значение", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'cafeDataSet.resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.cafeDataSet.resources);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            resourcesTableAdapter.Update(cafeDataSet.resources);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text.Trim() == "")
            {
                MessageBox.Show("Введите название!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cafeDataSet.resources.AddresourcesRow(nameField.Text, (String)measureFiled.SelectedItem, (float)seasonMarginField.Value);
                nameField.Text = "";
                seasonMarginField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (resourcesGrid.CurrentRow != null)
                resourcesGrid.Rows.RemoveAt(resourcesGrid.SelectedRows[0].Index);
        }
    }
}
