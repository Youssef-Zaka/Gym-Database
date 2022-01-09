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
    public partial class ClientSchedule : Form
    {
        public ClientSchedule()
        {
            InitializeComponent();
        }

        private void FacilitiesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientFacilitiesSchedule().Show();
        }

        private void WorkoutsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWorkouts().Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWelcome().Show();
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWelcome().Show();
        }
    }
}
