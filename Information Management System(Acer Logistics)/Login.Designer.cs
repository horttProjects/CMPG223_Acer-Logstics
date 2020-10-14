namespace Information_Management_System_Acer_Logistics_
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblFP = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.showCheckBox = new System.Windows.Forms.CheckBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(119, 234);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Enter your user name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(87, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(150, 129);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 6;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(150, 163);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(85, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "New user?";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// lblFP
			// 
			this.lblFP.AutoSize = true;
			this.lblFP.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFP.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblFP.Location = new System.Drawing.Point(178, 206);
			this.lblFP.Name = "lblFP";
			this.lblFP.Size = new System.Drawing.Size(97, 15);
			this.lblFP.TabIndex = 10;
			this.lblFP.Text = "Forgot password?";
			this.lblFP.Visible = false;
			this.lblFP.Click += new System.EventHandler(this.label7_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(88, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Please enter details to login";
			this.label5.Visible = false;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// showCheckBox
			// 
			this.showCheckBox.AutoSize = true;
			this.showCheckBox.Location = new System.Drawing.Point(270, 166);
			this.showCheckBox.Name = "showCheckBox";
			this.showCheckBox.Size = new System.Drawing.Size(51, 17);
			this.showCheckBox.TabIndex = 12;
			this.showCheckBox.Text = "show";
			this.showCheckBox.UseVisualStyleBackColor = true;
			this.showCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(105, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 108);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 332);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.showCheckBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblFP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox showCheckBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

