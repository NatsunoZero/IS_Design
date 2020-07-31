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
	public partial class StoricRequire : Form
	{
		public StoricRequire()
		{
			InitializeComponent();
			Init();
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
								i_item.SubItems.Add((string.IsNullOrEmpty(book_inventory))?"不在库":book_inventory);
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
		private void OnlyDigital(object sender, KeyPressEventArgs e)
		{
			//如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
			if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
		private void Init()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sqlSuper = "select * from tb_books_information;"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			int index;
			string book_id;
			string book_title;
			string book_basic_price;
			string book_publisher;
			string book_ISBN;
			string book_classification;
			string book_inventory;
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
		private void ClearButton_Click(object sender, EventArgs e)
		{
			Init();
		}
	}
}
