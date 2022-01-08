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
    public partial class AddMeasurement : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public AddMeasurement()
        {
            InitializeComponent();
        }

        private void AddMeasurement_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Weight.Text = WeightTrackBar.Value.ToString();
            Height.Text = HeightTrackbar.Value.ToString();
        }

        private void WeightTrackBar_Scroll(object sender, EventArgs e)
        {
            Weight.Text = WeightTrackBar.Value.ToString();
        }

        private void HeightTrackbar_Scroll(object sender, EventArgs e)
        {
            Height.Text = HeightTrackbar.Value.ToString();
        }

        private void AddMeasurementButton_Click(object sender, EventArgs e)
        {
            if (BodyTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Body Type");
                return;
            }
            int result = controllerObj.InsertMeasurement(auth.getClient_ID(), DateTime.Now, int.Parse(Weight.Text),
                int.Parse(Height.Text),BodyTypeComboBox.SelectedItem.ToString());
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Measurement failed");
            }
            else
            {
                MessageBox.Show("The Measurement was added successfully!");
                
            }
        }
    }
}
