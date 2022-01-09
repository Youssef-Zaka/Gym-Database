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
    public partial class New_Client : Form
    {
        Controller controllerObj;
        public New_Client()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
/*            if (FullNametxt.Text.Trim() == string.Empty || IDtxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }*/

            int result = controllerObj.InsertClient(ClientIDtxt.Text, fNametxt.Text, lNametxt.Text, bDatepicker.Value.ToShortDateString(), phoneNumbertxt.Text,clientAdresstxt.Text ,startDatepicker.Value.ToShortDateString(),paymentMethodtxt.Text, InvitationNumbertxt.Text, lastVisitpicker.Value.ToShortDateString());
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new client failed");
            }
            else
            {
                MessageBox.Show("A new client is inserted successfully!");
            }
        }
    }
}
