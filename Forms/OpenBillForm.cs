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
    public partial class OpenBillForm : Form
    {
        private CRUD crud;
        public OpenBillForm(CRUD crud)
        {
            InitializeComponent();
            this.crud = crud;
        }

        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            if (crud.OpenBill(LoginTextBox.Text, PasswordTextBox.Text))
            {
                new ControlPanelForm(crud).Show();
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

    }
}
