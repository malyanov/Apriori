using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class UnderConstructionForm : Form
    {
        public UnderConstructionForm()
        {
            InitializeComponent();            
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {            
            if(departmentsGrid.CurrentRow!=null)
                departmentsGrid.Rows.RemoveAt(departmentsGrid.SelectedRows[0].Index);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text.Trim() == "" || marginField.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {                
                //cafeDataSet.departments.AdddepartmentsRow(nameField.Text, (int)marginField.Value);
                nameField.Text="";
                marginField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //departmentsTableAdapter.Update(cafeDataSet.departments);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
