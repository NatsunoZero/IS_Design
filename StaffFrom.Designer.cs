namespace Visualization
{
	partial class StaffFrom
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.结账BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.计算价格PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.当前时间TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.锁定LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 637);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(970, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.结账BToolStripMenuItem,
            this.系统管理SToolStripMenuItem,
            this.锁定LToolStripMenuItem,
            this.退出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(970, 25);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 结账BToolStripMenuItem
			// 
			this.结账BToolStripMenuItem.Name = "结账BToolStripMenuItem";
			this.结账BToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.结账BToolStripMenuItem.Text = "结账(&B)";
			this.结账BToolStripMenuItem.Click += new System.EventHandler(this.结账BToolStripMenuItem_Click);
			// 
			// 系统管理SToolStripMenuItem
			// 
			this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算价格PToolStripMenuItem,
            this.当前时间TToolStripMenuItem});
			this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
			this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
			this.系统管理SToolStripMenuItem.Text = "信息查询(&I)";
			// 
			// 计算价格PToolStripMenuItem
			// 
			this.计算价格PToolStripMenuItem.Name = "计算价格PToolStripMenuItem";
			this.计算价格PToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.计算价格PToolStripMenuItem.Text = "库存查询(&S)";
			this.计算价格PToolStripMenuItem.Click += new System.EventHandler(this.计算价格PToolStripMenuItem_Click);
			// 
			// 当前时间TToolStripMenuItem
			// 
			this.当前时间TToolStripMenuItem.Name = "当前时间TToolStripMenuItem";
			this.当前时间TToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.当前时间TToolStripMenuItem.Text = "记录查询(&R)";
			this.当前时间TToolStripMenuItem.Click += new System.EventHandler(this.当前时间TToolStripMenuItem_Click);
			// 
			// 锁定LToolStripMenuItem
			// 
			this.锁定LToolStripMenuItem.Name = "锁定LToolStripMenuItem";
			this.锁定LToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
			this.锁定LToolStripMenuItem.Text = "锁定(&L)";
			this.锁定LToolStripMenuItem.Click += new System.EventHandler(this.锁定LToolStripMenuItem_Click);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.退出ToolStripMenuItem.Text = "退出(&E)";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(946, 606);
			this.panel1.TabIndex = 4;
			// 
			// skinEngine1
			// 
			this.skinEngine1.SerialNumber = "";
			this.skinEngine1.SkinFile = null;
			// 
			// StaffFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 659);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StaffFrom";
			this.Text = "员工";
			this.Load += new System.EventHandler(this.StaffFrom_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem 计算价格PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 当前时间TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 结账BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 锁定LToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;
	}
}