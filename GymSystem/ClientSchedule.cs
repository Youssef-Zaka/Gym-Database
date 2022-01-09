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
            this.Close();
            new ClientFacilitiesSchedule().Show();
        }

        private void WorkoutsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new ClientWorkouts().Show();
        }
    }
}
