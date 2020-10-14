using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class New_password : Form
	{
		public New_password()
		{
			InitializeComponent();
		}
		public string getPass { get; set; }
		private void btnCreate_Click(object sender, EventArgs e)
		{

			if (txtPass.Text == txtConfirm.Text)
			{
				getPass = txtPass.Text;
				this.Close();
			}
			else
			{
				MessageBox.Show("Passwords do not match!!");
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				txtPass.PasswordChar = '\0';
			else
				txtPass.PasswordChar = '*';
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
				txtConfirm.PasswordChar = '\0';
			else
				txtConfirm.PasswordChar = '*';
		}
	}
}
