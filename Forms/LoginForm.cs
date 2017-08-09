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
using System.Security.Authentication;

namespace Banking.Forms
{
    public partial class LoginForm : Form
    {
        private readonly BankingOperations bankingOperations;
        
        public LoginForm()
        {
            InitializeComponent();
            bankingOperations = new BankingOperations();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bankingOperations.LogIn(LoginTextBox.Text, PasswordTextBox.Text);
                new ControlPanelForm(bankingOperations).Show();
                this.Hide();
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            new OpenBillForm(bankingOperations).Show();
            this.Hide();
        }

    }
}
