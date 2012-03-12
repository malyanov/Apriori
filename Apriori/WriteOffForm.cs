using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class WriteOffForm : Form
    {       
        private bool canceled=false;
        public WriteOffForm(float max)
        {
            InitializeComponent();
            amountField.Maximum=amountField.Value=(decimal)max;            
        }
        public float getAmount()
        {
            return (float)amountField.Value;
        }
        public String getReason()
        {
            return reasonField.Text;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (amountField.Value == 0 || reasonField.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            canceled = true;
            Close();
        }
        public bool isCanceled()
        {
            return canceled;
        }
    }
}
