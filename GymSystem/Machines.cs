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
    public partial class Machines : Form
    {
        Controller controllerObj;
        public Machines()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Selectmachineid();
            machinecombo.DataSource = dt;
            machinecombo.DisplayMember = "machineID";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectallmachines();
            machineview.DataSource = dt;
            machineview.Refresh();
        }

        private void MachineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void machinecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showmachine_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Selectmachine(Int32.Parse(machinecombo.Text));
            machineview.DataSource = dt;
            machineview.Refresh();
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
