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
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Permissions;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Human_Resources : Form
	{
		public Human_Resources()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlCommand comm;
		private DataSet ds;
		private SqlDataAdapter adp;
		private const string readEmployees = "SELECT Id,Firstname,LastName,gender,Email,Phone_Number,Address,Position  FROM Employees";
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";

		public void readAll(string quiery)
		{
			try
			{
				con = new SqlConnection(conStr);
				con.Open();
				comm = new SqlCommand(quiery, con);
				adp = new SqlDataAdapter();
				ds = new DataSet();

				adp.SelectCommand = comm;
				adp.Fill(ds, "data");

				dataView.DataSource = ds;
				dataView.DataMember = "data";
			
				con.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		//"SELECT Username, Firstname, LastName FROM Login, Employees WHERE Login.Id = Employees.UserID"
		private void Human_Resources_Load(object sender, EventArgs e)
		{
			readAll(readEmployees);
		}
		public void updatedata(string queiry)
		{
			try
			{
				con = new SqlConnection(conStr);
				con.Open();
				comm = new SqlCommand(queiry, con);
				comm.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Value updated");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public bool validateInput(string input)
		{
			if (input == string.Empty)
				return false;
			else
				return true;

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string updateQueiry = "UPDATE Employees SET " + columnComboBox.Text + " = '" + txtNewVal.Text + "' WHERE Id = '" + int.Parse(txtIdUp.Text) + "'";
			updatedata(updateQueiry);
			(new AcerLogisics()).clear();
			readAll(readEmployees);
		}
		public void deletedata(string deleteQueiry)
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(deleteQueiry, con);
			comm.ExecuteNonQuery();
			con.Close();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if(delete == DialogResult.OK)
			{
				string del = "DELETE FROM Employees WHERE Id = '" + textBox1.Text + "'";
				deletedata(del);
				MessageBox.Show(textBox1.Text + "Deleted");
				textBox1.Text = string.Empty;
				readAll(readEmployees);
			}
		}
		public void addEmployee(string queiry, string userNm, string userLn, char gender, string email, int PN, string Addres, string pos)
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(queiry, con);
			comm.Parameters.AddWithValue("Firstname", userNm);
			comm.Parameters.AddWithValue("LastName", userLn);
			comm.Parameters.AddWithValue("gender", gender);
			comm.Parameters.AddWithValue("Email", email);
			comm.Parameters.AddWithValue("Phone_Number", PN);
			comm.Parameters.AddWithValue("Address", Addres);
			comm.Parameters.AddWithValue("Position", pos);
			comm.Parameters.AddWithValue("UserID", "-1");
			comm.ExecuteNonQuery();
			con.Close();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			int phoneNr;
			char gender;
			if(validateInput(txtName.Text))
			{
				if (validateInput(txtSurname.Text))
				{
					if(MRadioButton.Checked || FRadioButton.Checked)
					{
						if (MRadioButton.Checked)
							gender = 'M';
						else
							gender = 'F';
						if(validateInput(txtEmail.Text))
						{
							if(int.TryParse(txtPN.Text, out phoneNr))
							{
								if (validateInput(txtAddress.Text))
								{
									if(validateInput(comboBox1.Text))
									{
										string add = "INSERT INTO Employees VALUES(@Firstname, @LastName, @gender, @Email, @Phone_Number, @Address, @Position, @UserID)";
										addEmployee(add, txtName.Text, txtSurname.Text, gender, txtEmail.Text, int.Parse(txtPN.Text), txtAddress.Text, comboBox1.Text);
										MessageBox.Show("Employee added");
										(new AcerLogisics()).clear();
										readAll(readEmployees);
									}
								}
							}
						}
					}
					else
					{
						MessageBox.Show("Choose gender!");
					}
				}
			}
		}

		private void comboBox2_MouseHover(object sender, EventArgs e)
		{
			comboBox2.ForeColor = Color.Black;
		}

		private void SortcomboBox_MouseHover(object sender, EventArgs e)
		{
			SortcomboBox.ForeColor = Color.Black;
		}

		private void columnComboBox_MouseHover(object sender, EventArgs e)
		{
			columnComboBox.ForeColor = Color.Black;
		}
	}
}
