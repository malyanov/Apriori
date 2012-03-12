using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class KitchenOrderForm : Form
    {
        private DataTable resultTable;
        public KitchenOrderForm()
        {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.cafeDataSet.departments);
            // TODO: This line of code loads data into the 'cafeDataSet.dishes' table. You can move, or remove it, as needed.
            this.dishesTableAdapter.Fill(this.cafeDataSet.dishes);            
            this.dishesResourcesTableAdapter.Fill(this.cafeDataSet.dishes_resources);            
            this.stockIncomesTableAdapter.Fill(this.cafeDataSet.stock_incomes);

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {            
            DataTable resourcesTable = dishesResourcesTableAdapter.GetDataByDishID((int)dishField.SelectedValue);
            int multiplaier = (int)amountField.Value, resourceId;
            float amount;
            resultTable = null;
            //check
            for(int i=0;i<resourcesTable.Rows.Count;i++)
            {
                amount=(float)resourcesTable.Rows[i]["amount"]*multiplaier;
                resourceId = (int)resourcesTable.Rows[i]["resource_id"];
                if (stockIncomesTableAdapter.getResourceAmount(resourceId) < amount)
                {
                    MessageBox.Show("На складе недостаточно ингридиента " 
                        + resourcesTable.Rows[i]["name"]+"! Требуется "+amount+" единиц.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //calculate            
            float totalPrice = 0;
            for (int i = 0; i < resourcesTable.Rows.Count; i++)
            {
                amount = (float)resourcesTable.Rows[i]["amount"] * multiplaier;
                resourceId = (int)resourcesTable.Rows[i]["resource_id"];
                DataTable stockItems = stockIncomesTableAdapter.GetStcokItemsByResID(resourceId);
                if (resultTable == null)
                {
                    resultTable = stockItems.Clone();
                    resultTable.Columns.Remove("resource_id");
                    resultTable.Columns.Remove("income_amount");                    
                }
                float sum = 0;
                int j = 0;
                while (true)
                {
                    DataRow row=stockItems.Rows[j];
                    float a = (float)row["current_amount"];
                    if (amount <= sum + a)
                    {
                        row["current_amount"] = amount - sum;
                        totalPrice += ((float)row["current_amount"] * (float)row["item_price"]);
                        resultTable.ImportRow(row);
                        break;
                    }
                    else
                    {
                        sum += a;
                        totalPrice += ((float)row["current_amount"] * (float)row["item_price"]);
                        resultTable.ImportRow(row);
                    }
                    j++;
                }
                
            }
            double marg = int.Parse(marginField.Text) / 100.0;
            sumCostField.Text = Math.Round(totalPrice, 2).ToString();
            sumCostMargField.Text = Math.Round(totalPrice * marg, 2).ToString();
            costField.Text = Math.Round(totalPrice / multiplaier, 2).ToString();
            margCostField.Text = Math.Round(totalPrice / multiplaier * marg, 2).ToString();
            
            resultTable.Columns["current_amount"].ColumnName = "Количество";
            resultTable.Columns["add_time"].ColumnName = "Дата партии на складе";
            resultTable.Columns["name"].ColumnName = "Ингридиент";
            resultTable.Columns["item_price"].ColumnName = "Цена единицы, руб.";
            resultTable.Columns["id"].ColumnName = "№";
            kitchenGrid.DataSource = resultTable;
            confirmBtn.Enabled = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DataRow row;
            cafeDataSet.stock_transactionsRow transRow;            
            int id, lastId;
            float amount;

            cafeDataSet.kitchen_incomesRow kitchenRow = cafeDataSet.kitchen_incomes.Newkitchen_incomesRow();
            kitchenRow.current_amount = (int)amountField.Value;            
            kitchenRow.dish_id = (int)dishField.SelectedValue;
            kitchenRow.income_amount = kitchenRow.income_amount = (int)amountField.Value;
            kitchenRow.item_price = (float)float.Parse(margCostField.Text);
            kitchenRow.add_time = DateTime.Now;
            cafeDataSet.kitchen_incomes.Addkitchen_incomesRow(kitchenRow);
            kitchenIncomesTableAdapter.Update(cafeDataSet.kitchen_incomes);
            lastId = kitchenIncomesTableAdapter.getMaxID().Value;

            for (int i = 0; i < resultTable.Rows.Count; i++)
            {
                row = resultTable.Rows[i];
                id=(int)row["№"];
                amount = (float)row["Количество"];

                stockIncomesTableAdapter.writeOffResources(amount, id);

                transRow = cafeDataSet.stock_transactions.Newstock_transactionsRow();
                transRow.amount = amount;
                transRow.kitchen_id = lastId;
                transRow.stock_id = id;
                transRow.trans_time = DateTime.Now;
                cafeDataSet.stock_transactions.Addstock_transactionsRow(transRow);
                stockTransactionsTableAdapter.Update(cafeDataSet.stock_transactions);
            }
            reset();
            confirmBtn.Enabled = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
            confirmBtn.Enabled = false;
        }
        private void reset()
        {
            amountField.Value = 1;
            kitchenGrid.DataSource = null;
            costField.Text = margCostField.Text = sumCostField.Text = sumCostMargField.Text = "";
        }
    }
}
