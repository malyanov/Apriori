using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            maxDiffField.Value = decimal.Parse(variablesTableAdapter.getVarByName("MAX_PRICE_DIF"));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            variablesTableAdapter.updateVarByName(maxDiffField.Value.ToString(), "MAX_PRICE_DIF");
            Close();
        }
    }
}
