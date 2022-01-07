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
    public partial class GymFacilities : Form
    {
        Controller controllerObj;
        public GymFacilities()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Selectclassnames();
            classcombo.DataSource = dt;
            classcombo.DisplayMember = "className";
            DataTable dt2 = controllerObj.showservicename();
            servicecombo.DataSource = dt2;
            servicecombo.DisplayMember = "facilityName";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void showclasses_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectallclasses();
            dataclasses.DataSource = dt;
            dataclasses.Refresh();
        }

        private void addclass_Click(object sender, EventArgs e)
        {
            if (classname.Text == "" || startdate.Text == "" || scost.Text == "" || sfreq.Text == "")
            {
                MessageBox.Show("Incorrect input", "Please Enter the data correctly!");
                return;
            }
            int result = controllerObj.Insertclass(classname.Text, startdate.Text, Int32.Parse(scost.Text), Int32.Parse(sfreq.Text));
            if (result == 0)
            {
                MessageBox.Show("Invalid Insertion");
            }
            else
            {
                MessageBox.Show("Valid Insertion");
            }
        }

        private void classname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sfreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void removeclass_Click(object sender, EventArgs e)
        {
            int result = controllerObj.deleteclass(classcombo.Text);
            if (result == 0)
            {
                MessageBox.Show("Invalid Delete");
            }
            else
            {
                MessageBox.Show("Valid Delete");
            }
        }

        private void addservice_Click(object sender, EventArgs e)
        {
            if (servicename.Text == "" || maintenancecost.Text == "" || maintenancefreq.Text == "")
            {
                MessageBox.Show("Incorrect input", "Please Enter the data correctly!");
                return;
            }
            int result = controllerObj.Insertservice(servicename.Text, Int32.Parse(maintenancecost.Text), maintenancedate.Text, Int32.Parse(maintenancefreq.Text));
            if (result == 0)
            {
                MessageBox.Show("Invalid Insertion");
            }
            else
            {
                MessageBox.Show("Valid Insertion");
            }
        }

        private void showservice_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.showservices();
            dataservices.DataSource = dt2;
            dataservices.Refresh();
        }

        private void removeservice_Click(object sender, EventArgs e)
        {
            int result = controllerObj.deleteservice(servicecombo.Text);
            if (result == 0)
            {
                MessageBox.Show("Invalid Delete");
            }
            else
            {
                MessageBox.Show("Valid Delete");
            }
        }

        private void maintenancecost_TextChanged(object sender, EventArgs e)
        {

        }

        private void maintenancecost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maintenancefreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void servicename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_menu m1 = new main_menu();
            m1.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
