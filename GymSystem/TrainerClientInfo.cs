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
	public partial class TrainerClientInfo : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;
		public TrainerClientInfo()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void TrainerClientInfo_Load(object sender, EventArgs e)
		{
			int clientID = TrainerClientList.PassedClientID;

			DataTable dt = controllerObj.SelectClient(clientID);

			if (dt == null)
			{
				MessageBox.Show("There is no client with that ID");
				return;
			}

			labelClientID.Text = dt.Rows[0].Field<int>("clientID").ToString();
			labelClientName.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
			labelClientPhone.Text = dt.Rows[0].Field<string>("phoneNum");
			labelClientBDate.Text = dt.Rows[0].Field<DateTime>("bDate").ToShortDateString();
			labelClientStartDate.Text = dt.Rows[0].Field<DateTime>("startDate").ToShortDateString();
			labelClientAddress.Text = dt.Rows[0].Field<string>("clientAddress");

			// For tab2
			DataTable workoutName = controllerObj.SelectClientWorkout(clientID);
			if (workoutName == null)
			{
				labelWorkout.ForeColor = Color.DarkRed;
				labelWorkout.Text = "No workout for this client";
			}
			else
			{
				labelWorkout.Text = workoutName.Rows[0].ToString();
			}

			DataTable measurements = controllerObj.SelectTrainerClientMeasurements(clientID);
			if (measurements == null)
			{
				MessageBox.Show("No inbody information about this client");
			}

			gridClientMeasurement.DataSource = measurements;


			labelRecWeight.Text = recommendedWeightTrackBar.Value.ToString();

			// Achievments
			DataTable achievments = controllerObj.SelectAchievementNames(clientID);
			if (achievments == null)
			{
				MessageBox.Show("No achievments for this client to add");
			}
			else
			{
				for (int i = 0; i < achievments.Rows.Count; ++i)
				{
					comboAchievments.Items.Insert(i, achievments.Rows[i][0].ToString());
				}
			}

			DataTable achievmentsD = controllerObj.SelectClientAchievements(clientID);
			if (achievmentsD == null)
			{
				MessageBox.Show("No achievments for this client to delete");
			}
			else
			{
				for (int i = 0; i < achievmentsD.Rows.Count; ++i)
				{
					comboDeleteAch.Items.Insert(i, achievmentsD.Rows[i][0].ToString());
				}
			}

			// workouts
			DataTable clientWork = controllerObj.SelectClientWorkout(clientID);
			if (clientWork == null)
			{
				labelWorkout.ForeColor = Color.DarkRed;
				labelWorkout.Text = "No workout for this client";
			}
			else
			{
				labelWorkout.Text = clientWork.Rows[0][0].ToString();
			}


			DataTable workouts = controllerObj.SelectWorkouts(clientID);
			if (workouts == null)
			{
				MessageBox.Show("No workouts for this client");
			}
			else
			{
				for (int i = 0; i < workouts.Rows.Count; ++i)
				{
					comboEditWorkout.Items.Insert(i, workouts.Rows[i][0].ToString());
				}
			}

		}

		

		private void recommendedWeightTrackBar_Scroll(object sender, EventArgs e)
		{
			labelRecWeight.Text = recommendedWeightTrackBar.Value.ToString();
		}

		private void btnRecommededWeight_Click(object sender, EventArgs e)
		{
			int clientID = TrainerClientList.PassedClientID;

			int res = controllerObj.UpdateRecommWeight(clientID, recommendedWeightTrackBar.Value);
			if (res == 0)
			{
				MessageBox.Show("Failed to update");
				return;
			}
			MessageBox.Show("Updated Successfully");

			DataTable measurements = controllerObj.SelectTrainerClientMeasurements(clientID);

			if (measurements == null)
			{
				MessageBox.Show("No inbody information about this client, so you cannot recommend weight for him");
				return;
			}

			gridClientMeasurement.DataSource = measurements;

		}

		private void btnAddAchievment_Click(object sender, EventArgs e)
		{
			int clientID = TrainerClientList.PassedClientID;
			if (comboAchievments.SelectedIndex == -1)
			{
				MessageBox.Show("Please, Choose an achievment");
				return;
			}

			string achName = comboAchievments.SelectedItem.ToString();
			int res = controllerObj.InsertAchievment(clientID, achName);
			if (res == 0)
			{
				MessageBox.Show("This client has already achieved the selected.");
			}
			else
			{
				MessageBox.Show("Added Successfully");
				comboAchievments.Items.Remove(achName);

				comboDeleteAch.Items.Clear();
				DataTable achievmentsD = controllerObj.SelectClientAchievements(clientID);
				if (achievmentsD == null)
				{
					MessageBox.Show("No achievments to delete for this client");
				}
				else
				{
					for (int i = 0; i < achievmentsD.Rows.Count; ++i)
					{
						comboDeleteAch.Items.Insert(i, achievmentsD.Rows[i][0].ToString());
					}
				}
			}
		}

	

		private void btnEditWorkout_Click(object sender, EventArgs e)
		{
			int clientID = TrainerClientList.PassedClientID;
			if (comboEditWorkout.SelectedIndex == -1)
			{
				MessageBox.Show("Please, Choose a workout");
				return;
			}

			string achName = comboEditWorkout.SelectedItem.ToString();
			int res = controllerObj.UpdateWorkout(clientID, achName);
			if (res == 0)
			{
				MessageBox.Show("ERROR updating the workout");
			}
			else
			{
				MessageBox.Show("Updated Successfully");
			}


			DataTable clientWork = controllerObj.SelectClientWorkout(clientID);
			if (clientWork == null)
			{
				labelWorkout.ForeColor = Color.DarkRed;
				labelWorkout.Text = "No workout for this client";
			}
			else
			{
				labelWorkout.Text = clientWork.Rows[0][0].ToString();
			}
		}

		private void btnDeleteAch_Click(object sender, EventArgs e)
		{
			int clientID = TrainerClientList.PassedClientID;
			if (comboDeleteAch.SelectedIndex == -1)
			{
				MessageBox.Show("Please, Choose a workout");
				return;
			}

			string achName = comboDeleteAch.SelectedItem.ToString();

			int res = controllerObj.DeleteAchievment(clientID, achName);
			if (res == 0)
			{
				MessageBox.Show("ERROR Deleting achievment");
			}
			else
			{
				MessageBox.Show("Removed Successfully");
				comboDeleteAch.Items.Remove(achName);

				comboAchievments.Items.Clear();
				DataTable achievments = controllerObj.SelectAchievementNames(clientID);

				if (achievments == null)
				{
					MessageBox.Show("No achievments to add for this client");
				}
				else
				{
					for (int i = 0; i < achievments.Rows.Count; ++i)
					{
						comboAchievments.Items.Insert(i, achievments.Rows[i][0].ToString());
					}
				}
			}

		}
	}
}
