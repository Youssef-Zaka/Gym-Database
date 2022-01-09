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
	public partial class TrainerWelcome : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;

		public TrainerWelcome()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void btnShowClientList_Click(object sender, EventArgs e)
		{
			new TrainerClientList().Show();
		}

		private void btnTrainerProfile_Click(object sender, EventArgs e)
		{
			new TrainerProfile().Show();
		}

		private void btnTrainerSchedule_Click(object sender, EventArgs e)
		{
			new TrainerSchedule().Show();
		}

		private void btnTrainerCourses_Click(object sender, EventArgs e)
		{
			new CourseLinks().Show();
		}

		private void TrainerWelcome_Load(object sender, EventArgs e)
		{
			string trainerSSN = auth.getSSN();
			DataTable dt = controllerObj.SelectTrainer(trainerSSN);

			if (dt == null)
			{
				MessageBox.Show("There is no trainer with that SSN");
				return;
			}

			labelTrainerNameWel.Text = dt.Rows[0].Field<string>("fName");

		}

		private void exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void backbutton_Click_1(object sender, EventArgs e)
        {
			this.Hide();
			
			new Login().Show();
		}
    }
}
