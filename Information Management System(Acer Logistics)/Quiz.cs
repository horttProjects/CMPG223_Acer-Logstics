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
	public partial class Quiz : Form
	{
		public Quiz()
		{
			InitializeComponent();
		}
		string[] tmp;
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dr;
		private string userNM;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		private void button1_Click(object sender, EventArgs e)
		{
			if (tmp[2] == textBox1.Text)
			{
				Human_Resources HR = new Human_Resources();
				New_password NP = new New_password();
				NP.ShowDialog();
				MessageBox.Show(NP.getPass);
				string updateQueiry = "UPDATE Login SET Password = '" + NP.getPass + "' WHERE Id = '" + int.Parse(tmp[0]) + "'";
				HR.updatedata(updateQueiry);
				MessageBox.Show("New Password Created");
				this.Close();
			}
			else
			{
				errorProvider1.SetError(textBox1, "Wrong answer!");
			}
		}

		public bool searchUser(string username)
		{
			bool found = false;

			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand("SELECT * FROM Login", con);
			dr = comm.ExecuteReader();

			while(dr.Read())
			{
				if(dr.GetValue(1).ToString() == username)
				{
					tmp = (dr.GetValue(0).ToString() + "," + dr.GetValue(3).ToString() + "," + dr.GetValue(4).ToString()).Split(',');
					found = true;
				}
			}

			return found;
		}
		private void Quiz_Load(object sender, EventArgs e)
		{
			Forgot_Password FP = new Forgot_Password();
			FP.ShowDialog();

			if (searchUser(FP.getNM))
				lblQuestion.Text = tmp[1];
			else
				MessageBox.Show("Username was not found.");
		}
	}
}
