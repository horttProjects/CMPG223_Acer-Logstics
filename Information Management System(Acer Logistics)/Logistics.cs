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
    public partial class Logistics : Form
    {
        public Logistics()
        {
            InitializeComponent();
        }
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
        private SqlDataAdapter adp;
        private SqlConnection con;
        private DataSet ds;
        private SqlCommand com;
        private SqlDataReader dRead;
        string orders = "SELECT salesOrder_ID, name, Descr, Quantity, Date, Status FROM Sales_Order, Product, OrderTable WHERE Sales_Order.Product_ID=Product.Product_ID AND Sales_Order.Order_ID=OrderTable.Order_ID";
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
        public void readDel(string quiery)
        {
            con.Open();
            com = new SqlCommand(quiery, con);
            adp = new SqlDataAdapter();
            ds = new DataSet();

            adp.SelectCommand = com;
            adp.Fill(ds, "DAT");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "DAT";

            con.Close();
        }
        private void Logistics_Load(object sender, EventArgs e)
		{
            readAll(orders);
            readDel("SELECT sales_ID, name, Descr, Quantity, Date, Status FROM OrderTable, Sales_Order, Product, Sales WHERE Sales.salesOrder_ID=Sales_Order.salesOrder_ID AND Sales_Order.Product_ID=Product.Product_ID AND Sales_Order.Order_ID=OrderTable.Order_ID");
		}
        public void deliver(string SO_ID)
		{
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO Sales VALUES (@dateOfDelivery, @salesOrder_ID)", conn);
            comm.Parameters.AddWithValue("dateOfDelivery", DateTime.Today);
            comm.Parameters.AddWithValue("salesOrder_ID", SO_ID);
            comm.ExecuteNonQuery();
            conn.Close();
		}
        public void searchID(string orders, int id)
		{
            con.Open();
            com = new SqlCommand(orders, con);
            dRead = com.ExecuteReader();

			while (dRead.Read())
			{
                if(int.Parse(dRead.GetValue(0).ToString()) == id)
				{
                    if(dRead.GetValue(5).ToString() == "False")
					{
                        deliver(dRead.GetValue(0).ToString());
                        bool del = true;
                        (new Human_Resources()).updatedata("UPDATE Sales_Order SET Status = '" + del.ToString() + "' WHERE salesOrder_ID = '" + int.Parse(dRead.GetValue(0).ToString()) + "'");
					}
                    else
					{
                        MessageBox.Show("Order already delivered");
					}
				}
			}
        }
		private void button1_Click(object sender, EventArgs e)
		{
            searchID(orders, int.Parse(textBox1.Text));
		}
	}
}
