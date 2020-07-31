namespace Visualization
{
	partial class CheckCenter
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
			this.MemberId = new System.Windows.Forms.Label();
			this.ISBNtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.MemberName = new System.Windows.Forms.Label();
			this.MemberLevel = new System.Windows.Forms.Label();
			this.MemberDiscount = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MembertextBox = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_basic_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.total_line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TotalPrice = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SubButton = new System.Windows.Forms.Button();
			this.PlusButton = new System.Windows.Forms.Button();
			this.CountControlPanel = new System.Windows.Forms.Panel();
			this.CountShow = new System.Windows.Forms.TextBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.PrintButton = new System.Windows.Forms.Button();
			this.discountTotal = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.CountControlPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MemberId
			// 
			this.MemberId.AutoSize = true;
			this.MemberId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberId.Location = new System.Drawing.Point(16, 13);
			this.MemberId.Name = "MemberId";
			this.MemberId.Size = new System.Drawing.Size(145, 19);
			this.MemberId.TabIndex = 14;
			this.MemberId.Text = "会员编号: NULL";
			// 
			// ISBNtextBox
			// 
			this.ISBNtextBox.Location = new System.Drawing.Point(65, 53);
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(129, 21);
			this.ISBNtextBox.TabIndex = 12;
			this.ISBNtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetISBN);
			this.ISBNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "ISBN";
			// 
			// MemberName
			// 
			this.MemberName.AutoSize = true;
			this.MemberName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberName.Location = new System.Drawing.Point(233, 13);
			this.MemberName.Name = "MemberName";
			this.MemberName.Size = new System.Drawing.Size(123, 19);
			this.MemberName.TabIndex = 15;
			this.MemberName.Text = "用户信息：无";
			// 
			// MemberLevel
			// 
			this.MemberLevel.AutoSize = true;
			this.MemberLevel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberLevel.Location = new System.Drawing.Point(419, 13);
			this.MemberLevel.Name = "MemberLevel";
			this.MemberLevel.Size = new System.Drawing.Size(123, 19);
			this.MemberLevel.TabIndex = 16;
			this.MemberLevel.Text = "用户等级：无";
			// 
			// MemberDiscount
			// 
			this.MemberDiscount.AutoSize = true;
			this.MemberDiscount.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberDiscount.Location = new System.Drawing.Point(580, 13);
			this.MemberDiscount.Name = "MemberDiscount";
			this.MemberDiscount.Size = new System.Drawing.Size(123, 19);
			this.MemberDiscount.TabIndex = 17;
			this.MemberDiscount.Text = "用户折扣：无";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.MemberDiscount);
			this.panel1.Controls.Add(this.MembertextBox);
			this.panel1.Controls.Add(this.MemberName);
			this.panel1.Controls.Add(this.MemberId);
			this.panel1.Controls.Add(this.MemberLevel);
			this.panel1.Location = new System.Drawing.Point(12, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 50);
			this.panel1.TabIndex = 18;
			// 
			// MembertextBox
			// 
			this.MembertextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MembertextBox.ImeMode = System.Windows.Forms.ImeMode.Close;
			this.MembertextBox.Location = new System.Drawing.Point(107, 9);
			this.MembertextBox.MaxLength = 8;
			this.MembertextBox.Name = "MembertextBox";
			this.MembertextBox.Size = new System.Drawing.Size(111, 29);
			this.MembertextBox.TabIndex = 13;
			this.MembertextBox.Visible = false;
			this.MembertextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetMember);
			this.MembertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharacterDigital);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ID,
            this.book_ISBN,
            this.book_title,
            this.book_count,
            this.book_basic_price,
            this.total_line});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(6, 97);
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(776, 293);
			this.listView1.TabIndex = 19;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// ID
			// 
			this.ID.Text = "编号";
			this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ID.Width = 50;
			// 
			// book_ISBN
			// 
			this.book_ISBN.Text = "国际图书编号";
			this.book_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_ISBN.Width = 110;
			// 
			// book_title
			// 
			this.book_title.Text = "书名";
			this.book_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_title.Width = 353;
			// 
			// book_count
			// 
			this.book_count.Text = "数量";
			this.book_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_count.Width = 62;
			// 
			// book_basic_price
			// 
			this.book_basic_price.Text = "售价";
			this.book_basic_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_basic_price.Width = 98;
			// 
			// total_line
			// 
			this.total_line.Text = "金额";
			this.total_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.total_line.Width = 98;
			// 
			// TotalPrice
			// 
			this.TotalPrice.AutoSize = true;
			this.TotalPrice.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TotalPrice.Location = new System.Drawing.Point(472, 418);
			this.TotalPrice.Name = "TotalPrice";
			this.TotalPrice.Size = new System.Drawing.Size(76, 19);
			this.TotalPrice.TabIndex = 21;
			this.TotalPrice.Text = "合计：0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 23);
			this.button1.TabIndex = 22;
			this.button1.Text = "会员";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SubButton
			// 
			this.SubButton.Location = new System.Drawing.Point(28, 4);
			this.SubButton.Name = "SubButton";
			this.SubButton.Size = new System.Drawing.Size(23, 23);
			this.SubButton.TabIndex = 24;
			this.SubButton.Text = "-";
			this.SubButton.UseVisualStyleBackColor = true;
			this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
			// 
			// PlusButton
			// 
			this.PlusButton.Location = new System.Drawing.Point(102, 6);
			this.PlusButton.Name = "PlusButton";
			this.PlusButton.Size = new System.Drawing.Size(23, 23);
			this.PlusButton.TabIndex = 25;
			this.PlusButton.Text = "+";
			this.PlusButton.UseVisualStyleBackColor = true;
			this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
			// 
			// CountControlPanel
			// 
			this.CountControlPanel.Controls.Add(this.CountShow);
			this.CountControlPanel.Controls.Add(this.DeleteButton);
			this.CountControlPanel.Controls.Add(this.PlusButton);
			this.CountControlPanel.Controls.Add(this.SubButton);
			this.CountControlPanel.Location = new System.Drawing.Point(472, 53);
			this.CountControlPanel.Name = "CountControlPanel";
			this.CountControlPanel.Size = new System.Drawing.Size(248, 38);
			this.CountControlPanel.TabIndex = 26;
			this.CountControlPanel.Visible = false;
			// 
			// CountShow
			// 
			this.CountShow.Location = new System.Drawing.Point(57, 6);
			this.CountShow.Name = "CountShow";
			this.CountShow.Size = new System.Drawing.Size(39, 21);
			this.CountShow.TabIndex = 29;
			this.CountShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountShow_KeyDown);
			this.CountShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(156, 4);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 26;
			this.DeleteButton.Text = "删除";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(6, 430);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(75, 23);
			this.PrintButton.TabIndex = 27;
			this.PrintButton.Text = "打印";
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// discountTotal
			// 
			this.discountTotal.AutoSize = true;
			this.discountTotal.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.discountTotal.Location = new System.Drawing.Point(624, 418);
			this.discountTotal.Name = "discountTotal";
			this.discountTotal.Size = new System.Drawing.Size(76, 19);
			this.discountTotal.TabIndex = 28;
			this.discountTotal.Text = "优惠：0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.discountTotal);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.PrintButton);
			this.groupBox1.Controls.Add(this.ISBNtextBox);
			this.groupBox1.Controls.Add(this.CountControlPanel);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.TotalPrice);
			this.groupBox1.Location = new System.Drawing.Point(12, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(788, 468);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "购物明细";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(349, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 19);
			this.label8.TabIndex = 57;
			this.label8.Text = "收银台";
			// 
			// CheckCenter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 595);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CheckCenter";
			this.Text = "CheckCenter";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.CountControlPanel.ResumeLayout(false);
			this.CountControlPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MemberId;
		private System.Windows.Forms.TextBox ISBNtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label MemberName;
		private System.Windows.Forms.Label MemberLevel;
		private System.Windows.Forms.Label MemberDiscount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader book_ISBN;
		private System.Windows.Forms.ColumnHeader book_title;
		private System.Windows.Forms.ColumnHeader book_count;
		private System.Windows.Forms.ColumnHeader book_basic_price;
		private System.Windows.Forms.ColumnHeader total_line;
		private System.Windows.Forms.Label TotalPrice;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button SubButton;
		private System.Windows.Forms.Button PlusButton;
		private System.Windows.Forms.Panel CountControlPanel;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.Label discountTotal;
		private System.Windows.Forms.TextBox CountShow;
		private System.Windows.Forms.TextBox MembertextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
	}
}