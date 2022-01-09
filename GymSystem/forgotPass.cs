using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace GymSystem
{
    public partial class forgotPass : Form
    {
        public static string to;
        Controller cont;
        public forgotPass()
        {
            InitializeComponent();
        }

        private void forgotPass_Load(object sender, EventArgs e)
        {
            cont = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, message1;
            DataTable userPass = new DataTable();
            MailMessage message = new MailMessage();
            pass = "zakariaxperiaz2_348d39928d700b6148f09fc84d4600cf";
            from = "zakariaxperiaz2@pepisandbox.com";
            to = EmailText.Text;

            userPass = cont.SelectClientPass(IDText.Text);

            message1 = "hi, your password is " + userPass.Rows[0][0].ToString();
            message.To.Add(to);

            message.From = new MailAddress(from);
            message.Body = message1;

            message.Subject = "Gym password request";
            SmtpClient smtp = new SmtpClient("smtp.netcorecloud.net");
            smtp.EnableSsl = true;
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            
            try
            {
                smtp.Send(message);
                MessageBox.Show("Password successfully sent");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            
            new Login().Show();
            this.Hide();
        }
    }
}



