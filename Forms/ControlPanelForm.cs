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
    public partial class ControlPanelForm : Form
    {
        private CRUD crud;
        public ControlPanelForm(CRUD crud)
        {
            InitializeComponent();
            this.crud = crud;
            AccountStatusLabel.Text = this.crud.AccountStatus();
        }

        private void RefillButton_Click(object sender, EventArgs e)
        {
            new RefillForm(crud).Show();
            this.Close();
            
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();  
        }

        private void GetCashButton_Click(object sender, EventArgs e)
        {
            new GetCashForm(crud).Show();
            this.Close();
        }

        private void ToSendMoneyButton_Click(object sender, EventArgs e)
        {
            new ToSendMoneyForm(crud).Show();
            this.Close();
        }

        private void CloseAnAccountButton_Click(object sender, EventArgs e)
        {
            if (crud.CloseAnAccount())
            {
                new LoginForm().Show();
                this.Close();     
            }
            
        }
    }
}
