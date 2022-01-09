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
                new ReceptionistMain().Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            ClientRadio.Checked = true;
            IDLABEL.Text = "ID";
        }

        private void TrainerRadio_CheckedChanged(object sender, EventArgs e)
        {
            IDLABEL.Text = "SSN";
        }

        private void ReceptionistRadio_CheckedChanged(object sender, EventArgs e)
        {
            IDLABEL.Text = "SSN";
        }

        private void ClientRadio_CheckedChanged(object sender, EventArgs e)
        {
            IDLABEL.Text = "ID";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (ClientRadio.Checked)
            {
                try
                {
                    DataTable dt = controllerObj.SelectClient_Signup(int.Parse(IDTEXT.Text));
                    if (dt == null || dt.Rows.Count == 0)
                    {
                        int result = controllerObj.SignUpClient(int.Parse(IDTEXT.Text), UserText.Text, PassText.Text);
                        if (result == 1)
                        {
                            MessageBox.Show("Signup Successful, please log in");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID exists, please log in");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (TrainerRadio.Checked)
            {
                try
                {
                    DataTable dt = controllerObj.SelectTrainer_Signup(IDTEXT.Text);
                    if (dt == null)
                    {
                        int result = controllerObj.SignUpTrainer(IDTEXT.Text , UserText.Text, PassText.Text);
                        if (result == 1)
                        {
                            MessageBox.Show("Signup Successful, please log in");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID exists, please log in");
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                try
                {
                    DataTable dt = controllerObj.SelectReceptionist_Signup(IDTEXT.Text);
                    if (dt == null)
                    {
                        int result = controllerObj.SignUpReceptionist(IDTEXT.Text, UserText.Text, PassText.Text);
                        if (result == 1)
                        {
                            MessageBox.Show("Signup Successful, please log in");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID exists, please log in");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        private void ForgotPassButton_Click(object sender, EventArgs e)
        {
            new forgotPass().Show();
            this.Hide();
        }
    }
}
