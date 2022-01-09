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

		public static int PassedClientID;	// used in "TrainerClientInfo" form
		
		private void TrainerClientList_Load(object sender, EventArgs e)
		{
			DataTable clientList = controllerObj.SelectClientsTrainedBy(auth.getSSN());
			if (clientList == null)
			{
				MessageBox.Show("You have no clients to train");
				return;
			}
			dataGridClientList.DataSource = clientList;
		}

		private void dataGridClientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = dataGridClientList.CurrentCell.RowIndex;
			int ClientID = int.Parse(dataGridClientList.Rows[rowIndex].Cells[0].Value.ToString());
			PassedClientID = ClientID;
			new TrainerClientInfo().Show();
			
		}
	}
}
