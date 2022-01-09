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
    public partial class ClientFacilitiesSchedule : Form
    {
        public ClientFacilitiesSchedule()
        {
            InitializeComponent();
        }

        private void ClientFacilitiesSchedule_Load(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller(); ;
            Auth auth = Auth.Instance;
            DataTable dt = controllerObj.SelectclassForClients();
            ClientFacilitiesScheduleDatagrid.DataSource = dt;

            dt = controllerObj.showservicename();
            ClientClassesScheduleDatagrid.DataSource = dt;
            
        }
    }
}
