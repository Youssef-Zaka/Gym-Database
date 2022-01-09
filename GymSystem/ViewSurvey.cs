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
    public partial class ViewSurvey : Form
    {
        Controller controllerObj;
        public ViewSurvey()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void ViewSurvey_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowSurveys();
            ViewSurveysdatagrid.DataSource = dt;
            ViewSurveysdatagrid.Refresh();
        }

        private void ViewSurveysdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
