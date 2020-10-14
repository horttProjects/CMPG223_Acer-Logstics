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
		float totalSales = 0;
		float totalOrders = 0;
		string readSONotdelivered = "SELECT name, Date, Quantity, Status, sell FROM OrderTable, Product, Sales_Order WHERE Sales_Order.Product_ID = Product.Product_ID AND Sales_Order.Order_ID = OrderTable.Order_ID";
		string readPONotDel = "SELECT Firstname, Lastname, name, Date, Quantity, Received, sell FROM SupplyProd, Product, OrderTable, Supplier WHERE SupplyProd.Order_ID = OrderTable.Order_ID AND SupplyProd.Product_ID = Product.Product_ID AND SupplyProd.Supplier_ID = Supplier.Supplier_ID";
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
		public void readPO()
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand("SELECT SupplyProd_ID, Received, name, Date, Quantity FROM SupplyProd, OrderTable, Product WHERE SupplyProd.Order_ID=OrderTable.Order_ID AND SupplyProd.Product_ID=Product.Product_ID", con);
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = com;
			adp.Fill(ds, "data");

			dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "data";

			con.Close();
		}
		private void AcerLogisics_Load(object sender, EventArgs e)
		{
			readPO();
			readInventory("SELECT * FROM Inventory");
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

			float SODelivered = 0;
			float SONotDelivered = 0;
			SO.Items.Clear();
			SO.Items.Add("Acer Logisticts");
			SO.Items.Add("\t\tSales orders not delivered");
			SO.Items.Add("=====================================");
			SO.Items.Add("Date: " + DateTime.UtcNow.ToShortDateString() + " Time: " + DateTime.UtcNow.ToShortTimeString());
			//SO.Items.Add("\n");
			SO.Items.Add("_______________________________________________");
			SO.Items.Add("Product\tPurchased\t\tQuantity");
			SO.Items.Add("_______________________________________________");
			int counter = 0;
			SqlDataReader dRead = com.ExecuteReader();
			while (dRead.Read())
			{
				if (dRead.HasRows)
				{
					string[] date = dRead.GetValue(1).ToString().Split(' ');
					if (date[0].CompareTo(dateTimePicker1.Value.ToString("yyyy/mm/dd")) <= 1)
					{
						if (dRead.GetValue(3).ToString() == "False")
						{
							SO.Items.Add(++counter + ". " + dRead.GetValue(0).ToString() + "\t" + dRead.GetValue(1).ToString() + " \t" + dRead.GetValue(2).ToString() + "liters");
							SONotDelivered += float.Parse(dRead.GetValue(2).ToString());
						}
						else
						{
							SODelivered += float.Parse(dRead.GetValue(2).ToString());
							totalSales = float.Parse(dRead.GetValue(4).ToString()) * SODelivered;
						}
					}
				}
				
			}
			//
			SO.Items.Add("\n");
			SO.Items.Add("_______________________________________________");
			SO.Items.Add("Total Sales Sold: " + SODelivered);
			SO.Items.Add("Total Sales Not Sold: " + SONotDelivered);
			SO.Items.Add("_______________________________________________");
			con.Close();
		}
		public void readPO(string quiery)
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(quiery, con);
			float POdelivered = 0;
			float PONotdelivered = 0;
			dRead = com.ExecuteReader();
			PO.Items.Clear();
			PO.Items.Add("Acer Logisticts");
			PO.Items.Add("\t\tPurchase orders not delivered");
			PO.Items.Add("=====================================");
			PO.Items.Add("Date: " + DateTime.UtcNow.ToShortDateString() + " Time: " + DateTime.UtcNow.ToShortTimeString());
			//PO.Items.Add("\n");
			PO.Items.Add("_______________________________________________________");
			PO.Items.Add("Supplier\tName\tProduct\tOrdered\t\tQuantity");
			PO.Items.Add("_______________________________________________________");
			int counter = 0;
			while (dRead.Read())
			{
				if(dRead.HasRows)
				{
					string[] date = dRead.GetValue(3).ToString().Split(' ');

					if (date[0].CompareTo(dateTimePicker1.Value.ToString("yyyy/mm/dd")) <= 1)
					{
						if (dRead.GetValue(5).ToString() == "False")
						{
							PO.Items.Add(++counter + ". " + dRead.GetValue(0).ToString() + " " + dRead.GetValue(1).ToString() + " \t" + dRead.GetValue(2).ToString() + "\t" + dRead.GetValue(3).ToString() + "\t" + dRead.GetValue(4).ToString() + "liters");
							PONotdelivered += float.Parse(dRead.GetValue(4).ToString());
						}
						else
						{
							POdelivered += float.Parse(dRead.GetValue(4).ToString());
							totalOrders = float.Parse(dRead.GetValue(6).ToString()) * POdelivered;
						}
					}
				}
				
			}

			PO.Items.Add("\n");
			PO.Items.Add("_______________________________________________________");
			PO.Items.Add("Total Purchase Orders Delivered = " + POdelivered + "Liters");
			PO.Items.Add("Total Purchase Orders Not Delivered = " + PONotdelivered + "Liters");
			PO.Items.Add("_______________________________________________________");
			con.Close();
		}
		private void Management_SelectedIndexChanged(object sender, EventArgs e)
		{

			readAll(readDta);
			readSO(readSONotdelivered);
			readPO(readPONotDel);
			readAll();
			lblProfit.Text = "PROFIT MADE FOR THE PERIOD: R" + (totalSales - totalOrders);
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
				(new Human_Resources()).deletedata("DELETE FROM Supplier WHERE Supplier_ID = '" + (textBox1.Text) + "'");
				MessageBox.Show(textBox1.Text + " Deleted");
				textBox1.Text = string.Empty;
				
				readAll(readDta);
			}
		}

        private void logisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			(new Logistics()).ShowDialog();
        }

		private void comboBox4_DropDown(object sender, EventArgs e)
		{
			con = new SqlConnection(conStr);
			con.Open();

			ProdcomboBox.Items.Clear();
			com = new SqlCommand("SELECT name, Descr FROM Product", con);
			dRead = com.ExecuteReader();
			while (dRead.Read())
			{
				ProdcomboBox.Items.Add(dRead.GetValue(0) + " " + dRead.GetValue(1));
			}
			con.Close();
		}
		public void readSupplier(string readProd)
		{
			con = new SqlConnection(conStr);
			con.Open();

			comboBox5.Items.Clear();
			com = new SqlCommand(readProd, con);
			dRead = com.ExecuteReader();
			while (dRead.Read())
			{
				comboBox5.Items.Add(dRead.GetValue(0) + " " + dRead.GetValue(1));
			}
			con.Close();
		}
		private void comboBox5_DropDown(object sender, EventArgs e)
		{
			readSupplier("SELECT Firstname, Lastname FROM Supplier");
		}
		public void addPO(string quiery, float qty, int OrderID, int prodID, int SuppID)
		{
			con.Open();
			com = new SqlCommand(quiery, con);
			com.Parameters.AddWithValue("Received", "False");
			com.Parameters.AddWithValue("Quantity", qty);
			com.Parameters.AddWithValue("Order_ID", OrderID);
			com.Parameters.AddWithValue("Product_ID", prodID);
			com.Parameters.AddWithValue("Supplier_ID", SuppID);
			com.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Purchase Order Added");
		}
		public void readAll()
		{
			con = new SqlConnection(conStr);
			con.Open();
			adp = new SqlDataAdapter();
			ds = new DataSet();
			com = new SqlCommand("SELECT SupplyProd_ID, Firstname, Lastname, Quantity, Date, name FROM SupplyProd, Supplier, Product, OrderTable WHERE SupplyProd.Supplier_ID = Supplier.Supplier_ID AND SupplyProd.Order_ID = OrderTable.Order_ID AND SupplyProd.Product_ID = Product.Product_ID", con);

			adp.SelectCommand = com;
			adp.Fill(ds, "Data");

			dataGridView2.DataSource = ds;
			dataGridView2.DataMember = "Data";
			con.Close();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Create_Account CA = new Create_Account();
			float qty = float.Parse(textBox3.Text);
			string[] product = ProdcomboBox.Text.Split(' ');
			string[] suppier = comboBox5.Text.Split(' ');
			int prodID = CA.getID("SELECT * FROM Product", product[0]);
			int supID = CA.getID("SELECT * FROM Supplier", suppier[0]);
			//MessageBox.Show((new Sales()).addOrder()+"");
			string add = "INSERT INTO SupplyProd VALUES(@Received, @Quantity, @Order_ID, @Product_ID, @Supplier_ID)";
			addPO(add, qty, (new Sales()).addOrder(), prodID, supID);
			readAll();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resources()).deletedata("DELETE FROM SupplyProd WHERE SupplyProd_ID = '" + (textBox4.Text) + "'");
				MessageBox.Show(textBox4.Text + " Deleted");
				textBox4.Text = string.Empty;

				readAll();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				string updateSupplier = "UPDATE SupplyProd SET " + comboBox4.Text + " = '" + textBox5.Text + "' WHERE Supplier_ID = '" + int.Parse(textBox6.Text) + "'";
				(new Human_Resources()).updatedata(updateSupplier);
				readAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnRetrive_Click(object sender, EventArgs e)
		{
			(new Graphical()).ShowDialog();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			readAll(readDta);
			readSO(readSONotdelivered);
			readPO(readPONotDel);
			readAll();
			lblProfit.Text = "PROFIT MADE FOR THE PERIOD: R" + (totalSales - totalOrders) ;
		}

		private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new Clients()).ShowDialog();
		}
		public void searchID(string quiery, string ID)
		{
			con.Open();
			com = new SqlCommand(quiery, con);
			dRead = com.ExecuteReader();
			while(dRead.Read())
			{
				if(dRead.GetValue(0).ToString()==ID && dRead.GetValue(3).ToString() == "False")
				{
					int id = (new Create_Account()).getID("SELECT * FROM Product", dRead.GetValue(1).ToString());
					String delivered = "True";
					(new Human_Resources()).updatedata("UPDATE INVENTORY SET QUANTITY = '" + (getQty("SELECT * FROM Inventory", id) + float.Parse(dRead.GetValue(2).ToString()).ToString() + "' WHERE Product_ID = '" + id.ToString() + "'"));
					(new Human_Resources()).updatedata("UPDATE SupplyProd SET Received = '" + delivered + "' WHERE SupplyProd_ID = '" + dRead.GetValue(0).ToString() + "'");
					readPO();
					readInventory("SELECT * FROM Inventory");
					break;
				}
				else
				{
					if (dRead.GetValue(0).ToString() == "True")
						MessageBox.Show("Order already received!!");
					else
						MessageBox.Show("Order not found. Try again");
				}
			}
			con.Close();
		}
		public float getQty(string quiery, int id)
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(quiery, con);
			SqlDataReader dr = com.ExecuteReader();
			while (dr.Read())
			{
				if (int.Parse(dr.GetValue(0).ToString()) == id)
					return float.Parse(dr.GetValue(1).ToString());
			}
			return 0;
		}
		private void btn_Click(object sender, EventArgs e)
		{
			string addInventoy = "SELECT SupplyProd_ID, name, Quantity, Received FROM SupplyProd,Product WHERE SupplyProd.Product_ID=Product.Product_ID";
			searchID(addInventoy, txtID.Text);
		}

		private void Inventory_Click(object sender, EventArgs e)
		{

		}
		public void readInventory(string quiery)
		{
			con = new SqlConnection(conStr);
			con.Open();
			com = new SqlCommand(quiery, con);
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = com;
			adp.Fill(ds, "data");

			dataGridView3.DataSource = ds;
			dataGridView3.DataMember = "data";

			con.Close();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resources()).deletedata("DELETE FROM Inventory WHERE Product_ID = '" + (textBox7.Text) + "'");
				MessageBox.Show(textBox7.Text + " Deleted");
				textBox7.Text = string.Empty;

				readInventory("SELECT * FROM Inventory");
			}
		}
	}
}