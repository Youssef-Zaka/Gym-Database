using GymSystem;
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
    public partial class Hire_Fire : Form
    {
        Controller controllerObj;
        public Hire_Fire()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Selecttrainer();
            trainercombo.DataSource = dt;
            trainercombo.DisplayMember = "trainerSSN";
            DataTable dt2 = controllerObj.Selectreceptionist();
            receptioncombo.DataSource = dt2;
            receptioncombo.DisplayMember = "rSSN";
         
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void HireTrainer_Click(object sender, EventArgs e)
        {
            if (trainerssn.Text == "" || fname.Text == "" || lname.Text == "" || phone.Text == "" || salary.Text == "" || address.Text == "" || tsexcombo.Text=="")
            {
                MessageBox.Show("Incorrect input", "Please Enter the data correctly!");
                return;
            }

            int result = controllerObj.InsertTrainer(long.Parse(trainerssn.Text), fname.Text, lname.Text,tsexcombo.Text, trainerdate.Text, long.Parse(phone.Text), link.Text,Int32.Parse(salary.Text),address.Text,description.Text);
            if (result == 0)
            {
                MessageBox.Show("Invalid Insertion");
            }
            else
            {
                MessageBox.Show("Valid Insertion");
            }
        }

        private void trainerssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rsex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void shift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any numbers or special characters are allowed in this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Do not write the key pressed in the text box 
                MessageBox.Show("No any letters or special characters are allowed in the this field", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HireReceptionist_Click(object sender, EventArgs e)
        {
            if (rssn.Text == "" || rfname.Text == "" || rlname.Text == "" || rsexcombo.Text == "" || rphone.Text == "" || rsalary.Text == "" || raddress.Text == "" || shift.Text== "")
            {
                MessageBox.Show("Incorrect input", "Please Enter the data correctly!");
                return;
            }
            int result = controllerObj.Insertreceptionist(long.Parse(rssn.Text), rfname.Text, rlname.Text, receptiondate.Text, rsexcombo.Text, long.Parse(rphone.Text), link.Text, Int32.Parse(rsalary.Text), raddress.Text, shift.Text);
            if (result == 0)
            {
                MessageBox.Show("Invalid Insertion");
            }
            else
            {
                MessageBox.Show("Valid Insertion");
            }
        }

        private void trainercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firetrainer_Click(object sender, EventArgs e)
        {
            int result = controllerObj.deletatrainer(long.Parse(trainercombo.Text.ToString()));
            if (result == 0)
            {
                MessageBox.Show("Invalid Delete");
            }
            else
            {
                MessageBox.Show("Valid Delete");
            }
        }

        private void firereceptionist_Click(object sender, EventArgs e)
        {
            int result = controllerObj.deletereceptionist(long.Parse(receptioncombo.Text.ToString()));
            if (result == 0)
            {
                MessageBox.Show("Invalid Delete");
            }
            else
            {
                MessageBox.Show("Valid Delete");
            }
        }

        private void trainercombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
