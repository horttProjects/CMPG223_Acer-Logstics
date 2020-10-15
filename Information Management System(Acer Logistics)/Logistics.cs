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
            readAll("SELECT salesOrder_ID, name, Descr, Quantity, Date FROM Sales_Order, Product, OrderTable WHERE Sales_Order.Product_ID=Product.Product_ID AND Sales_Order.Order_ID=OrderTable.Order_ID");
            readDel("SELECT sales_ID, name, Descr, Quantity, Date FROM OrderTable, Sales_Order, Product, Sales WHERE Sales.salesOrder_ID=Sales_Order.salesOrder_ID AND Sales_Order.Product_ID=Product.Product_ID AND Sales_Order.Order_ID=OrderTable.Order_ID");
		}
	}
}
