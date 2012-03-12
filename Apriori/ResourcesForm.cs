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
                cafeDataSet.resourcesRow r = cafeDataSet.resources.NewresourcesRow();
                r.name = nameField.Text;
                //r.measure_id = (int)measureFiled.SelectedValue;
                cafeDataSet.resources.AddresourcesRow(r);
                nameField.Text = "";
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
