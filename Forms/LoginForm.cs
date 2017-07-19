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
        private CRUD crud;
        
        public LoginForm()
        {
            InitializeComponent();
            crud = new CRUD();
        }
         
        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (crud.LogIn(LoginTextBox.Text, PasswordTextBox.Text))
            {
                new ControlPanelForm(crud).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login or Password is wrong");
            }
        }
         
        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            new OpenBillForm(crud).Show();
            this.Hide();
        }
    }
}
