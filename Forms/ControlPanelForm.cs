﻿using System;
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

        public ControlPanelForm(BankingOperations bankingOperations)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
            bankingOperations.AccrualInterest();
            ChooseAccountСomboBox.SelectedIndex = 0;
        }

        private void ChooseAccountСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder;
            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetCurrentList()
                        //Add space in number string
                        .Select(c => { stringBuilder = new StringBuilder(c.Number).Insert(4, " ").Insert(9, " ").Insert(14, " "); return stringBuilder; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
                    break;
                case 1:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetDepositList()
                        .Select(c => { stringBuilder = new StringBuilder(c.Number).Insert(4, " ").Insert(9, " ").Insert(14, " "); return stringBuilder; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
                    break;
                case 2:
                    ChooseNumberСomboBox.DataSource = bankingOperations.GetCreditList()
                        .Select(c => { stringBuilder = new StringBuilder(c.Number).Insert(4, " ").Insert(9, " ").Insert(14, " "); return stringBuilder; }).ToList();
                    ChooseNumberСomboBox.DisplayMember = "Number";
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

        private void ChooseNumberСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ChooseAccountСomboBox.SelectedIndex)
            {
                case 0:
                    MoneyStatusLabel.Text = bankingOperations.GetCurrentList()[ChooseNumberСomboBox.SelectedIndex].Money.ToString();
                    InterestRateGroupBox.Visible = false;
                    break;
                case 1:
                    var deposit = bankingOperations.GetDepositList()[ChooseNumberСomboBox.SelectedIndex];
                    MoneyStatusLabel.Text = deposit.Money.ToString();
                    InterestRateStatusLable.Text = deposit.InterestRate.ToString();
                    InterestRateGroupBox.Visible = true;
                    break;
                case 2:
                    var credit = bankingOperations.GetCreditList()[ChooseNumberСomboBox.SelectedIndex];
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
                        number = bankingOperations.GetCurrentList()[ChooseNumberСomboBox.SelectedIndex].Number;
                        break;
                    case 1:
                        type = AccountType.Deposit;
                        number = bankingOperations.GetDepositList()[ChooseNumberСomboBox.SelectedIndex].Number;
                        break;
                    case 2:
                        type = AccountType.Credit;
                        number = bankingOperations.GetCreditList()[ChooseNumberСomboBox.SelectedIndex].Number;
                        break;
                    default:
                        throw new Exception("Choose account");
                }
                bankingOperations.CloseAccount(number, type);
                MessageBox.Show("Account was deleted");
                this.Close();
                new ControlPanelForm(bankingOperations).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
