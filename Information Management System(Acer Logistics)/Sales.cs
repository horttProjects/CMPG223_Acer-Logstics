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
	public partial class Sales : Form
	{
		public Sales()
		{
			InitializeComponent();
		}
		private DataSet ds;
		private SqlDataAdapter adp;
		private SqlConnection con;
		private SqlDataReader dRead;
		private SqlCommand com;
		Create_Account CA;
		Human_Resources HR;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";

		private void comboBox1_MouseHover(object sender, EventArgs e)
		{
			comboBox1.ForeColor = Color.Black;
		}
		public void readProducts(string readProd)
		{
			con = new SqlConnection(conStr);
			con.Open();

			comboBox1.Items.Clear();
			com = new SqlCommand(readProd, con);
			dRead = com.ExecuteReader();
			while (dRead.Read())
			{
				comboBox1.Items.Add(dRead.GetValue(0) + " " + dRead.GetValue(1));
			}
			con.Close();
		}
		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			string readProd = "SELECT name, Descr FROM Product";
			readProducts(readProd);
		}
		public int addOrder()
		{
			try
			{
				CA = new Create_Account();
				con = new SqlConnection(conStr);
				con.Open();
				DateTime date = DateTime.Today;
				com = new SqlCommand("INSERT INTO OrderTable VALUES(@Date)", con);
				com.Parameters.AddWithValue("Date", date);
				com.ExecuteNonQuery();
				con.Close();
				int id = (CA).getID("SELECT * FROM OrderTable", date.ToString());
				return id;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
			}
		}
		public void addSO(string quiery, float qty, bool status, int prodID, int OrderID)
		{
			con.Open();
			com = new SqlCommand(quiery, con);
			com.Parameters.AddWithValue("Quantity", qty);
			com.Parameters.AddWithValue("Status", status);
			com.Parameters.AddWithValue("Product_ID", prodID);
			com.Parameters.AddWithValue("Order", OrderID);
			com.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Sales Order Added");
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			//addOrder();
			string[] product = comboBox1.Text.Split(' ');
			int id = (CA).getID("SELECT * FROM Product", product[0]);
			string SOquiery = "INSERT INTO Sales_Order VALUES(@Quantity, @Status, @Product_ID, @Order)";
			bool status;
			if (PRadioButton.Checked)
				status = true;
			else
				status = false;
			addSO(SOquiery, float.Parse(txtqty.Text), status, id, addOrder());
		}
		public void readAll()
		{
			con = new SqlConnection(conStr);
			con.Open();
			adp = new SqlDataAdapter();
			ds = new DataSet();
			com = new SqlCommand("SELECT * FROM Sales_Order", con);

			adp.SelectCommand = com;
			adp.Fill(ds, "Data");

			dataView.DataSource = ds;
			dataView.DataMember = "Data";
			con.Close();
		}
		private void Sales_Load(object sender, EventArgs e)
		{
			readAll();
			HR = new Human_Resources();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string updateQueiry = "UPDATE Sales_Order SET " + columnComboBox.Text + " = '" + txtNewVal.Text + "' WHERE salesOrder_ID = '" + int.Parse(txtIdUp.Text) + "'";
			HR.updatedata(updateQueiry);
			readAll();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			HR.deletedata("DELETE FROM Sales_Order WHERE salesOrder_ID = '" + textBox1.Text + "'");
			readAll();
		}
	}
}
