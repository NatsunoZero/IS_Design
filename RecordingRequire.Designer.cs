namespace Visualization
{
	partial class RecordingRequire
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_basic_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ClearButton = new System.Windows.Forms.Button();
			this.RecordingID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MemberDiscount = new System.Windows.Forms.Label();
			this.MemberName = new System.Windows.Forms.Label();
			this.MemberId = new System.Windows.Forms.Label();
			this.MemberLevel = new System.Windows.Forms.Label();
			this.RecordingTotalPrice = new System.Windows.Forms.Label();
			this.RecordingDate = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ID,
            this.book_id,
            this.book_ISBN,
            this.book_title,
            this.book_count,
            this.book_basic_price});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(3, 59);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(708, 293);
			this.listView1.TabIndex = 21;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// ID
			// 
			this.ID.Text = "编号";
			this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ID.Width = 41;
			// 
			// book_id
			// 
			this.book_id.Text = "书籍编号";
			this.book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_id.Width = 80;
			// 
			// book_ISBN
			// 
			this.book_ISBN.Text = "国际图书编号";
			this.book_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_ISBN.Width = 98;
			// 
			// book_title
			// 
			this.book_title.Text = "书名";
			this.book_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_title.Width = 328;
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
			this.book_basic_price.Width = 86;
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(222, 19);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 26;
			this.ClearButton.Text = "清空";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// RecordingID
			// 
			this.RecordingID.Location = new System.Drawing.Point(73, 19);
			this.RecordingID.Name = "RecordingID";
			this.RecordingID.Size = new System.Drawing.Size(129, 21);
			this.RecordingID.TabIndex = 25;
			this.RecordingID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetISBN);
			this.RecordingID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharacterDigital);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 24;
			this.label1.Text = "订单编号";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.MemberDiscount);
			this.panel1.Controls.Add(this.MemberName);
			this.panel1.Controls.Add(this.MemberId);
			this.panel1.Controls.Add(this.MemberLevel);
			this.panel1.Location = new System.Drawing.Point(12, 113);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(712, 50);
			this.panel1.TabIndex = 27;
			// 
			// MemberDiscount
			// 
			this.MemberDiscount.AutoSize = true;
			this.MemberDiscount.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberDiscount.Location = new System.Drawing.Point(573, 13);
			this.MemberDiscount.Name = "MemberDiscount";
			this.MemberDiscount.Size = new System.Drawing.Size(123, 19);
			this.MemberDiscount.TabIndex = 17;
			this.MemberDiscount.Text = "用户折扣：无";
			// 
			// MemberName
			// 
			this.MemberName.AutoSize = true;
			this.MemberName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberName.Location = new System.Drawing.Point(225, 13);
			this.MemberName.Name = "MemberName";
			this.MemberName.Size = new System.Drawing.Size(123, 19);
			this.MemberName.TabIndex = 15;
			this.MemberName.Text = "用户信息：无";
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
			// MemberLevel
			// 
			this.MemberLevel.AutoSize = true;
			this.MemberLevel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MemberLevel.Location = new System.Drawing.Point(404, 13);
			this.MemberLevel.Name = "MemberLevel";
			this.MemberLevel.Size = new System.Drawing.Size(123, 19);
			this.MemberLevel.TabIndex = 16;
			this.MemberLevel.Text = "用户等级：无";
			// 
			// RecordingTotalPrice
			// 
			this.RecordingTotalPrice.AutoSize = true;
			this.RecordingTotalPrice.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RecordingTotalPrice.Location = new System.Drawing.Point(321, 21);
			this.RecordingTotalPrice.Name = "RecordingTotalPrice";
			this.RecordingTotalPrice.Size = new System.Drawing.Size(144, 19);
			this.RecordingTotalPrice.TabIndex = 28;
			this.RecordingTotalPrice.Text = "订单总价：0.00";
			// 
			// RecordingDate
			// 
			this.RecordingDate.AutoSize = true;
			this.RecordingDate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RecordingDate.Location = new System.Drawing.Point(507, 24);
			this.RecordingDate.Name = "RecordingDate";
			this.RecordingDate.Size = new System.Drawing.Size(204, 19);
			this.RecordingDate.TabIndex = 29;
			this.RecordingDate.Text = "订单日期：YYYY-MM-DD";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.RecordingDate);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.RecordingTotalPrice);
			this.groupBox1.Controls.Add(this.RecordingID);
			this.groupBox1.Controls.Add(this.ClearButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 180);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(722, 368);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "订单明细";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(315, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 19);
			this.label8.TabIndex = 57;
			this.label8.Text = "订单查询";
			// 
			// RecordingRequire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 560);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RecordingRequire";
			this.Text = "RecordingRequire";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader book_id;
		private System.Windows.Forms.ColumnHeader book_ISBN;
		private System.Windows.Forms.ColumnHeader book_title;
		private System.Windows.Forms.ColumnHeader book_count;
		private System.Windows.Forms.ColumnHeader book_basic_price;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox RecordingID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label MemberDiscount;
		private System.Windows.Forms.Label MemberName;
		private System.Windows.Forms.Label MemberId;
		private System.Windows.Forms.Label MemberLevel;
		private System.Windows.Forms.Label RecordingTotalPrice;
		private System.Windows.Forms.Label RecordingDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
	}
}