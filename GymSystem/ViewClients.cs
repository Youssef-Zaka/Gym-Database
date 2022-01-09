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
    public partial class ViewClients : Form
    {
        Controller controllerObj;
        public ViewClients()
        {
            InitializeComponent();
        }

        private void ViewClients_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectAllClients();
            AllClientsDt.DataSource = dt1;
            AllClientsDt.Refresh();

            DataTable dt2 = controllerObj.SelectLastVisit();
            LastVisitdt.DataSource = dt2;
            LastVisitdt.Refresh();
        }
    }
}
