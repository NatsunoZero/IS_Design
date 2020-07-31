namespace Visualization
{
	partial class StoricRequire
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
			this.book_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.book_classification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ISBNtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
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
            this.book_basic_price,
            this.book_publisher,
            this.book_classification});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 145);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(897, 293);
			this.listView1.TabIndex = 20;
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
			// ISBNtextBox
			// 
			this.ISBNtextBox.Location = new System.Drawing.Point(61, 109);
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(129, 21);
			this.ISBNtextBox.TabIndex = 22;
			this.ISBNtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterGetISBN);
			this.ISBNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigital);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 21;
			this.label1.Text = "ISBN";
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(210, 109);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 23;
			this.ClearButton.Text = "清空";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(386, 58);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 19);
			this.label8.TabIndex = 58;
			this.label8.Text = "库存查询";
			// 
			// StoricRequire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 450);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ISBNtextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StoricRequire";
			this.Text = "StoricRequire";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader book_ISBN;
		private System.Windows.Forms.ColumnHeader book_title;
		private System.Windows.Forms.ColumnHeader book_count;
		private System.Windows.Forms.ColumnHeader book_basic_price;
		private System.Windows.Forms.ColumnHeader book_id;
		private System.Windows.Forms.TextBox ISBNtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.ColumnHeader book_publisher;
		private System.Windows.Forms.ColumnHeader book_classification;
		private System.Windows.Forms.Label label8;
	}
}