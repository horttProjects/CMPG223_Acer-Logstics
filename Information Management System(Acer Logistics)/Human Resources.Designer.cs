namespace Information_Management_System_Acer_Logistics_
{
	partial class Human_Resources
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
			this.dataView = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNewVal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.columnComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdUp = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPN = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.FRadioButton = new System.Windows.Forms.RadioButton();
			this.MRadioButton = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblFN = new System.Windows.Forms.Label();
			this.SortcomboBox = new System.Windows.Forms.ComboBox();
			this.searchComboBox = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(12, 292);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.Size = new System.Drawing.Size(818, 223);
			this.dataView.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDelete);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(442, 39);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 162);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete Employee";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(61, 69);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(61, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNewVal);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Controls.Add(this.columnComboBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtIdUp);
			this.groupBox2.Location = new System.Drawing.Point(235, 38);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 163);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update Employee";
			// 
			// txtNewVal
			// 
			this.txtNewVal.Location = new System.Drawing.Point(79, 81);
			this.txtNewVal.Name = "txtNewVal";
			this.txtNewVal.Size = new System.Drawing.Size(115, 20);
			this.txtNewVal.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "New value:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(56, 125);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(93, 23);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// columnComboBox
			// 
			this.columnComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.columnComboBox.FormattingEnabled = true;
			this.columnComboBox.Items.AddRange(new object[] {
            "Firstname",
            "LastName",
            "gender",
            "Email",
            "Phone_Number",
            "Address",
            "Position"});
			this.columnComboBox.Location = new System.Drawing.Point(79, 54);
			this.columnComboBox.Name = "columnComboBox";
			this.columnComboBox.Size = new System.Drawing.Size(115, 21);
			this.columnComboBox.TabIndex = 0;
			this.columnComboBox.Text = "Column to update";
			this.columnComboBox.MouseHover += new System.EventHandler(this.columnComboBox_MouseHover);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 1;
			this.label1.Tag = "";
			this.label1.Text = "ID:";
			// 
			// txtIdUp
			// 
			this.txtIdUp.Location = new System.Drawing.Point(79, 28);
			this.txtIdUp.Name = "txtIdUp";
			this.txtIdUp.Size = new System.Drawing.Size(115, 20);
			this.txtIdUp.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtPN);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtSurname);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.FRadioButton);
			this.groupBox1.Controls.Add(this.MRadioButton);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblFN);
			this.groupBox1.Location = new System.Drawing.Point(29, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 247);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Employee";
			// 
			// comboBox1
			// 
			this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "HR",
            "Sales Manager",
            "Employees"});
			this.comboBox1.Location = new System.Drawing.Point(47, 178);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.Text = "Position";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(64, 218);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(94, 152);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 20);
			this.txtAddress.TabIndex = 11;
			// 
			// txtPN
			// 
			this.txtPN.Location = new System.Drawing.Point(94, 126);
			this.txtPN.Name = "txtPN";
			this.txtPN.Size = new System.Drawing.Size(100, 20);
			this.txtPN.TabIndex = 10;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(94, 102);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(94, 45);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(100, 20);
			this.txtSurname.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(94, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 7;
			// 
			// FRadioButton
			// 
			this.FRadioButton.AutoSize = true;
			this.FRadioButton.Location = new System.Drawing.Point(109, 80);
			this.FRadioButton.Name = "FRadioButton";
			this.FRadioButton.Size = new System.Drawing.Size(59, 17);
			this.FRadioButton.TabIndex = 6;
			this.FRadioButton.TabStop = true;
			this.FRadioButton.Text = "Female";
			this.FRadioButton.UseVisualStyleBackColor = true;
			// 
			// MRadioButton
			// 
			this.MRadioButton.AutoSize = true;
			this.MRadioButton.Location = new System.Drawing.Point(25, 80);
			this.MRadioButton.Name = "MRadioButton";
			this.MRadioButton.Size = new System.Drawing.Size(48, 17);
			this.MRadioButton.TabIndex = 5;
			this.MRadioButton.TabStop = true;
			this.MRadioButton.Text = "Male\r\n";
			this.MRadioButton.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 159);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Phone Number:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Email:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Surname:";
			// 
			// lblFN
			// 
			this.lblFN.AutoSize = true;
			this.lblFN.Location = new System.Drawing.Point(49, 27);
			this.lblFN.Name = "lblFN";
			this.lblFN.Size = new System.Drawing.Size(38, 13);
			this.lblFN.TabIndex = 0;
			this.lblFN.Text = "Name:";
			// 
			// SortcomboBox
			// 
			this.SortcomboBox.BackColor = System.Drawing.SystemColors.Window;
			this.SortcomboBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.SortcomboBox.FormattingEnabled = true;
			this.SortcomboBox.Items.AddRange(new object[] {
            "Firstname",
            "LastName"});
			this.SortcomboBox.Location = new System.Drawing.Point(236, 248);
			this.SortcomboBox.Name = "SortcomboBox";
			this.SortcomboBox.Size = new System.Drawing.Size(99, 21);
			this.SortcomboBox.TabIndex = 7;
			this.SortcomboBox.Text = "Sort by";
			this.SortcomboBox.MouseHover += new System.EventHandler(this.SortcomboBox_MouseHover);
			// 
			// searchComboBox
			// 
			this.searchComboBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.searchComboBox.FormattingEnabled = true;
			this.searchComboBox.Items.AddRange(new object[] {
            "Id",
            "Firstname ",
            "LastName",
            "Email",
            "Phone number"});
			this.searchComboBox.Location = new System.Drawing.Point(363, 248);
			this.searchComboBox.Name = "searchComboBox";
			this.searchComboBox.Size = new System.Drawing.Size(94, 21);
			this.searchComboBox.TabIndex = 8;
			this.searchComboBox.Text = "Search by";
			this.searchComboBox.MouseHover += new System.EventHandler(this.comboBox2_MouseHover);
			// 
			// textBox2
			// 
			this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox2.Location = new System.Drawing.Point(464, 248);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(114, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "Enter value to search";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(3, 6);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblUsername.Size = new System.Drawing.Size(0, 22);
			this.lblUsername.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.lblUsername);
			this.panel1.Location = new System.Drawing.Point(442, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(428, 30);
			this.panel1.TabIndex = 11;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(778, 38);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(43, 13);
			this.linkLabel1.TabIndex = 12;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log-out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Human_Resources
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 527);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.searchComboBox);
			this.Controls.Add(this.SortcomboBox);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataView);
			this.Name = "Human_Resources";
			this.Text = "Human_Resources";
			this.Load += new System.EventHandler(this.Human_Resources_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox SortcomboBox;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox columnComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdUp;
		private System.Windows.Forms.TextBox txtNewVal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFN;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPN;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RadioButton FRadioButton;
		private System.Windows.Forms.RadioButton MRadioButton;
		private System.Windows.Forms.ComboBox searchComboBox;
		private System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}