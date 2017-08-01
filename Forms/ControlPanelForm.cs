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
using Banking.DAL;

namespace Banking.Forms
{
    public partial class ControlPanelForm : Form
    {
        private BankingOperations bankingOperations;

        public ControlPanelForm(BankingOperations bankingOperations)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
        }

        private void ChooseAccountСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    bankingOperations.FillCurrentAccountComboBox(ChooseNumberСomboBox);
                    break;
                case 1:
                    bankingOperations.FillDepositAccountComboBox(ChooseNumberСomboBox);
                    break;
                case 2:
                    bankingOperations.FillCreditAccountComboBox(ChooseNumberСomboBox);
                    break;
            }
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddAccountForm(bankingOperations).Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
