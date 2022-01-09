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
    public partial class ViewClientscs : Form
    {
        Controller controllerObj;
        public ViewClientscs()
        {
            InitializeComponent();
        }

        private void ViewClientscs_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectAllClients();
            AllClientsDt.DataSource = dt1;
            AllClientsDt.Refresh();

            DataTable dt2 = controllerObj.SelectLastVisit();
            LastVisitdt.DataSource = dt2;
            AllClientsDt.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
