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
	public partial class Clients : Form
	{
		public Clients()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private DataSet ds;
		private SqlDataAdapter adp;
		private SqlCommand com;
		AcerLogisics AL;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		public void readAll(string queiry)
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(queiry, con);
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = com;
			adp.Fill(ds, "data");

			dataView.DataSource = ds;
			dataView.DataMember = "data";

			con.Close();
		}
		private void Clients_Load(object sender, EventArgs e)
		{
			readAll("SELECT * FROM Client");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string updateSupplier = "UPDATE Client SET " + columnComboBox.Text + " = '" + txtNewVal.Text + "' WHERE Supplier_ID = '" + int.Parse(txtIdUp.Text) + "'";
			(new Human_Resources()).updatedata(updateSupplier);
			readAll("SELECT * FROM Client");
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			con.Open();
			com = new SqlCommand("INSERT INTO Client VALUES(@Firstname, @Lastname, @Phone_Number, @Email, @Address)", con);

			com.Parameters.AddWithValue("Firstname", txtName.Text);
			com.Parameters.AddWithValue("Lastname", txtSurname.Text);
			com.Parameters.AddWithValue("Phone_Number", txtPN.Text);
			com.Parameters.AddWithValue("Email", txtEmail.Text);
			com.Parameters.AddWithValue("Address", txtAddress.Text);
			com.ExecuteNonQuery();
			con.Close();
			readAll("SELECT * FROM Client");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resources()).deletedata("DELETE FROM Supplier WHERE Supplier_ID = '" + (textBox1.Text) + "'");
				MessageBox.Show(textBox1.Text + " Deleted");
				textBox1.Text = string.Empty;

				readAll("SELECT * FROM Client");
			}
		}
	}
}
