using System;
using System.CodeDom.Compiler;
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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private int UserID;
		string readAll = "SELECT * FROM Login";
		string readAEmpl = "SELECT * FROM Employees";
		string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		private void Form1_Load(object sender, EventArgs e)
		{
			System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
			gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
			Region rg = new Region(gp);
			pictureBox1.Region = rg;
		}
		public bool authenticate(string userName, string password, ref int user)
		{
			bool results = false;
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(readAll, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == userName && dRead.GetValue(2).ToString() == password)
				{
					results = true;
					user = int.Parse(dRead.GetValue(0).ToString());
				}
			}
			if (!results)
				lblFP.Visible = true;
			con.Close();

			return results; 
		}
		public string getUserdet(string queiry, int id)
		{
			string details = null;
			con.Open();
			dRead = (new SqlCommand(queiry, con)).ExecuteReader();
			while (dRead.Read())
			{
				if(dRead.GetValue(8).ToString() == id.ToString())
				{
					details += dRead.GetValue(1).ToString() + "," + dRead.GetValue(2).ToString() + "," + dRead.GetValue(7).ToString();
				}
			}
			return details;
		}
		public string getuserName { get; set; }
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				AcerLogisics AL = new AcerLogisics();
				Create_Account CA = new Create_Account();
				Human_Resources HR = new Human_Resources();
				if (authenticate(txtID.Text, txtPassword.Text, ref UserID))
				{
					//MessageBox.Show("User at " + CA.getID("SELECT * FROM Login", txtID.Text).ToString());
					string[] tmp = getUserdet(readAEmpl, CA.getID("SELECT * FROM Login", txtID.Text)).Split(',');

					if (tmp[2] == "Manager")
					{
						AL.lblUsername.Text = HR.lblUsername.Text = "Logged in as " + tmp[0] + " " + tmp[1];
						AL.ShowDialog();
						this.Close();
					}
					else if (tmp[2] == "HR")
					{
						HR.lblUsername.Text = "Logged in as " + tmp[0] + " " + tmp[1];
						HR.ShowDialog();
						this.Close();
					}
					else if(tmp[2] == "Administrator"){
						AL.lblUsername.Text = HR.lblUsername.Text = "Logged in as " + tmp[0] + " " + tmp[1];
						AL.ShowDialog();
						this.Close();
					}
					else if(tmp[2] == "Sales Manager")
					{
						(new Sales()).ShowDialog();
					}

				}
				else
				{
					if (txtID.Text == "Employee" || txtID.Text == "employee" && txtPassword.Text == "0000")
						(new Graphical()).ShowDialog();
					else
					{
						lblFP.Visible = true;
						if (txtPassword.Text == string.Empty)
							label5.Visible = true;
						errorProvider1.SetError(txtPassword, "Invaid password");
					}

				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void showCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (showCheckBox.Checked)
				txtPassword.PasswordChar = '\0';
			else
				txtPassword.PasswordChar = '*';
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Create_Account newUser = new Create_Account();
			newUser.ShowDialog();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Quiz forgotPass = new Quiz();
			forgotPass.ShowDialog();
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
