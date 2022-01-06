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
    public partial class ClientAchievments : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public ClientAchievments()
        {
            InitializeComponent();
        }

        private void ClientAchievments_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectClient(auth.getClient_ID());
            ClientName.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
            dt = controllerObj.SelectAchievementsDetails(auth.getClient_ID());
            if (dt.Rows.Count == 0) return;
            Label Titles = new Label();
            Titles.Location = new Point(210, 190);
            Titles.Text = "Achievement Name";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            groupBox1.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(410, 190);
            Titles.Text = "score";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            groupBox1.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(610, 190);
            Titles.Text = "Description";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            groupBox1.Controls.Add(Titles);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label SubType = new Label();
                SubType.Location = new Point(210, 225 + 20 * i);
                SubType.Text = dt.Rows[i].Field<String>("achievementName");
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                groupBox1.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(410, 225 + 20 * i);
                SubType.Text = dt.Rows[i].Field<int>("score").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                groupBox1.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(610, 225 + 20 * i);
                SubType.Text = dt.Rows[i].Field<string>("Describtion").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                groupBox1.Controls.Add(SubType);
            }

        }
    }
}
