namespace Visualization
{
	partial class BookStockManage
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
			this.ClearButton = new System.Windows.Forms.Button();
			this.ISBNtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_basic_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_classification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BookIDtextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bookCountTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PricetextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.RewriteButton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(770, 39);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 27;
			this.ClearButton.Text = "清空";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ISBNtextBox
			// 
			this.ISBNtextBox.Location = new System.Drawing.Point(70, 56);
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(129, 21);
			this.ISBNtextBox.TabIndex = 26;
			this.ISBNtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetISBN);
			this.ISBNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 25;
			this.label1.Text = "ISBN";
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
            this.book_basic_price,
            this.book_publisher,
            this.book_classification});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(9, 37);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(897, 293);
			this.listView1.TabIndex = 24;
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
			// book_publisher
			// 
			this.book_publisher.Text = "出版社";
			this.book_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_publisher.Width = 85;
			// 
			// book_classification
			// 
			this.book_classification.Text = "分类";
			this.book_classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_classification.Width = 112;
			// 
			// BookIDtextBox
			// 
			this.BookIDtextBox.Location = new System.Drawing.Point(70, 29);
			this.BookIDtextBox.Name = "BookIDtextBox";
			this.BookIDtextBox.Size = new System.Drawing.Size(129, 21);
			this.BookIDtextBox.TabIndex = 29;
			this.BookIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetBookID);
			this.BookIDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 28;
			this.label2.Text = "书籍编号";
			// 
			// bookCountTextBox
			// 
			this.bookCountTextBox.Location = new System.Drawing.Point(300, 41);
			this.bookCountTextBox.Name = "bookCountTextBox";
			this.bookCountTextBox.Size = new System.Drawing.Size(129, 21);
			this.bookCountTextBox.TabIndex = 31;
			this.bookCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 30;
			this.label4.Text = "数量";
			// 
			// PricetextBox
			// 
			this.PricetextBox.Location = new System.Drawing.Point(504, 41);
			this.PricetextBox.Name = "PricetextBox";
			this.PricetextBox.Size = new System.Drawing.Size(129, 21);
			this.PricetextBox.TabIndex = 35;
			this.PricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricetextBox_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(469, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 34;
			this.label5.Text = "售价";
			// 
			// RewriteButton
			// 
			this.RewriteButton.Location = new System.Drawing.Point(673, 39);
			this.RewriteButton.Name = "RewriteButton";
			this.RewriteButton.Size = new System.Drawing.Size(75, 23);
			this.RewriteButton.TabIndex = 36;
			this.RewriteButton.Text = "更新";
			this.RewriteButton.UseVisualStyleBackColor = true;
			this.RewriteButton.Click += new System.EventHandler(this.RewriteButton_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(405, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 19);
			this.label8.TabIndex = 57;
			this.label8.Text = "库存管理";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ClearButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.RewriteButton);
			this.groupBox1.Controls.Add(this.ISBNtextBox);
			this.groupBox1.Controls.Add(this.PricetextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.BookIDtextBox);
			this.groupBox1.Controls.Add(this.bookCountTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(21, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(851, 100);
			this.groupBox1.TabIndex = 58;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "库存详细信息";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView1);
			this.groupBox2.Location = new System.Drawing.Point(12, 180);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(909, 336);
			this.groupBox2.TabIndex = 59;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "库存信息";
			// 
			// BookStockManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 528);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BookStockManage";
			this.Text = "BookInfoManage";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox ISBNtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader book_id;
		private System.Windows.Forms.ColumnHeader book_ISBN;
		private System.Windows.Forms.ColumnHeader book_title;
		private System.Windows.Forms.ColumnHeader book_count;
		private System.Windows.Forms.ColumnHeader book_basic_price;
		private System.Windows.Forms.ColumnHeader book_publisher;
		private System.Windows.Forms.ColumnHeader book_classification;
		private System.Windows.Forms.TextBox BookIDtextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox bookCountTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox PricetextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button RewriteButton;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
	}
}