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
    public partial class OpenBillForm : Form
    {
        private BankingOperations bankingOperations;
        public OpenBillForm(BankingOperations crud)
        {
            InitializeComponent();
            this.bankingOperations = crud;
        }

        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                bankingOperations.Registration(LoginTextBox.Text, PasswordTextBox.Text);
                MessageBox.Show("Registration was successful");
                new ControlPanelForm(bankingOperations).Show();
                this.Close();
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

    }
}
