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
	public partial class TrainerProfile : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;
		public TrainerProfile()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void TrainerProfile_Load(object sender, EventArgs e)
		{
			string trainerSSN = "30008976564599"/*auth.getTrainerSSN()*/;
			DataTable dt = controllerObj.SelectTrainer(trainerSSN);

			labelTrainerSSN.Text = dt.Rows[0].Field<string>("trainerSSN");
			labelTrainerName.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
			labelTrainerPhone.Text = dt.Rows[0].Field<string>("phoneNum");
			labelTrainerGender.Text = dt.Rows[0].Field<string>("sex") == "M" ? "Male" : "Female";
			labelBDate.Text = dt.Rows[0].Field<DateTime>("bDate").ToShortDateString();
			labelTrainerSalary.Text = dt.Rows[0].Field<int>("salary").ToString() + " LE";
			labelTrainerAddress.Text = dt.Rows[0].Field<string>("trainerAddress");
			labelTrainerDesc.Text = dt.Rows[0].Field<string>("describtion");

		}
	}
}
