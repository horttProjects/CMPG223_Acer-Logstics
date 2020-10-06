namespace Information_Management_System_Acer_Logistics_
{
	partial class AcerLogisics
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
			this.reports = new System.Windows.Forms.TabPage();
			this.lblUser = new System.Windows.Forms.Label();
			this.receiveSo = new System.Windows.Forms.TabPage();
			this.Inventory = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Change = new System.Windows.Forms.GroupBox();
			this.Add = new System.Windows.Forms.GroupBox();
			this.Management = new System.Windows.Forms.TabControl();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lblUsername = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.reports.SuspendLayout();
			this.Inventory.SuspendLayout();
			this.Management.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// reports
			// 
			this.reports.Controls.Add(this.lblUser);
			this.reports.Location = new System.Drawing.Point(4, 22);
			this.reports.Name = "reports";
			this.reports.Padding = new System.Windows.Forms.Padding(3);
			this.reports.Size = new System.Drawing.Size(767, 381);
			this.reports.TabIndex = 4;
			this.reports.Text = "Reports";
			this.reports.UseVisualStyleBackColor = true;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(506, 26);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(0, 17);
			this.lblUser.TabIndex = 2;
			// 
			// receiveSo
			// 
			this.receiveSo.Location = new System.Drawing.Point(4, 22);
			this.receiveSo.Name = "receiveSo";
			this.receiveSo.Padding = new System.Windows.Forms.Padding(3);
			this.receiveSo.Size = new System.Drawing.Size(767, 381);
			this.receiveSo.TabIndex = 2;
			this.receiveSo.Text = "Suppliers";
			this.receiveSo.UseVisualStyleBackColor = true;
			// 
			// Inventory
			// 
			this.Inventory.Controls.Add(this.groupBox3);
			this.Inventory.Controls.Add(this.Change);
			this.Inventory.Controls.Add(this.Add);
			this.Inventory.Location = new System.Drawing.Point(4, 22);
			this.Inventory.Name = "Inventory";
			this.Inventory.Padding = new System.Windows.Forms.Padding(3);
			this.Inventory.Size = new System.Drawing.Size(767, 381);
			this.Inventory.TabIndex = 0;
			this.Inventory.Text = "Inventory";
			this.Inventory.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(421, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete";
			// 
			// Change
			// 
			this.Change.Location = new System.Drawing.Point(214, 7);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(200, 100);
			this.Change.TabIndex = 1;
			this.Change.TabStop = false;
			this.Change.Text = "Update";
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(7, 7);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(200, 100);
			this.Add.TabIndex = 0;
			this.Add.TabStop = false;
			this.Add.Text = "Add";
			// 
			// Management
			// 
			this.Management.Controls.Add(this.Inventory);
			this.Management.Controls.Add(this.receiveSo);
			this.Management.Controls.Add(this.reports);
			this.Management.Location = new System.Drawing.Point(13, 31);
			this.Management.Name = "Management";
			this.Management.SelectedIndex = 0;
			this.Management.Size = new System.Drawing.Size(775, 407);
			this.Management.TabIndex = 0;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRDepartmentToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// hRDepartmentToolStripMenuItem
			// 
			this.hRDepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.logisticsToolStripMenuItem});
			this.hRDepartmentToolStripMenuItem.Name = "hRDepartmentToolStripMenuItem";
			this.hRDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hRDepartmentToolStripMenuItem.Text = "Departments";
			// 
			// hRToolStripMenuItem
			// 
			this.hRToolStripMenuItem.Name = "hRToolStripMenuItem";
			this.hRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hRToolStripMenuItem.Text = "HR";
			this.hRToolStripMenuItem.Click += new System.EventHandler(this.hRToolStripMenuItem_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salesToolStripMenuItem.Text = "Sales";
			this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
			// 
			// logisticsToolStripMenuItem
			// 
			this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
			this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.logisticsToolStripMenuItem.Text = "Logistics";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(550, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblUsername.Size = new System.Drawing.Size(0, 21);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1.Location = new System.Drawing.Point(721, 24);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(49, 15);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log-out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// AcerLogisics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.Management);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AcerLogisics";
			this.Text = "Management";
			this.Load += new System.EventHandler(this.AcerLogisics_Load);
			this.reports.ResumeLayout(false);
			this.reports.PerformLayout();
			this.Inventory.ResumeLayout(false);
			this.Management.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabPage reports;
		private System.Windows.Forms.TabPage receiveSo;
		private System.Windows.Forms.TabPage Inventory;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox Change;
		private System.Windows.Forms.GroupBox Add;
		private System.Windows.Forms.TabControl Management;
		public System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hRDepartmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}