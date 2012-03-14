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
            dishResourcesGrid.DataError += new DataGridViewDataErrorEventHandler(dishResourcesGrid_DataError);
        }

        void dishResourcesGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено неверное значение", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (amountField.Value == 0||partField.Value==0)
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
                r.part = (float)partField.Value;
                cafeDataSet.dishes_resources.Adddishes_resourcesRow(r);
                dishes_resourcesTableAdapter.Update(cafeDataSet.dishes_resources);
                amountField.Value=partField.Value = 0;
                int id = dishes_resourcesTableAdapter.getMaxID().Value;
                (new ResProcessesForm(id)).ShowDialog(this);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            float percents = 0;
            foreach (DataGridViewRow row in dishResourcesGrid.Rows)
                percents += (float)row.Cells["part"].Value;
            if(percents!=100.0)
            {
                MessageBox.Show("Введены неверные процентные части блюда! Сумма процентов не равна 100.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dishes_resourcesTableAdapter.Update(cafeDataSet.dishes_resources);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void processingBtn_Click(object sender, EventArgs e)
        {
            if (dishResourcesGrid.CurrentRow != null)
                (new ResProcessesForm((int)dishResourcesGrid.CurrentRow.Cells[0].Value)).ShowDialog(this);
        }
    }
}
