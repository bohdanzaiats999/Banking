using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking.BusinessLogic;

namespace Banking.Forms
{
    public partial class LoginForm : Form
    {
        CRUD crud;
        public LoginForm()
        {
            InitializeComponent();
            crud = new CRUD();
        }
         
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (crud.LogIn(LoginTextBox.Text, PasswordTextBox.Text))
            {
                ControlPanelForm form = new ControlPanelForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Login or Password is wrong");
            }
        }
         
        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }
    }
}
