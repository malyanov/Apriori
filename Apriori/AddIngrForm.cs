using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class AddIngrForm : Form
    {
        private int dishId;
        public AddIngrForm(int dishId, String dishName, bool addMode)
        {
            this.dishId = dishId;            
            if (addMode)
                this.Text = "Добавление ингридиентов к блюду "+dishName;
            else this.Text = "Редактирование ингридиентов к блюду " + dishName;
            InitializeComponent();
        }

        private void AddIngrForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.cafeDataSet.resources);
            // TODO: This line of code loads data into the 'cafeDataSet.dishes_resources' table. You can move, or remove it, as needed.
            this.dishes_resourcesTableAdapter.Fill(this.cafeDataSet.dishes_resources);
            dishesresourcesBindingSource.Filter = "dish_id=" + dishId;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dishResourcesGrid.CurrentRow != null)
                dishResourcesGrid.Rows.RemoveAt(dishResourcesGrid.SelectedRows[0].Index);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (amountField.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cafeDataSet.dishes_resourcesRow r = cafeDataSet.dishes_resources.Newdishes_resourcesRow();
                r.dish_id = dishId;
                r.amount = (float)amountField.Value;
                r.resource_id = (int)resourceField.SelectedValue;
                cafeDataSet.dishes_resources.Adddishes_resourcesRow(r);
                amountField.Value = 0;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dishes_resourcesTableAdapter.Update(cafeDataSet.dishes_resources);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
