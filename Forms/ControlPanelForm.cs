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
            RefillForm form = new RefillForm(crud);
            form.Show();
            this.Hide();
            
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
