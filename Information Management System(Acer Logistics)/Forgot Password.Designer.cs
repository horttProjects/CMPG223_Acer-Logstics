﻿namespace Information_Management_System_Acer_Logistics_
{
	partial class Forgot_Password
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.PasscheckBox = new System.Windows.Forms.CheckBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Std Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(106, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Forgot Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter your username:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(141, 69);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(111, 20);
			this.txtPassword.TabIndex = 2;
			// 
			// PasscheckBox
			// 
			this.PasscheckBox.AutoSize = true;
			this.PasscheckBox.Location = new System.Drawing.Point(258, 71);
			this.PasscheckBox.Name = "PasscheckBox";
			this.PasscheckBox.Size = new System.Drawing.Size(51, 17);
			this.PasscheckBox.TabIndex = 3;
			this.PasscheckBox.Text = "show";
			this.PasscheckBox.UseVisualStyleBackColor = true;
			this.PasscheckBox.CheckedChanged += new System.EventHandler(this.PasscheckBox_CheckedChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.DarkCyan;
			this.progressBar1.Location = new System.Drawing.Point(82, 153);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(179, 18);
			this.progressBar1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(132, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Check";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Forgot_Password
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 210);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.PasscheckBox);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Forgot_Password";
			this.Text = "Forgot_Password";
			this.Load += new System.EventHandler(this.Forgot_Password_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.CheckBox PasscheckBox;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
	}
}