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
	public partial class TrainerSchedule : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;

		public TrainerSchedule()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void TrainerSchedule_Load(object sender, EventArgs e)
		{
			string trainerSSN = auth.getSSN();

			DataTable schedule = controllerObj.SelectTrainerSchedule(trainerSSN);
			if (schedule == null)
			{
				MessageBox.Show("You have nothing to do at this moment, you can take a break");
				return;
			}

			gridTrainerSchedule.DataSource = schedule;
		}
	}
}
