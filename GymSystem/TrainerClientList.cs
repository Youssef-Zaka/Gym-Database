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

	public partial class TrainerClientList : Form
	{
		Controller controllerObj;
		Auth auth = Auth.Instance;	// is to changed according to the authenticator 

		public TrainerClientList()
		{
			InitializeComponent();
			controllerObj = new Controller();
		}

		private void TrainerClientList_Load(object sender, EventArgs e)
		{
			DataTable clientList = controllerObj.SelectClientsTrainedBy("30008976564599"/*auth.getTrainerSSN()*/);   // is to changed according to the authenticator 
			dataGridClientList.DataSource = clientList;
		}
	}
}
