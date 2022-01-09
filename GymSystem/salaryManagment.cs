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
    public partial class salaryManagment : Form
    {
        Controller controllerObj;
        public salaryManagment()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.showtrainerSSN();
            trainercombo2.DataSource = dt;
            trainercombo2.DisplayMember = "trainerSSN";
            DataTable dt2 = controllerObj.showreceptionSSN();
            receptioncombo2.DataSource = dt2;
            receptioncombo2.DisplayMember = "rSSN";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (containBonus.Checked)
            {
                bonus.Visible = true;
            }
            else
            {
                bonus.Visible = false;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void showtrainers_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.showstrainersinfo();
            salaryshow.DataSource = dt2;
            salaryshow.Refresh();
        }

        private void showreceptionist_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.showsreceptioninfo();
            salaryshow.DataSource = dt3;
            salaryshow.Refresh();
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
