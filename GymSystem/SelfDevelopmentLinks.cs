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
    public partial class SelfDevelopmentLinks : Form
    {
        Controller controllerObj;
        public SelfDevelopmentLinks()
        {
            InitializeComponent();
            controllerObj = new Controller();
/*            DataTable dt = controllerObj.SelectRSSN();
            SSNcombo.DataSource = dt;
            SSNcombo.DisplayMember = "rSSN";*/
        }

        private void SelfDevelopmentLinks_Load(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ShowRCourseLinks();
            CourseLinksgridview.DataSource = dt1;
            CourseLinksgridview.Refresh();
        }
    }
}
