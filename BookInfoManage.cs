using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Visualization
{
	public partial class BookInfoManage : Form
	{
		public BookInfoManage()
		{
			InitializeComponent();
			Init();
		}
		private void OnlyDigital(object sender, KeyPressEventArgs e)
		{
			//如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
			if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
		private string Qurey(string columnName, string tableName, string keyword, string result)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sqlSuper = "select " + @columnName + " from " + @tableName + " where " + @keyword + " = '" + @result + "';"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			string resultList = null;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
				if (mysqlDataReader.HasRows)
				{
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						resultList = mysqlDataReader[@columnName].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Message);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
			return resultList;
		}
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 0)
			{
				BookIDtextBox.Text = listView1.SelectedItems[0].SubItems[2].Text; // 显示书籍编号
				ISBNtextBox.Text = listView1.SelectedItems[0].SubItems[3].Text; // 显示ISBN
				TitletextBox.Text = listView1.SelectedItems[0].SubItems[4].Text; // 显示题目
				PricetextBox.Text = listView1.SelectedItems[0].SubItems[5].Text; // 显示价格
				PublishertextBox.Text = listView1.SelectedItems[0].SubItems[6].Text; // 显示出版社
				ClassifytextBox.Text = listView1.SelectedItems[0].SubItems[7].Text; // 显示分类
				BookIDtextBox.ReadOnly = true;
				ISBNtextBox.ReadOnly = true;
				button2.Enabled = button4.Enabled = button6.Enabled = false;
				button5.Enabled = button3.Enabled =  true;
			}
			else
			{
				BookIDtextBox.ReadOnly = false;
				ISBNtextBox.ReadOnly = false;
				button2.Enabled = button4.Enabled = button6.Enabled = true;
				button5.Enabled = button3.Enabled = false;
				Clear();
			}
		}

		private void EnterGetISBN(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (!string.IsNullOrEmpty(ISBNtextBox.Text))
				{
					QueryByISBN();
				}
				else
				{
					MessageBox.Show("请输入内容");
				}
				ISBNtextBox.SelectAll();
			}
		}
		private void QueryByISBN()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string book_id;
			string book_title;
			string book_basic_price;
			string book_publisher;
			string book_classification;
			string book_inventory;
			string sqlSuper = "select * from tb_books_information where book_ISBN = '" + ISBNtextBox.Text + "';"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			int index;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
				if (mysqlDataReader.HasRows)
				{
					listView1.Items.Clear();
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						book_id = mysqlDataReader["book_id"].ToString();
						book_title = mysqlDataReader["book_title"].ToString();
						book_publisher = mysqlDataReader["book_publisher"].ToString();
						book_inventory = Qurey("book_inventory", "tb_book_stock_recording", "book_id", book_id); //book_inventory
						book_classification = mysqlDataReader["book_classification"].ToString().Replace(".", ">");
						if (!string.IsNullOrEmpty(book_inventory))
						{
							book_basic_price = Qurey("book_selling_price", "tb_book_stock_recording", "book_id", book_id); //book_inventory
						}
						else
						{
							book_basic_price = mysqlDataReader["book_basic_price"].ToString();
						}
						index = listView1.Items.Count + 1; // 现在已经存在的行数
						ListViewItem i_item = new ListViewItem();
						//添加行的其他列内容
						i_item.SubItems.Add((index).ToString());
						i_item.SubItems.Add(book_id);
						i_item.SubItems.Add(ISBNtextBox.Text); //ISBN
						i_item.SubItems.Add(book_title);
						i_item.SubItems.Add(book_basic_price);
						i_item.SubItems.Add(book_publisher);
						i_item.SubItems.Add(book_classification);
						listView1.Items.Add(i_item);    // 添加整行进入listview
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Message);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
		}
		private void QueryByID()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string book_ISBN;
			string book_title;
			string book_basic_price;
			string book_publisher;
			string book_classification;
			string book_inventory;
			string sqlSuper = "select * from tb_books_information where book_id = '" + BookIDtextBox.Text + "';"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			int index;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
				if (mysqlDataReader.HasRows)
				{
					listView1.Items.Clear();
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						book_ISBN = mysqlDataReader["book_ISBN"].ToString();
						book_title = mysqlDataReader["book_title"].ToString();
						book_publisher = mysqlDataReader["book_publisher"].ToString();
						book_classification = mysqlDataReader["book_classification"].ToString().Replace(".", ">");
						book_inventory = Qurey("book_inventory", "tb_book_stock_recording", "book_id", BookIDtextBox.Text); //book_inventory
						if (!string.IsNullOrEmpty(book_inventory))
						{
							book_basic_price = Qurey("book_selling_price", "tb_book_stock_recording", "book_id", BookIDtextBox.Text); //book_inventory
						}
						else
						{
							book_basic_price = mysqlDataReader["book_basic_price"].ToString();
						}
						index = listView1.Items.Count + 1; // 现在已经存在的行数
						ListViewItem i_item = new ListViewItem();
						//添加行的其他列内容
						i_item.SubItems.Add((index).ToString());
						i_item.SubItems.Add(BookIDtextBox.Text);
						i_item.SubItems.Add(book_ISBN); //ISBN
						i_item.SubItems.Add(book_title);
						i_item.SubItems.Add(book_basic_price);
						i_item.SubItems.Add(book_publisher);
						i_item.SubItems.Add(book_classification);
						listView1.Items.Add(i_item);    // 添加整行进入listview
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Message);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
		}
		private void EnterGetBookID(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (!string.IsNullOrEmpty(BookIDtextBox.Text))
				{
					QueryByID();
				}
				else
				{
					MessageBox.Show("请输入内容");
				}
				ISBNtextBox.SelectAll();
			}
		}
		private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '-')
			{
				if ((sender as TextBox).Text != "")
				{
					e.Handled = true;
				}
			}
			//第1位小数点不可
			if (e.KeyChar == '.' && ((TextBox)sender).Text == "")
			{
				e.Handled = true;
			}
			//小数点只能1次
			if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') != -1)
			{
				e.Handled = true;
			}
			//小数点（最大到2位）   
			if (e.KeyChar != '\b' && (((TextBox)sender).SelectionStart) > ((TextBox)sender).Text.LastIndexOf('.') + 2 && ((TextBox)sender).Text.IndexOf(".") >= 0)
				e.Handled = true;
			//光标在小数点右侧时候判断  
			if (e.KeyChar != '\b' && ((TextBox)sender).SelectionStart >= ((TextBox)sender).Text.LastIndexOf('.') && ((TextBox)sender).Text.IndexOf(".") >= 0)
			{
				if (((TextBox)sender).SelectionStart == (((TextBox)sender).Text.LastIndexOf('.')) + 1)
				{
					if (((TextBox)sender).Text.Length.ToString() == (((TextBox)sender).Text.IndexOf(".") + 3).ToString())
						e.Handled = true;
				}
				if (((TextBox)sender).SelectionStart == (((TextBox)sender).Text.LastIndexOf('.')) + 2)
				{
					if ((((TextBox)sender).Text.Length - 3).ToString() == ((TextBox)sender).Text.IndexOf(".").ToString()) e.Handled = true;
				}
			}
			//第1位是0，第2位必须是小数点
			if (e.KeyChar != (char)('.') && e.KeyChar != 8 && ((TextBox)sender).Text == "0")
			{
				e.Handled = true;
			}
		}

		private void Clear()
		{
			string NULL = null;
			BookIDtextBox.Text = NULL;
			ISBNtextBox.Text = NULL;
			TitletextBox.Text= NULL;
			PricetextBox.Text= NULL;
			PublishertextBox.Text = NULL;
			ClassifytextBox.Text = NULL;
		}
		private void ClearButton_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(BookIDtextBox.Text)) QueryByID();
			else if (string.IsNullOrEmpty(ISBNtextBox.Text)) QueryByISBN();
			else
			{
				MessageBox.Show("您必须输入ISBN或者图书编号才可以查询");
				BookIDtextBox.Focus();
			}
		}
		private bool InsertSInfo(string tb_name, params string[] list)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			MySqlDataReader mysqlDataReader;
			string sql = "Insert " + tb_name + " Values ('";
			for (int i = 0; i < list.Length - 1; i++)
			{
				sql += list[i] + "','";
			}
			sql += list[list.Length - 1] + "')"; // 插入语句
			bool flag = false;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sql);
				flag = true;
			}
			catch (Exception e)
			{
				MessageBox.Show("插入错误，编号重复，请重新输入。\n 错误原因：" + e.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
			return flag;
		}
		private bool UpdateInfo(string book_title, string book_ISBN, string book_selling_price,string book_publisher,string book_classification, string book_id)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			MySqlDataReader mysqlDataReader;

			string sql = "Update tb_books_information set book_title = '" + @book_title 
													+ "', book_ISBN = '" + @book_ISBN
													+ "', book_selling_price = '" + @book_selling_price
													+ "', book_publisher = '" + @book_publisher
													+ "', book_classification = '" + @book_classification
													+ "' where book_id = '" + @book_id + "';"; // 查询SQL语句
			bool flag = false;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sql);
				flag = true;
			}
			catch (Exception e)
			{
				MessageBox.Show("插入错误，编号重复，请重新输入。\n 错误原因：" + e.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
			return flag;
		}

		private bool HasEmpty(params TextBox[] list)
		{
			foreach (var item in list)
			{
				if (string.IsNullOrEmpty(item.Text)) return true;
			}
			return false;
		}
		private void button2_Click(object sender, EventArgs e) // 插入
		{
			if (!HasEmpty(BookIDtextBox, ISBNtextBox, TitletextBox, PricetextBox, PublishertextBox, ClassifytextBox))
				InsertSInfo("tb_books_information", BookIDtextBox.Text, TitletextBox.Text, ISBNtextBox.Text, PricetextBox.Text, PublishertextBox.Text, ClassifytextBox.Text);
			else MessageBox.Show("请将信息补全再尝试插入");
		}
		public bool DeleteSInfo(string tb_name,string whereKey, string whereCondition)
		{
			bool flag = true;
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sql = "DELETE FROM " + @tb_name + " where " + @whereKey + " = '" + @whereCondition + "';"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sql);


			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, e.Message);
				flag = false;
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
			return flag;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
			{
				DeleteSInfo("tb_books_information", "book_id", BookIDtextBox.Text);
			}
			listView1.Items.Remove(listView1.SelectedItems[0]);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
				UpdateInfo(TitletextBox.Text, ISBNtextBox.Text, PricetextBox.Text, PublishertextBox.Text, ClassifytextBox.Text, BookIDtextBox.Text);
			else MessageBox.Show("您必须选择其中的一行才能进行修改");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Clear();
			ISBNtextBox.Focus();
		}
		private void Init()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sqlSuper = "select * from tb_books_information;"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			int index;
			string book_id;
			string book_ISBN;
			string book_title;
			string book_basic_price;
			string book_publisher;
			string book_classification;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
				if (mysqlDataReader.HasRows)
				{
					listView1.Items.Clear();
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						book_id = mysqlDataReader["book_id"].ToString();
						book_title = mysqlDataReader["book_title"].ToString();
						book_ISBN = mysqlDataReader["book_ISBN"].ToString();
						book_basic_price = mysqlDataReader["book_basic_price"].ToString();
						book_publisher = mysqlDataReader["book_publisher"].ToString();
						book_classification = mysqlDataReader["book_classification"].ToString().Replace(".", ">");
						
						index = listView1.Items.Count + 1; // 现在已经存在的行数
						ListViewItem i_item = new ListViewItem();
						//添加行的其他列内容
						i_item.SubItems.Add((index).ToString());
						i_item.SubItems.Add(book_id);
						i_item.SubItems.Add(book_ISBN); //ISBN
						i_item.SubItems.Add(book_title);
						i_item.SubItems.Add(book_basic_price);
						i_item.SubItems.Add(book_publisher);
						i_item.SubItems.Add(book_classification);
						listView1.Items.Add(i_item);    // 添加整行进入listview
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Message);
			}
			finally
			{
				mySQLHelper.CloseDB();
			}
		}

	}
}
