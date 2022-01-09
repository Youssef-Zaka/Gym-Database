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
    public partial class ClientFoodMeasurements : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public ClientFoodMeasurements()
        {
            InitializeComponent();
        }

        private void ClientFoodMeasurements_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectClient(auth.getClient_ID());
            ClientName.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
            dt = controllerObj.SelectFoodMeasurements(auth.getClient_ID());
            if (dt.Rows.Count == 0) return;
            Label Titles = new Label();
            Titles.Location = new Point(210, 90);
            Titles.Text = "Date";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            ClientAchievmentsGroupBox.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(410, 90);
            Titles.Text = "Callories";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            ClientAchievmentsGroupBox.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(610, 90);
            Titles.Text = "No. of hours slept";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            ClientAchievmentsGroupBox.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(810, 90);
            Titles.Text = "No. of water cups";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            ClientAchievmentsGroupBox.Controls.Add(Titles);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label SubType = new Label();
                SubType.Location = new Point(210, 115 + 20 * i);
                SubType.Text = dt.Rows[i].Field<DateTime>("measurementDate").ToShortDateString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                ClientAchievmentsGroupBox.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(410, 115 + 20 * i);
                SubType.Text = dt.Rows[i].Field<int>("callories").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                ClientAchievmentsGroupBox.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(610, 115 + 20 * i);
                SubType.Text = dt.Rows[i].Field<int>("sleepHours").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                ClientAchievmentsGroupBox.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(810, 115 + 20 * i);
                SubType.Text = dt.Rows[i].Field<int>("numCups").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                ClientAchievmentsGroupBox.Controls.Add(SubType);
            }
        }

        private void AddMeasurementButton_Click(object sender, EventArgs e)
        {
            AddFoodMeasurement AddM = new AddFoodMeasurement();
            this.Close();
            AddM.Show();
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
