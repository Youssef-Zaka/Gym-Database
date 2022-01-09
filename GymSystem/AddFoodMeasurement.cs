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
    public partial class AddFoodMeasurement : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public AddFoodMeasurement()
        {
            InitializeComponent();
        }
        private void AddFoodMeasurement_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Cal.Text = CalTrackBar.Value.ToString();
            Hours.Text = HoursTrackbar.Value.ToString();
            Water.Text = WaterTrackbar.Value.ToString();
        }

        private void WeightTrackBar_Scroll(object sender, EventArgs e)
        {
            Cal.Text = CalTrackBar.Value.ToString();
        }

        private void HeightTrackbar_Scroll(object sender, EventArgs e)
        {
            Hours.Text = HoursTrackbar.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Water.Text = WaterTrackbar.Value.ToString();
        }

        private void AddMeasurementButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertFoodMeasurement(auth.getClient_ID(), DateTime.Now, int.Parse(Cal.Text),
                int.Parse(Hours.Text), int.Parse(Water.Text));
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Measurement failed");
            }
            else
            {
                MessageBox.Show("The Measurement was added successfully!");

            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientFoodMeasurements().Show();
        }
    }
}
