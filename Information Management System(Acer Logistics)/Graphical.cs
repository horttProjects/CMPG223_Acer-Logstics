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
	public partial class Graphical : Form
	{
		public Graphical()
		{
			InitializeComponent();
		}
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		private void Graphical_Load(object sender, EventArgs e)
		{
			string readSONotdelivered = "SELECT name, Date, Quantity, Status, sell FROM OrderTable, Product, Sales_Order WHERE Sales_Order.Product_ID = Product.Product_ID AND Sales_Order.Order_ID = OrderTable.Order_ID";
			SqlConnection con = new SqlConnection(conStr);
			con.Open();
			SqlCommand com = new SqlCommand(readSONotdelivered, con);
			SqlDataReader dRead = com.ExecuteReader();
			while(dRead.Read())
			{
				this.chart1.Series["Sales"].Points.AddXY(dRead.GetValue(1).ToString(), float.Parse(dRead.GetValue(2).ToString()) * float.Parse(dRead.GetValue(4).ToString()));
			}
		}
	}
}
