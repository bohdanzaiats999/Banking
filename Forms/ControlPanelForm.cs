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
    partial class ControlPanelForm : Form
    {
        private BankingOperations bankingOperations;
        AccountType type;

        public ControlPanelForm(BankingOperations bankingOperations)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
            bankingOperations.AccrualInterest();
            ChooseAccountСomboBox.SelectedIndex = 0;
        }

        private void ChooseAccountСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string number;
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetCurrentList()
                        //Add space in number string
                        .Select(c => { number = AddSpace(c.Number); return number; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
                    break;
                case 1:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetDepositList()
                        .Select(c => { number = AddSpace(c.Number); return number; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
                    break;
                case 2:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetCreditList()
                        .Select(c => { number = AddSpace(c.Number); return number; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
                    break;
            }
        }

        public string AddSpace(string number)
        {
            return number.Insert(4, " ").Insert(9, " ").Insert(14, " ");
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

        private void ChooseNumberСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    MoneyStatusLabel.Text = bankingOperations.GetCurrentList().ElementAt(ChooseNumberСomboBox.SelectedIndex).Money.ToString();  
                    InterestRateGroupBox.Visible = false;
                    break;
                case 1:
                    var deposit = bankingOperations.GetDepositList().ElementAt(ChooseNumberСomboBox.SelectedIndex);
                    MoneyStatusLabel.Text = deposit.Money.ToString();
                    InterestRateStatusLable.Text = deposit.InterestRate.ToString();
                    InterestRateGroupBox.Visible = true;
                    break;
                case 2:
                    var credit = bankingOperations.GetCreditList().ElementAt(ChooseNumberСomboBox.SelectedIndex);
                    MoneyStatusLabel.Text = credit.Money.ToString();
                    InterestRateStatusLable.Text = credit.InterestRate.ToString();
                    InterestRateGroupBox.Visible = true;
                    break;
            }
            MoneyStatusLabel.Text += " $";
            InterestRateStatusLable.Text += " %";

        }

        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            AccountType type;
            string number = string.Empty;
            try
            {

                if (ChooseNumberСomboBox.SelectedIndex == -1)
                {
                    throw new Exception("Choose number");
                }
                switch (ChooseAccountСomboBox.SelectedIndex)
                {
                    case 0:
                        type = AccountType.Account;
                        number = bankingOperations.GetCurrentList().ElementAt(ChooseNumberСomboBox.SelectedIndex).Number;
                        break;
                    case 1:
                        type = AccountType.Deposit;
                        number = bankingOperations.GetDepositList().ElementAt(ChooseNumberСomboBox.SelectedIndex).Number;
                        break;
                    case 2:
                        type = AccountType.Credit;
                        number = bankingOperations.GetCreditList().ElementAt(ChooseNumberСomboBox.SelectedIndex).Number;
                        break;
                    default:
                        throw new Exception("Choose account");
                }
                if (MessageBox.Show("Are you sure you want to delete the account","Deleting account",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                bankingOperations.CloseAccount(number, type);
                MessageBox.Show("Account was deleted");
                this.Close();
                new ControlPanelForm(bankingOperations).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefillAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChooseNumberСomboBox.SelectedIndex == -1)
                {
                    throw new Exception("Choose number");
                }
                CheckAccountType();
                new RefillAccountForm(bankingOperations, type, ChooseNumberСomboBox.SelectedIndex).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckAccountType()
        {
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    type = AccountType.Account;
                    break;
                case 1:
                    type = AccountType.Deposit;
                    break;
                case 2:
                    type = AccountType.Credit;
                    break;
                default:
                    throw new Exception("Choose account");
            }
        }
        private void SendMoneyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChooseNumberСomboBox.SelectedIndex == -1)
                {
                    throw new Exception("Choose number");
                }
                CheckAccountType();
                if (type == AccountType.Account)
                {
                new SendMoneyForm(bankingOperations, ChooseNumberСomboBox.SelectedIndex).Show();
                this.Close();
                }
                else
                {
                    throw new Exception("Please choose current account");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
