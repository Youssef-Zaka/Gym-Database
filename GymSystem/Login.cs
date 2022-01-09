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
    public partial class Login : Form
    {
        Controller controllerObj;
        Auth auth = Auth.Instance;
        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }
        ~Login()
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AdminLogin(UserText.Text, PassText.Text);
            if (dt != null)
            {
                auth.setSSN(dt.Rows[0].Field<string>("adminSSN"));
                new main_menu().Show();
                this.Hide();
                return;

            }
            dt = controllerObj.TrainerLogin(UserText.Text, PassText.Text);
            if (dt != null)
            {
                auth.setSSN(dt.Rows[0].Field<string>("trainerSSN"));
                new TrainerWelcome().Show();
                this.Hide();
                return;

            }
            dt = controllerObj.receptionistLogin(UserText.Text, PassText.Text);
            if (dt != null)
            {
                auth.setSSN(dt.Rows[0].Field<string>("rSSN"));
                new main_menu().Show();
                this.Hide();
                return;

            }
            dt = controllerObj.clientLogin(UserText.Text, PassText.Text);
            if (dt != null)
            {
                auth.setClient_ID(dt.Rows[0].Field<int>("clientID"));
                new ClientWelcome().Show();
                this.Hide();
                return;

            }

            MessageBox.Show("wrong account or password, please try again");
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
