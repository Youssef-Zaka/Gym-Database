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
    public partial class PaymentMethodManagement : Form
    {
        Controller controllerObj;
        public PaymentMethodManagement()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void UpdatePaymentMethodButton_Click(object sender, EventArgs e)
        {
            if (ClientIDtext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            int result = controllerObj.UpdatePaymentMehod(ClientIDtext.Text, paymentMethodcombo.Text);
            if (result == 0)
            {
                MessageBox.Show("paymentMethod update failed");
            }
            else
            {
                MessageBox.Show("paymentMethod is updated!");
                DataTable dt1 = controllerObj.ShowClientID();
                AllClientsDt.DataSource = dt1;
                AllClientsDt.Refresh();
            }
        }

        private void AllClientsDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaymentMethodManagement_Load(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ShowClientID();
            AllClientsDt.DataSource = dt1;
            AllClientsDt.Refresh();
        }

        private void ClientIDtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
