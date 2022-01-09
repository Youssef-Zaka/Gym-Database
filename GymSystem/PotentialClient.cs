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
    public partial class PotentialClient : Form
    {
        Controller controllerObj;
        public PotentialClient()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void PotentialClient_Load(object sender, EventArgs e)
        {

        }

        private void AddPotentialClientButton_Click(object sender, EventArgs e)
        {
            if (PCfNametxt.Text.Trim() == string.Empty || PClNametxt.Text.Trim() == string.Empty || PCphoneNumbertxt.Text.Trim() == string.Empty || PCclientAdresstxt.Text.Trim() == string.Empty || PCSSNtxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            int result = controllerObj.InsertPotenialClient(PCSSNtxt.Text, PCfNametxt.Text, PClNametxt.Text, PCbDatepicker.Value,Int32.Parse(PCphoneNumbertxt.Text), PCclientAdresstxt.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new potential client failed");
            }
            else
            {
                MessageBox.Show("A new potential client is inserted successfully!");
            }
        }

        private void PCfNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PClNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PCSSNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCSSNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PCphoneNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
