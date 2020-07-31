using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
	public partial class BookStockManage : Form
	{
		public BookStockManage()
		{
			InitializeComponent();
			Init();
		}
		public bool InsertSInfo(string tb_name, params string[] list)
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
		public bool UpdateInfo(string book_inventory,string book_selling_price, string book_id)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			MySqlDataReader mysqlDataReader;

			string sql = "Update tb_book_stock_recording set book_inventory = '" + @book_inventory + "', book_selling_price = '" + @book_selling_price  + "' where book_id = '" + @book_id + "';"; // 查询SQL语句
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

		private void EnterGetISBN(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (!string.IsNullOrEmpty(ISBNtextBox.Text))
				{
					MySQLHelper mySQLHelper = new MySQLHelper();
					string book_id;
					string book_title;
					string book_basic_price;
					string book_publisher;
					string book_classification;
					string book_inventory;
					//= Qurey("book_id", "tb_books_information", "book_ISBN", ISBNtextBox.Text); // book_id
					//string book_inventory = Qurey("book_inventory", "tb_book_stock_recording", "book_id", book_id); //book_inventory
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
								book_classification = mysqlDataReader["book_classification"].ToString().Replace(".", ">");
								book_inventory = Qurey("book_inventory", "tb_book_stock_recording", "book_id", book_id); //book_inventory
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
								i_item.SubItems.Add((string.IsNullOrEmpty(book_inventory)) ? "不在库" : book_inventory);
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
				else
				{
					MessageBox.Show("请输入内容");
				}
				ISBNtextBox.SelectAll();
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
						i_item.SubItems.Add((string.IsNullOrEmpty(book_inventory)) ? "不在库" : book_inventory);
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
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 0)
			{
				BookIDtextBox.Text = listView1.SelectedItems[0].SubItems[2].Text; // 显示书籍编号
				ISBNtextBox.Text = listView1.SelectedItems[0].SubItems[3].Text; // 显示ISBN
				bookCountTextBox.Text = listView1.SelectedItems[0].SubItems[5].Text; // 显示数量
				PricetextBox.Text = listView1.SelectedItems[0].SubItems[6].Text; // 显示价格
				BookIDtextBox.ReadOnly = true;
				ISBNtextBox.ReadOnly = true;
			}
			else
			{
				BookIDtextBox.ReadOnly = false;
				ISBNtextBox.ReadOnly = false;
				Clear();
			}
		}
		private void Clear()
		{
			string NULL = null;
			PricetextBox.Text = NULL;
			bookCountTextBox.Text = NULL;
			BookIDtextBox.Text = NULL;
			ISBNtextBox.Text = NULL;
		}
		private void ClearButton_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			Clear();
		}

		private void RewriteButton_Click(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count != 0) // 有被选中项，可以修改或写入
			{
				// TO DO LIST 按照内容修改或写入新数据，记得修改viewlist的值。
				if("不在库" == listView1.SelectedItems[0].SubItems[5].Text)
				{
					InsertSInfo("tb_book_stock_recording", BookIDtextBox.Text, bookCountTextBox.Text, PricetextBox.Text);
				}
				else
				{
					UpdateInfo(bookCountTextBox.Text, PricetextBox.Text, BookIDtextBox.Text);
				}
				listView1.SelectedItems[0].SubItems[5].Text = bookCountTextBox.Text; // 显示数量
				listView1.SelectedItems[0].SubItems[6].Text = PricetextBox.Text; // 显示价格

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
		private void Init()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string book_id;
			string book_ISBN;
			string book_title;
			string book_basic_price;
			string book_publisher;
			string book_classification;
			string book_inventory;
			string sqlSuper = "select * from tb_books_information;"; // 查询SQL语句
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
						i_item.SubItems.Add(book_id);
						i_item.SubItems.Add(book_ISBN); //ISBN
						i_item.SubItems.Add(book_title);
						i_item.SubItems.Add((string.IsNullOrEmpty(book_inventory)) ? "不在库" : book_inventory);
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
