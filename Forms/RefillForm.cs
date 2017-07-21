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
    public partial class RefillForm : Form
    {
        private readonly CRUD crud;
        public RefillForm(CRUD crud)
        {
            InitializeComponent();
            this.crud = crud;
        }

        private void RefillTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RefillButton_Click(object sender, EventArgs e)
        {
            crud.Refill(RefillTextBox.Text);
            new ControlPanelForm(crud).Show();
            this.Close();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ControlPanelForm(crud).Show();
            this.Close();
        }

    }
}
