using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class TechCardsForm : Form
    {
        public TechCardsForm()
        {
            InitializeComponent();
            calculationsGrid.ColumnCount = 3;
            calculationsGrid.ColumnHeadersVisible = true;
            calculationsGrid.Columns[0].Name = "Ингридиент";
            calculationsGrid.Columns[1].Name = "Масса брутто, г";
            calculationsGrid.Columns[2].Name = "Масса нетто, г";
        }

        private void TechCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.dishes' table. You can move, or remove it, as needed.
            this.dishesTableAdapter.Fill(this.cafeDataSet.dishes);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (dishField.SelectedValue == null)
                return;
            if (weightField.Value == 0)
            {
                MessageBox.Show("Введите вес!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calculationsGrid.Rows.Clear();            
            int dishId = (int)dishField.SelectedValue;
            float weight = (float)weightField.Value;
            DataTable resources = dishesResourcesTableAdapter.GetDataByDishID(dishId);
            double sum = 0;
            foreach (DataRow row in resources.Rows)
            {
                int id=(int)row["id"];
                int resourceId = (int)row["resource_id"];
                float part=(float)row["part"]/100f;
                object obj=dishCookingsTableAdapter.getFactorsProduct(id, resourceId);
                double factor=1;
                if (obj != null)
                    factor = (double)obj;
                double brutto = Math.Round(weight * part * factor, 0);
                sum += brutto;
                calculationsGrid.Rows.Add(row["name"], brutto, Math.Round(weight * part, 0));
            }
            sumField.Text = Math.Round(sum, 0).ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
