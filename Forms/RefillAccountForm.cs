using Banking.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.Forms
{
    partial class RefillAccountForm : Form
    {
        BankingOperations bankingOperations;
        private AccountType type;
        private int index;

        public RefillAccountForm(BankingOperations bankingOperations,AccountType type,int index)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
            this.type = type;
            this.index = index;
        }

        private void RefillAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(e.KeyChar.ToString(), @"^-*[0-9,\.]+$"))
            {
                e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Close();
            new ControlPanelForm(bankingOperations).Show();
        }

        private void RefillAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                bankingOperations.RefillAccount(RefillAccountTextBox.Text, type, index);
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
