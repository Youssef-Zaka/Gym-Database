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
    public partial class HallOfFame : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public HallOfFame()
        {
            InitializeComponent();
        }

        private void HallOfFame_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectHallOfFame();
            if (dt.Rows.Count == 0) { 
                FirstPlaceLabel.Text = "None Yet";
                SecondPlaceLabel.Text = "None Yet";
                ThirdPlaceLabel.Text = "None Yet";
                return;
            }
            else if (dt.Rows.Count == 1)
            {
                FirstPlaceLabel.Text = dt.Rows[0].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[0].Field<int>("Score");
                SecondPlaceLabel.Text = "None Yet";
                ThirdPlaceLabel.Text = "None Yet";
            }
            else if (dt.Rows.Count == 2)
            {
                FirstPlaceLabel.Text = dt.Rows[0].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[0].Field<int>("Score");
                SecondPlaceLabel.Text = dt.Rows[1].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[1].Field<int>("Score");
                ThirdPlaceLabel.Text = "None Yet";
            }
            else
            {
                FirstPlaceLabel.Text = dt.Rows[0].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[0].Field<int>("Score");
                SecondPlaceLabel.Text = dt.Rows[1].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[1].Field<int>("Score");
                ThirdPlaceLabel.Text = dt.Rows[2].Field<String>("fName") + " " + dt.Rows[0].Field<String>("lName") + " " + dt.Rows[2].Field<int>("Score");
            }

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWelcome().Show();
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ClientWelcome().Show();
        }
    }
}
