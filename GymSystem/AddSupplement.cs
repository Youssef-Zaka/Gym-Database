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
    public partial class AddSupplement : Form
    {
        Controller controllerObj;
        public AddSupplement()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddSupplement_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplementButton_Click(object sender, EventArgs e)
        {
            if (SupplementNametxt.Text.Trim() == string.Empty || SupplementStocktxt.Text.Trim() == string.Empty || SupplementCosttxt.Text.Trim() == string.Empty || SupplementTypetxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return;
            }

            int result = controllerObj.InsertSupplement(SupplementNametxt.Text, SupplementStocktxt.Text, Int16.Parse(SupplementCosttxt.Text),SupplementTypetxt.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Supplement failed");
            }
            else
            {
                MessageBox.Show("A new Supplement is inserted successfully!");
            }
        }
    }
}
