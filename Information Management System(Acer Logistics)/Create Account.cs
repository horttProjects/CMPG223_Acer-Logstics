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
using System.Drawing.Drawing2D;
using System.Xml;
using System.Configuration;

namespace Information_Management_System_Acer_Logistics_
{
	public partial class Create_Account : Form
	{
		public Create_Account()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\Acer Logistics\CMPG223_Acer-Logstics\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";
		private RecoverQuiz question;
		private string recovQuiz;
		private string recovAnswer;
		private int counter;
		private string userFirstName = null;
		

		/// <summary>
		/// Checks if the database is on the Employees database table
		/// </summary>
		/// <param name="userInput"></param>
		/// <returns></returns>
		public bool validateID(string userInput)
		{
			bool validity = false;
			
			con = new SqlConnection(conStr);
			con.Open();
			string readALL = "SELECT * FROM Employees";
			comm = new SqlCommand(readALL, con);
			dRead = comm.ExecuteReader();

			while(dRead.Read())
			{
				if (dRead.GetValue(0).ToString() == userInput)
				{
					validity = true;     // set to true if the ID is in the database
					userFirstName = dRead.GetValue(1).ToString();
					if (dRead.GetValue(8).ToString() != "-1")
					{
						errorProvider1.SetError(txtId, "Account already exist for this ID, please try again");
						validity = false;    //set to false if the user already have an account
					}
				}
				counter++;
			}

			con.Close();
			return validity;
		}
		// Generates a username
		public string generateUser(string userName)
		{
			Random num = new Random();

			string autoname = userName + num.Next(99, 9999);    //generates username

			return autoname;
		}
		/// <summary>
		/// Checks if the username alreadyexist in the database
		/// </summary>
		/// <param name="userInput"></param>
		/// <returns>A boolean</returns>
		public bool validateUsername(string userInput)
		{
			string userName = null;   // read from the database
			bool userExist = false;

			con = new SqlConnection(conStr);
			con.Open();
			string readALL = "SELECT * FROM Login";
			comm = new SqlCommand(readALL, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read() && userName != userInput)    // read and username does not exist
			{
				userName = dRead.GetValue(1).ToString();
				if(userName == userInput)
				{
					userName = generateUser(userFirstName);  // If it exist? generate new one
					lblSuggested.Text = "User with this name already exist. suggested " + userName;
					lblSuggested.Visible = true;
					userExist = true;
				}
			}

			con.Close();
			return userExist;
		}
		/// <summary>
		/// vaidates user input
		/// </summary>
		/// <param name="userNm"></param>
		/// <param name="userPass"></param>
		/// <param name="userConfirm"></param>
		/// <returns>
		/// A boolean
		/// </returns>
		public bool validateUserInput(string userNm, string userPass, string userConfirm)  
		{
			int userId;
			bool quiz = false;
			if (int.TryParse(txtId.Text, out userId))
			{
				if (userNm != string.Empty)
				{
					string userName = userNm;
					if (userPass != string.Empty && userConfirm != string.Empty)
					{
						if (userPass == userConfirm)
						{
							if (validateID(txtId.Text))
							{
								if(!validateUsername(userNm))
								{
									question = new RecoverQuiz();
									question.ShowDialog();
									quiz = question.QuizCreated;
									recovQuiz = question.getQuiz;
									recovAnswer = question.getAnswer;
								}
							}
						}
						else
						{
							errorProvider1.SetError(txtPassword, "Passwords do not match");
						}
					}
					else
					{
						MessageBox.Show("Please create you password");
					}
				}
				else
				{
					errorProvider1.SetError(txtUsername, "Please enter your username.");
				}
			}
			else
			{
				errorProvider1.SetError(txtId, "Invalid input.");
			}
			return quiz;
		}
		public int createUser(string queiry, string readLogin, string userName, string userPass) 
		{
			con.Open();
			comm = new SqlCommand(queiry, con);
			
			comm.Parameters.AddWithValue("Username", txtUsername.Text);
			comm.Parameters.AddWithValue("Password", txtPassword.Text);
			comm.Parameters.AddWithValue("Question", recovQuiz);
			comm.Parameters.AddWithValue("Answer", recovAnswer);

			comm.ExecuteNonQuery();

			con.Close();

			return getID(readLogin, txtUsername.Text);
		}
		public int getID(string queiry, string user)
		{
			int counter = 0;
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(queiry, con);
			dRead = comm.ExecuteReader();
			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == user)
					counter = int.Parse(dRead.GetValue(0).ToString());
			}
			con.Close();
			return counter;
		}
		private void btnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				Human_Resources HR = new Human_Resources();   // Create an object for the HR class
				string userNm = txtUsername.Text;
				string userPass = txtPassword.Text;
				string confirm = txtConfirm.Text;
				string writeLoginTable = "INSERT INTO Login VALUES(@Username, @Password, @Question, @Answer)";
				string readLogintable = "SELECT * FROM Login";
				
				if (validateUserInput(userNm, userPass, confirm))
				{
					int x = createUser(writeLoginTable, readLogintable, userNm, userPass);
					string updateQueiry = "UPDATE Employees SET UserID = '" + x.ToString() + "' WHERE Id = '" + int.Parse(txtId.Text) + "'";
					HR.updatedata(updateQueiry);
					MessageBox.Show("User Successfully created!");
					this.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}
	}
}
