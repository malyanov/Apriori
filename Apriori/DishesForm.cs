using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class DishesForm : Form
    {
        public DishesForm()
        {
            InitializeComponent();
            dishesGrid.DataError += new DataGridViewDataErrorEventHandler(dishesGrid_DataError);
        }

        void dishesGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено неверное значение", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.dishes' table. You can move, or remove it, as needed.
            this.dishesTableAdapter.Fill(this.cafeDataSet.dishes);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dishesGrid.CurrentRow != null)
                dishesGrid.Rows.RemoveAt(dishesGrid.SelectedRows[0].Index);
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text.Trim() == "" || descriptionField.Text.Trim() == ""
                ||marginField.Value==0||fixPriceField.Value==0)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {                
                dishesTableAdapter.Update(cafeDataSet.dishes.AdddishesRow(nameField.Text, descriptionField.Text, 
                    (int)marginField.Value, (float)fixPriceField.Value));
                (new AddIngrForm(dishesTableAdapter.getMaxID().Value, nameField.Text, true)).Show(this);
                nameField.Text = descriptionField.Text = "";
                marginField.Value = fixPriceField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dishesTableAdapter.Update(cafeDataSet.dishes);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resourcesBtn_Click(object sender, EventArgs e)
        {
            if (dishesGrid.CurrentRow != null)
                (new AddIngrForm((int)dishesGrid.CurrentRow.Cells[0].Value, 
                (String)dishesGrid.CurrentRow.Cells[1].Value, false)).ShowDialog(this);
        }
    }
}
