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
    public partial class AddAccountForm : Form
    {
        private BankingOperations bankingOperations;
        public AddAccountForm(BankingOperations bankingOperations)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new ControlPanelForm(bankingOperations).Show();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0: bankingOperations.AddCurrentAccount();
                    this.Close();
                    new ControlPanelForm(bankingOperations).Show();
                    break;
                case 1:
                    bankingOperations.AddDepositAccount();
                    this.Close();
                    new ControlPanelForm(bankingOperations).Show();
                    break;  
                case 2:
                    bankingOperations.AddCreditAccount();
                    this.Close();
                    new ControlPanelForm(bankingOperations).Show();
                    break;
                default:
                    MessageBox.Show("Choose account");
                    break;
            }
        }
    }
}
