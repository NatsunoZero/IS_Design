namespace Visualization
{
	partial class BookInfoManage
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
			this.BookIDtextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.book_classification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_basic_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PricetextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ISBNtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TitletextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PublishertextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ClassifytextBox = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BookIDtextBox
			// 
			this.BookIDtextBox.Location = new System.Drawing.Point(72, 20);
			this.BookIDtextBox.Name = "BookIDtextBox";
			this.BookIDtextBox.Size = new System.Drawing.Size(129, 21);
			this.BookIDtextBox.TabIndex = 42;
			this.BookIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetBookID);
			this.BookIDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 41;
			this.label2.Text = "书籍编号";
			// 
			// book_classification
			// 
			this.book_classification.Text = "分类";
			this.book_classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_classification.Width = 131;
			// 
			// book_publisher
			// 
			this.book_publisher.Text = "出版社";
			this.book_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_publisher.Width = 106;
			// 
			// book_basic_price
			// 
			this.book_basic_price.Text = "基准价";
			this.book_basic_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_basic_price.Width = 86;
			// 
			// book_title
			// 
			this.book_title.Text = "书名";
			this.book_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_title.Width = 350;
			// 
			// book_ISBN
			// 
			this.book_ISBN.Text = "国际图书编号";
			this.book_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_ISBN.Width = 98;
			// 
			// book_id
			// 
			this.book_id.Text = "书籍编号";
			this.book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.book_id.Width = 80;
			// 
			// ID
			// 
			this.ID.Text = "编号";
			this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ID.Width = 41;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// PricetextBox
			// 
			this.PricetextBox.Location = new System.Drawing.Point(265, 20);
			this.PricetextBox.Name = "PricetextBox";
			this.PricetextBox.Size = new System.Drawing.Size(129, 21);
			this.PricetextBox.TabIndex = 46;
			this.PricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricetextBox_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(218, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 45;
			this.label5.Text = "基准价";
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(822, 20);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 40;
			this.ClearButton.Text = "清空";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ISBNtextBox
			// 
			this.ISBNtextBox.Location = new System.Drawing.Point(72, 57);
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(129, 21);
			this.ISBNtextBox.TabIndex = 39;
			this.ISBNtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetISBN);
			this.ISBNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 38;
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
            this.book_basic_price,
            this.book_publisher,
            this.book_classification});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(6, 53);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(897, 293);
			this.listView1.TabIndex = 37;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PublishertextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.ClassifytextBox);
			this.groupBox1.Controls.Add(this.TitletextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.BookIDtextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ISBNtextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.PricetextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(20, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(889, 100);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "书籍基本信息";
			// 
			// TitletextBox
			// 
			this.TitletextBox.Location = new System.Drawing.Point(265, 57);
			this.TitletextBox.Name = "TitletextBox";
			this.TitletextBox.Size = new System.Drawing.Size(528, 21);
			this.TitletextBox.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(217, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 47;
			this.label3.Text = "题目";
			// 
			// PublishertextBox
			// 
			this.PublishertextBox.Location = new System.Drawing.Point(458, 20);
			this.PublishertextBox.Name = "PublishertextBox";
			this.PublishertextBox.Size = new System.Drawing.Size(129, 21);
			this.PublishertextBox.TabIndex = 50;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(411, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 12);
			this.label6.TabIndex = 49;
			this.label6.Text = "出版社";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(604, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 51;
			this.label7.Text = "分类";
			// 
			// ClassifytextBox
			// 
			this.ClassifytextBox.Location = new System.Drawing.Point(651, 20);
			this.ClassifytextBox.Name = "ClassifytextBox";
			this.ClassifytextBox.Size = new System.Drawing.Size(129, 21);
			this.ClassifytextBox.TabIndex = 52;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(834, 142);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 53;
			this.button6.Text = "重写";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(753, 142);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 52;
			this.button5.Text = "修改";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(671, 142);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 51;
			this.button4.Text = "查询";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(587, 142);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 50;
			this.button3.Text = "删除";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(505, 142);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 49;
			this.button2.Text = "添加";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView1);
			this.groupBox2.Controls.Add(this.ClearButton);
			this.groupBox2.Location = new System.Drawing.Point(12, 171);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(909, 352);
			this.groupBox2.TabIndex = 54;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "书籍信息";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(394, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 19);
			this.label8.TabIndex = 55;
			this.label8.Text = "书籍信息管理";
			// 
			// BookInfoManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 535);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BookInfoManage";
			this.Text = "BookInfoManage";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox BookIDtextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader book_classification;
		private System.Windows.Forms.ColumnHeader book_publisher;
		private System.Windows.Forms.ColumnHeader book_basic_price;
		private System.Windows.Forms.ColumnHeader book_title;
		private System.Windows.Forms.ColumnHeader book_ISBN;
		private System.Windows.Forms.ColumnHeader book_id;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox PricetextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox ISBNtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox PublishertextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ClassifytextBox;
		private System.Windows.Forms.TextBox TitletextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
	}
}