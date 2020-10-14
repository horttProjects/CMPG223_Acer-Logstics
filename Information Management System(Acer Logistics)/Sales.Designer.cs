namespace Information_Management_System_Acer_Logistics_
{
	partial class Sales
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SortcomboBox = new System.Windows.Forms.ComboBox();
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
			this.ProdcomboBox = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtqty = new System.Windows.Forms.TextBox();
			this.NRadioButton = new System.Windows.Forms.RadioButton();
			this.PRadioButton = new System.Windows.Forms.RadioButton();
			this.lblFN = new System.Windows.Forms.Label();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox2.Location = new System.Drawing.Point(460, 180);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(114, 20);
			this.textBox2.TabIndex = 16;
			this.textBox2.Text = "Enter value to search";
			// 
			// comboBox2
			// 
			this.comboBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Id",
            "First name ",
            "Last name",
            "Email",
            "Phone number",
            "Address"});
			this.comboBox2.Location = new System.Drawing.Point(359, 180);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(94, 21);
			this.comboBox2.TabIndex = 15;
			this.comboBox2.Text = "Search by";
			// 
			// SortcomboBox
			// 
			this.SortcomboBox.BackColor = System.Drawing.SystemColors.Window;
			this.SortcomboBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.SortcomboBox.FormattingEnabled = true;
			this.SortcomboBox.Items.AddRange(new object[] {
            "Firstname",
            "LastName"});
			this.SortcomboBox.Location = new System.Drawing.Point(232, 180);
			this.SortcomboBox.Name = "SortcomboBox";
			this.SortcomboBox.Size = new System.Drawing.Size(99, 21);
			this.SortcomboBox.TabIndex = 14;
			this.SortcomboBox.Text = "Sort by";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDelete);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(439, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 162);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete SO";
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
			this.groupBox2.Location = new System.Drawing.Point(232, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 163);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update SO";
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
            "Quantity",
            "Status"});
			this.columnComboBox.Location = new System.Drawing.Point(79, 54);
			this.columnComboBox.Name = "columnComboBox";
			this.columnComboBox.Size = new System.Drawing.Size(115, 21);
			this.columnComboBox.TabIndex = 0;
			this.columnComboBox.Text = "Column to update";
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
			this.groupBox1.Controls.Add(this.ProdcomboBox);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.txtqty);
			this.groupBox1.Controls.Add(this.NRadioButton);
			this.groupBox1.Controls.Add(this.PRadioButton);
			this.groupBox1.Controls.Add(this.lblFN);
			this.groupBox1.Location = new System.Drawing.Point(26, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 162);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add SO";
			// 
			// ProdcomboBox
			// 
			this.ProdcomboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.ProdcomboBox.FormattingEnabled = true;
			this.ProdcomboBox.Location = new System.Drawing.Point(6, 80);
			this.ProdcomboBox.Name = "ProdcomboBox";
			this.ProdcomboBox.Size = new System.Drawing.Size(188, 21);
			this.ProdcomboBox.TabIndex = 13;
			this.ProdcomboBox.Text = "Select product";
			this.ProdcomboBox.DropDown += new System.EventHandler(this.comboBox1_DropDown);
			this.ProdcomboBox.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(73, 124);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtqty
			// 
			this.txtqty.Location = new System.Drawing.Point(94, 19);
			this.txtqty.Name = "txtqty";
			this.txtqty.Size = new System.Drawing.Size(100, 20);
			this.txtqty.TabIndex = 7;
			// 
			// NRadioButton
			// 
			this.NRadioButton.AutoSize = true;
			this.NRadioButton.Checked = true;
			this.NRadioButton.Location = new System.Drawing.Point(119, 53);
			this.NRadioButton.Name = "NRadioButton";
			this.NRadioButton.Size = new System.Drawing.Size(63, 17);
			this.NRadioButton.TabIndex = 6;
			this.NRadioButton.TabStop = true;
			this.NRadioButton.Text = "NotPaid";
			this.NRadioButton.UseVisualStyleBackColor = true;
			// 
			// PRadioButton
			// 
			this.PRadioButton.AutoSize = true;
			this.PRadioButton.Location = new System.Drawing.Point(35, 53);
			this.PRadioButton.Name = "PRadioButton";
			this.PRadioButton.Size = new System.Drawing.Size(46, 17);
			this.PRadioButton.TabIndex = 5;
			this.PRadioButton.Text = "Paid";
			this.PRadioButton.UseVisualStyleBackColor = true;
			// 
			// lblFN
			// 
			this.lblFN.AutoSize = true;
			this.lblFN.Location = new System.Drawing.Point(38, 26);
			this.lblFN.Name = "lblFN";
			this.lblFN.Size = new System.Drawing.Size(49, 13);
			this.lblFN.TabIndex = 0;
			this.lblFN.Text = "Quantity:";
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(8, 224);
			this.dataView.Name = "dataView";
			this.dataView.Size = new System.Drawing.Size(544, 223);
			this.dataView.TabIndex = 10;
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 497);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.SortcomboBox);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataView);
			this.Name = "Sales";
			this.Text = "Sales";
			this.Load += new System.EventHandler(this.Sales_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox SortcomboBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtNewVal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox columnComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdUp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox ProdcomboBox;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtqty;
		private System.Windows.Forms.RadioButton NRadioButton;
		private System.Windows.Forms.RadioButton PRadioButton;
		private System.Windows.Forms.Label lblFN;
		private System.Windows.Forms.DataGridView dataView;
	}
}