using Banking.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.Forms
{
    partial class SendMoneyForm : Form
    {

        BankingOperations bankingOperations;
        private AccountType type;
        private int selectedIndex;

        public SendMoneyForm(BankingOperations bankingOperations, AccountType type, int selectedIndex)
        {
            InitializeComponent();
            this.bankingOperations = bankingOperations;
            this.type = type;
            this.selectedIndex = selectedIndex;
        }
    }
}
