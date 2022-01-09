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
    public partial class ClientWorkouts : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public ClientWorkouts()
        {
            InitializeComponent();
        }

        private void ClientWorkouts_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller(); ;
            DataTable dt = controllerObj.SelectPrivateWorkoutSchedule(auth.getClient_ID());
            PrivateGridView.DataSource = dt;


            dt = controllerObj.SelectWorkouts(auth.getClient_ID());
            WorkoutComboBox.DataSource = dt;
            WorkoutComboBox.DisplayMember = "workoutType";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectExcerciseInWorkout(WorkoutComboBox.Text);
            AllWorkoutsGrid.DataSource = dt;
        }
    }
}
