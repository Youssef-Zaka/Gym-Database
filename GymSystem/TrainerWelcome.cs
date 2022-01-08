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
		public TrainerWelcome()
		{
			InitializeComponent();
		}

		private void btnShowClientList_Click(object sender, EventArgs e)
		{
			new TrainerClientList().Show();
		}

		private void btnTrainerProfile_Click(object sender, EventArgs e)
		{
			new TrainerProfile().Show();
		}
	}
}
