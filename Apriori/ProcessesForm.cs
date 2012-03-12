using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class ProcessesForm : Form
    {
        public ProcessesForm()
        {
            InitializeComponent();
        }
        private void MeasuresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.tech_processes' table. You can move, or remove it, as needed.
            this.tech_processesTableAdapter.Fill(this.cafeDataSet.tech_processes);

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
                cafeDataSet.tech_processes.Addtech_processesRow(nameField.Text);
                nameField.Text = "";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {            
            tech_processesTableAdapter.Update(cafeDataSet.tech_processes);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
