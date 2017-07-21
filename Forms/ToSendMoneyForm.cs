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
    public partial class ToSendMoneyForm : Form
    {
        private CRUD crud;
        public ToSendMoneyForm(CRUD crud)
        {
            InitializeComponent();
            this.crud = crud;

        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SendMoneyButton_Click(object sender, EventArgs e)
        {
            if (crud.ToSendMoney(ReceiverTextBox.Text, AmountTextBox.Text))
            {
                this.Hide();
                new ControlPanelForm(crud).Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ControlPanelForm(crud).Show();
        }
    }
}
