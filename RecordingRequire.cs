using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
	public partial class RecordingRequire : Form
	{
		public RecordingRequire()
		{
			InitializeComponent();
			RecordingDate.Text = "订单日期：" + DateTime.Now.ToString("yyyy-MM-dd");
		}
		private void OnlyCharacterDigital(object sender, KeyPressEventArgs e)
		{
			//如果输入的不是字母数字，也不是回车键、Backspace键，则取消该输入
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9]+$") && e.KeyChar != (char)13 && e.KeyChar != (char)8)
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
				if (!string.IsNullOrEmpty(RecordingID.Text))
				{
					MySQLHelper mySQLHelper = new MySQLHelper();
					MySqlDataReader mysqlDataReader;
					string customer_id;
					string total_price;
					string date;
					string sqlSuper = "select * from tb_sales_recordings_date where recording_id = '" + RecordingID.Text + "';"; // 查询SQL语句
					try
					{
						mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
						if (mysqlDataReader.HasRows)
						{
							listView1.Items.Clear();
							//Read方法使DataReader对象前进到下一条记录
							while (mysqlDataReader.Read())
							{
								customer_id = mysqlDataReader["customer_id"].ToString();
								total_price = mysqlDataReader["total_price"].ToString();
								date = mysqlDataReader["date"].ToString();

								MemberId.Text = "会员编号: " + customer_id;
								MemberName.Text = "用户信息：" + Qurey("customer_name", "tb_customer_list", "customer_member_id", customer_id);
								string level = Qurey("customer_member_level", "tb_customer_list", "customer_member_id", customer_id);
								MemberLevel.Text = "用户等级：" + level;
								string MemberDiscountPercent = Qurey("customer_discount", "tb_customer_membership_levels", "customer_memebership_level", level);
								MemberDiscount.Text = "用户折扣：" + MemberDiscountPercent;
								RecordingTotalPrice.Text = "订单总价：" + total_price + ".00";
								RecordingDate.Text = "订单日期：" + date;
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
					string book_id;
					string book_ISBN;
					string book_title;
					string book_count;
					string book_basic_price;
					sqlSuper = "select * from tb_sales_recordings where recording_id = '" + RecordingID.Text + "';"; // 查询SQL语句
					mySQLHelper = new MySQLHelper();
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
								book_ISBN = Qurey("book_ISBN", "tb_books_information", "book_id", book_id);
								book_title = Qurey("book_title", "tb_books_information", "book_id", book_id);
								book_count = mysqlDataReader["book_count"].ToString();
								book_basic_price = mysqlDataReader["selled_price"].ToString();
								index = listView1.Items.Count + 1; // 现在已经存在的行数
								ListViewItem i_item = new ListViewItem();
								//添加行的其他列内容
								i_item.SubItems.Add((index).ToString());
								i_item.SubItems.Add(book_id);
								i_item.SubItems.Add(book_ISBN); //ISBN
								i_item.SubItems.Add(book_title);
								i_item.SubItems.Add(book_count);
								i_item.SubItems.Add(book_basic_price);
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
				RecordingID.SelectAll();
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			MemberId.Text = "会员编号:NULL";
			MemberName.Text = "用户信息：无";
			MemberLevel.Text = "用户等级：无";
			MemberDiscount.Text = "用户折扣：无";
			RecordingTotalPrice.Text = "订单总价：0.00";
			RecordingDate.Text = "订单日期：" + DateTime.Now.ToString("yyyy-MM-dd");
			listView1.Items.Clear();
			RecordingID.Focus();
		}
	}
}
