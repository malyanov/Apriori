using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apriori
{
    public partial class AuthForm : Form
    {
        private NavigationForm navForm = new NavigationForm();
        public AuthForm()
        {
            InitializeComponent();
            navForm.FormClosed += new FormClosedEventHandler(navForm_FormClosed);
            passwordField.KeyDown += new KeyEventHandler(passwordField_KeyDown);
            loginField.Text = "admin";
            passwordField.Text = "12345";            
        }

        void passwordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enterBtn_Click(null, null);
        }

        void navForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginField.Text.Trim() == "")
            {
                MessageBox.Show("Введите логин!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordField.Text.Trim() == "")
            {
                MessageBox.Show("Введите пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (adminUsersTableAdapter.checkAuth(loginField.Text, passwordField.Text).Value == 1)
            {
                navForm.Show();
                Hide();
            }
            else MessageBox.Show("Неправильный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.admin_users' table. You can move, or remove it, as needed.
            this.adminUsersTableAdapter.Fill(this.cafeDataSet.admin_users);
        }
    }
}
