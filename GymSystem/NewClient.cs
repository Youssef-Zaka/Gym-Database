using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class NewClient : Form
    {
        Controller controllerObj;
        public NewClient()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {

            if (fNametxt.Text.Trim() == string.Empty || lNametxt.Text.Trim() == string.Empty || phoneNumbertxt.Text.Trim() == string.Empty || clientAdresstxt.Text.Trim() == string.Empty || paymentMethodcombo.Text.Trim() == string.Empty || InvitationNumbertxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            int result = controllerObj.InsertClient(fNametxt.Text, lNametxt.Text, bDatepicker.Value,Int32.Parse(phoneNumbertxt.Text), clientAdresstxt.Text, paymentMethodcombo.Text, Int16.Parse(InvitationNumbertxt.Text));
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new client failed");
            }
            else
            {
                MessageBox.Show("A new client is inserted successfully!");
            }
        }

        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        private void fNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void lNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void clientAdresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvitationNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
    
}
