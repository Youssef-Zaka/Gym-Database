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
    public partial class HallOfFameBouns : Form
    {
        Controller controllerObj;
        public HallOfFameBouns()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void ShowClientsbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowClientID();
            ViewClients_Subsdatagridview.DataSource = dt;
            ViewClients_Subsdatagridview.Refresh();
        }

        private void ShowSubbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowSubs();
            ViewClients_Subsdatagridview.DataSource = dt;
            ViewClients_Subsdatagridview.Refresh();
        }

        private void SubsIDtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubsIDtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void ClientIDtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddBounsbutton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertSubs(SubsIDtext.Text,ClientIDtext.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new subscription failed");
            }
            else
            {
                MessageBox.Show("A new subscription is inserted successfully!");
            }
        }
    }
}
