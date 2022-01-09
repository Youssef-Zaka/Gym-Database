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

    public partial class Surveys : Form
    {
        Controller controllerObj;
        public Surveys()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddSurveybutton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertSurvey(TrainerRatingcombo.Text,FacilityRatingcombo.Text,MachinesRatingcombo.Text,ReceptionistRatingcombo.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new survey failed");
            }
            else
            {
                MessageBox.Show("A new survey is inserted successfully!");
            }
        }
    }
}
