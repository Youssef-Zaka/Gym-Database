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
    public partial class ReceptionistMain : Form
    {
        public ReceptionistMain()
        {
            InitializeComponent();
        }

        private void AddNewClientbutton_Click(object sender, EventArgs e)
        {
            NewClient newclient1 = new NewClient();
            newclient1.Show();
            this.Hide();
        }

        private void AddPotentialClientbutton_Click(object sender, EventArgs e)
        {
            PotentialClient pclient1 = new PotentialClient();
            pclient1.Show();
            this.Hide();
        }

        private void ChangePaymentMethodbutton_Click(object sender, EventArgs e)
        {
            PaymentMethodManagement payment = new PaymentMethodManagement();
            payment.Show();
            this.Hide();
        }

        private void AccessSelfDevelopmentLinksbutton_Click(object sender, EventArgs e)
        {
            SelfDevelopmentLinks links = new SelfDevelopmentLinks();
            links.Show();
            this.Hide();
        }

        private void SellUpdateSupplementsbutton_Click(object sender, EventArgs e)
        {
            Sell_UpdateSupplements supp = new Sell_UpdateSupplements();
            supp.Show();
            this.Hide();
        }

        private void ViewSurveysbutton_Click(object sender, EventArgs e)
        {
            ViewSurvey survey = new ViewSurvey();
            survey.Show();
            this.Hide();
        }

        private void Managehalloffamebounsesbutton_Click(object sender, EventArgs e)
        {
            HallOfFameBouns bouns = new HallOfFameBouns();
            bouns.Show();
            this.Hide();
        }
    }
}
