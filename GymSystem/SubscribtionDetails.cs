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
    public partial class SubscribtionDetails : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        //DataTableReader DTR;
        public SubscribtionDetails()
        {
            InitializeComponent();
        }

        private void SubscribtionDetails_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            //  DTR = controllerObj.SelectClient(auth.getClient_ID()).CreateDataReader();
            DataTable dt = controllerObj.SelectClient(auth.getClient_ID());
            //if(DTR.HasRows)
            ClientName.Text = dt.Rows[0].Field<string>("fName") + " " + dt.Rows[0].Field<string>("lName");
            PaymentMethod.Text = dt.Rows[0].Field<string>("paymentMethod");
            dt = controllerObj.SelectSubscriptionDetails(auth.getClient_ID());
            if (dt.Rows.Count == 0) return;
            Label Titles = new Label();
            Titles.Location = new Point(210, 190);
            Titles.Text = "Subscribtion Type";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            SubDetailsGroupBox.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(410, 190);
            Titles.Text = "Duration(months)";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            SubDetailsGroupBox.Controls.Add(Titles);
            Titles = new Label();
            Titles.Location = new Point(610, 190);
            Titles.Text = "Cost(LE)";
            Titles.AutoSize = true;
            Titles.Font = new Font(Titles.Font.FontFamily, 12);
            SubDetailsGroupBox.Controls.Add(Titles);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label SubType = new Label();
                SubType.Location = new Point(210, 225 + 20*i);
                SubType.Text = dt.Rows[i].Field<String>("subType");
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                SubDetailsGroupBox.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(410, 225 + 20 * i);
                SubType.Text = dt.Rows[i].Field<int>("duration").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                SubDetailsGroupBox.Controls.Add(SubType);
                SubType = new Label();
                SubType.Location = new Point(610, 225 + 20 * i);
                SubType.Text =  dt.Rows[i].Field<int>("cost").ToString();
                SubType.AutoSize = true;
                SubType.Font = new Font(SubType.Font.FontFamily, 12);
                SubDetailsGroupBox.Controls.Add(SubType);
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
