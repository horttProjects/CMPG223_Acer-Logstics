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
	public partial class AcerLogisics : Form
	{
		public AcerLogisics()
		{
			InitializeComponent();
		}
		Human_Resources HR;
		private SqlDataAdapter adp;
		private SqlConnection con;
		private DataSet ds;
		private SqlCommand com;
		private SqlDataReader dRead;
		private string readDta = "SELECT * FROM Supplier";
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		public void readAll(string quiery)
		{

			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(quiery, con);
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = com;
			adp.Fill(ds, "data");

			dataView.DataSource = ds;
			dataView.DataMember = "data";

			con.Close();
		}
		private void hRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HR = new Human_Resources();
			HR.ShowDialog();
		}
		
		private void AcerLogisics_Load(object sender, EventArgs e)
		{
			
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new Sales()).ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}
		public void readSO(string quiery)
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(quiery, con);

			dRead = com.ExecuteReader();
			SO.Items.Clear();
			SO.Items.Add("Sales orders not delivered");
			SO.Items.Add("Product  Purchased  Quantity");

			while (dRead.Read())
			{
				SO.Items.Add(dRead.GetValue(0).ToString() + "  " + dRead.GetValue(1).ToString() + "  " + dRead.GetValue(2).ToString());
			}
			con.Close();
		}
		private void Management_SelectedIndexChanged(object sender, EventArgs e)
		{
			readAll(readDta);
			string readSONotdelivered = "SELECT name, Date, Quantity, Status FROM OrderTable, Product, Sales_Order WHERE Sales_Order.Product_ID = Product.Product_ID AND Sales_Order.Purchase_ID = PO.Purchase_ID";
			readSO(readSONotdelivered);
		}
		public void clear()
		{
			txtAddress.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtIdUp.Text = string.Empty;
			txtName.Text = string.Empty;
			txtNewVal.Text = string.Empty;
			txtPN.Text = string.Empty;
			txtSurname.Text = string.Empty;
		}
		public void addNew(string quiery, string FN, string LN, char gender, string PN, string email, string Address)
		{
			con.Open();
			com = new SqlCommand(quiery, con);
			com.Parameters.Add("Firstname", FN);
			com.Parameters.Add("Lastname", LN);
			com.Parameters.Add("gender", gender);
			com.Parameters.Add("Phone_number", PN);
			com.Parameters.Add("Email", email);
			com.Parameters.Add("Address", Address);
			com.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("New supplier added");
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string addSupplier = "INSERT INTO Supplier VALUES(@Firstname, @Lastname, @gender, @Phone_number, @Email, @Address)";
			char gender = ' ';
			if (MRadioButton.Checked)
				gender = 'M';
			else if(FRadioButton.Checked)
				gender = 'F';
			addNew(addSupplier, txtName.Text, txtSurname.Text, gender, txtPN.Text, txtEmail.Text, txtAddress.Text);
			clear();
			readAll(readDta);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string updateSupplier = "UPDATE Supplier SET " + columnComboBox.Text + " = '" + txtNewVal.Text + "' WHERE Supplier_ID = '" + int.Parse(txtIdUp.Text) + "'";
				(new Human_Resources()).updatedata(updateSupplier);
				clear();
				readAll(readDta);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resources()).deletedata("DELETE FROM SUpplier WHERE Supplier_ID = '" + (textBox1.Text) + "'");
				MessageBox.Show(textBox1.Text + "Deleted");
				textBox1.Text = string.Empty;
				
				readAll(readDta);
			}
		}

        private void logisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			(new Logistics()).ShowDialog();
        }
    }
}