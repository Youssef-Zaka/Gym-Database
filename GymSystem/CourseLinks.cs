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
	public partial class CourseLinks : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;
		public CourseLinks()
		{
			controllerObj = new Controller();
			InitializeComponent();
		}

		private void CourseLinks_Load(object sender, EventArgs e)
		{
			string trainerSSN = "29762368974566"/*auth.getTrainerSSN()*/;
			DataTable links = controllerObj.SelectCourseLinks(trainerSSN);

			int i = 1;
			if (links == null) {
				MessageBox.Show("Sorry, There are no available free courses for you");
				return;
			}
			foreach (DataRow row in links.Rows)
				comboTrainerCourses.Items.Add($"Free Course {i++}");

		}

		private void btnTrainerCourses_Click(object sender, EventArgs e)
		{
			string trainerSSN = "29762368974566"/*auth.getTrainerSSN()*/;
			DataTable links = controllerObj.SelectCourseLinks(trainerSSN);

			if (links == null || links.Rows.Count == 0)
			{
				MessageBox.Show("Sorry, There are no available free courses for you");
				return;

			}

			if (comboTrainerCourses.SelectedIndex == -1)
				MessageBox.Show("Please, choose a course link");
			string link = links.Rows[comboTrainerCourses.SelectedIndex][0].ToString();
			System.Diagnostics.Process.Start(link);
		}
	}
}
