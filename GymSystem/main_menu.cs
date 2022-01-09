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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void showmanagment_Click(object sender, EventArgs e)
        {
            salaryManagment c1 = new salaryManagment();
            c1.Show();
            this.Hide();
        }

        private void hire_fire_Click(object sender, EventArgs e)
        {
            Hire_Fire c2 = new Hire_Fire();
            c2.Show();
            this.Hide();
        }

        private void Show_Machines_Click(object sender, EventArgs e)
        {
            Machines c3 = new Machines();
            c3.Show();
            this.Hide();   
        }

        private void gymfacilites_Click(object sender, EventArgs e)
        { 
            GymFacilities c4 = new GymFacilities();
            c4.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
