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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void OpenBillButton_Click(object sender, EventArgs e)
        {
            BusinessLogic.CRUD crud = new BusinessLogic.CRUD();
            crud.Registration(LoginTextBox.Text, PasswordTextBox.Text);


        }
    }
}
