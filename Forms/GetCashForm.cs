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
    public partial class GetCashForm : Form
    {
        private CRUD crud;
        public GetCashForm(CRUD crud)
        {
            InitializeComponent();
            this.crud = crud;
        }

        private void GetCashTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GetCashButton_Click(object sender, EventArgs e)
        {
            if (crud.GetCash(GetCashTextBox.Text))
            {
                new ControlPanelForm(crud).Show();
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ControlPanelForm(crud).Show();
            this.Close();
        }
    }
}
