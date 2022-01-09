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
    public partial class Sell_UpdateSupplements : Form
    {
        Controller controllerObj;
        public Sell_UpdateSupplements()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void SellSupplements_Load(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ShowSupplements();
            AvaliableSupplementsgridview.DataSource = dt1;
            AvaliableSupplementsgridview.Refresh();
        }

        private void BuySupplementbutton_Click(object sender, EventArgs e)
        {
            if (SupplementIDtext.Text.Trim() == string.Empty || SupplemetsQuantitytext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }


            DataTable dt = controllerObj.SelectSupplementStock(SupplementIDtext.Text);
            int stockLeft = dt.Rows[0].Field<int>("stock");

            if (stockLeft - Int16.Parse(SupplemetsQuantitytext.Text) < 0)
            {
                MessageBox.Show("This Quantity is not avaliable right now please try a smaller quantity");
                return;
            }

            int result = controllerObj.UpdateSupplement(SupplementIDtext.Text , stockLeft - Int16.Parse(SupplemetsQuantitytext.Text));
            if (result == 0)
            {
                MessageBox.Show("The Purcahse of a new Supplement failed");
            }
            else
            {
                MessageBox.Show("A new Purchase done!");
                DataTable dt1 = controllerObj.ShowSupplements();
                AvaliableSupplementsgridview.DataSource = dt1;
                AvaliableSupplementsgridview.Refresh();
            }

        }

        private void UpdateStockbutton_Click(object sender, EventArgs e)
        {

            if (SupplementIDAddtext.Text.Trim() == string.Empty || SupplementQuantityAddtext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            DataTable dt2 = controllerObj.SelectSupplementStock(SupplementIDAddtext.Text);
            int Stock = dt2.Rows[0].Field<int>("stock");

            int result = controllerObj.UpdateSupplement(SupplementIDAddtext.Text, Stock + Int16.Parse(SupplementQuantityAddtext.Text));
            if (result == 0)
            {
                MessageBox.Show("Stock update failed");
            }
            else
            {
                MessageBox.Show("Stock is updated!");
                DataTable dt1 = controllerObj.ShowSupplements();
                AvaliableSupplementsgridview.DataSource = dt1;
                AvaliableSupplementsgridview.Refresh();
            }
        }

        private void SupplementIDtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void SupplemetsQuantitytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void SupplementIDAddtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void SupplementQuantityAddtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
