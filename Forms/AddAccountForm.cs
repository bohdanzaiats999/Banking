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
            string depositInterestRate = string.Empty;
            string creditInterestRate = string.Empty;

            try
            {
                switch (ChooseAccountСomboBox.SelectedIndex)
                {
                    case 0:
                        bankingOperations.AddAccount();
                        this.Close();
                        new ControlPanelForm(bankingOperations).Show();
                        break;
                    case 1:
                        if (DepositInterestRate25RadioButton.Checked)
                        {
                            depositInterestRate = DepositInterestRate25RadioButton.Text;
                        }
                        else if (DepositInterestRate15RadioButton.Checked)
                        {
                            depositInterestRate = DepositInterestRate15RadioButton.Text;

                        }

                        bankingOperations.AddDeposit(depositInterestRate, DepositMoneyTextBox.Text);
                        this.Close();
                        new ControlPanelForm(bankingOperations).Show();
                        break;
                    case 2:
                        if (CreditInterestRate25RadioButton.Checked)
                        {
                            creditInterestRate = CreditInterestRate25RadioButton.Text;
                        }
                        else if (CreditInterestRate15RadioButton.Checked)
                        {
                            creditInterestRate = CreditInterestRate15RadioButton.Text;
                        }

                        bankingOperations.AddCredit(creditInterestRate,CreditMonthlyPaymentTextBox.Text,CreditAvailabilityCollateralCheckBox.Checked,CreditMoneyTextBox.Text);
                        this.Close();
                        new ControlPanelForm(bankingOperations).Show();
                        break;
                    default:
                        throw new Exception("Choose account");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ChooseAccountСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    DepositGroupBox.Visible = false;
                    CreditGroupBox.Visible = false;
                    break;
                case 1:
                    DepositGroupBox.Visible = true;
                    CreditGroupBox.Visible = false;
                    break;
                case 2:
                    DepositGroupBox.Visible = false;
                    CreditGroupBox.Visible = true;
                    break;
            }
        }

        private void DepositMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void CreditMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CreditMonthlyPaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
