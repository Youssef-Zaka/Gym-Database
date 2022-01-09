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
    public partial class ClientWelcome : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public ClientWelcome()
        {
            InitializeComponent();
            controllerObj = new Controller();
            //  DTR = controllerObj.SelectClient(auth.getClient_ID()).CreateDataReader();
            DataTable dt = controllerObj.SelectClient(auth.getClient_ID());
            //if(DTR.HasRows)
            NameLabel.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientSchedule().Show();
        }

        private void BodyMeasurementsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientMeasurements().Show();
        }

        private void HealthtrackerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientFoodMeasurements().Show();
        }

        private void AcheivmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientAchievments().Show();
        }

        private void HallOfFameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HallOfFame().Show();
        }

        private void WorkoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWorkouts().Show();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SubscribtionDetails().Show();
        }

        private void ClientWelcome_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();

        }
    }
}
