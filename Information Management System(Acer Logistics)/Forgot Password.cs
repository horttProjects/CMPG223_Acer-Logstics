using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Forgot_Password : Form
	{
		public Forgot_Password()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		private void PasscheckBox_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void Forgot_Password_Load(object sender, EventArgs e)
		{


		}

		public int searchByUsername(string queiry, string searchFor)
		{
			int fountAt = 0;

			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(queiry, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == searchFor)
					fountAt = int.Parse(dRead.GetValue(0).ToString());
			}
			return fountAt;
		}
		public string getNM { get; set; }
		private void button1_Click(object sender, EventArgs e)
		{
			getNM = txtName.Text;
			this.Close();
		}
	}
}
