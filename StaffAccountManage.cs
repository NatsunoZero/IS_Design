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
	public partial class StaffAccountManage : Form
	{
		public StaffAccountManage()
		{
			InitializeComponent();
			Init();
		}
		private void QueryByAccount()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string password;
			string sqlSuper = "select * from tb_staff where username = '" + AccounttextBox.Text + "';"; // 查询SQL语句
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
						password = mysqlDataReader["password"].ToString();
						index = listView1.Items.Count + 1; // 现在已经存在的行数
						ListViewItem i_item = new ListViewItem();
						//添加行的其他列内容
						i_item.SubItems.Add((index).ToString());
						i_item.SubItems.Add(AccounttextBox.Text);
						i_item.SubItems.Add(password); //pw
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
		private void EnterGetAccount(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (!string.IsNullOrEmpty(AccounttextBox.Text))
				{
					QueryByAccount();
				}
				else
				{
					MessageBox.Show("请输入内容");
				}
				AccounttextBox.SelectAll();
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
				AccounttextBox.Text = listView1.SelectedItems[0].SubItems[2].Text; // 显示书籍编号
				PasswordtextBox.Text = listView1.SelectedItems[0].SubItems[3].Text; // 显示ISBN
				button2.Enabled = button4.Enabled = button6.Enabled = false;
				button5.Enabled = button3.Enabled = true;
			}
			else
			{
				button2.Enabled = button4.Enabled = button6.Enabled = true;
				button5.Enabled = button3.Enabled = false;
				Clear();
			}
		}
		private void Clear()
		{
			string NULL = null;
			AccounttextBox.Text = NULL;
			PasswordtextBox.Text = NULL;
		}

		private void button2_Click(object sender, EventArgs e) // 插入
		{
			if (!HasEmpty(AccounttextBox, PasswordtextBox))
				InsertSInfo("tb_staff", AccounttextBox.Text, PasswordtextBox.Text);
			else MessageBox.Show("请将信息补全再尝试插入");
		}
		private bool HasEmpty(params TextBox[] list)
		{
			foreach (var item in list)
			{
				if (string.IsNullOrEmpty(item.Text)) return true;
			}
			return false;
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

		private void button3_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
			{
				DeleteSInfo("tb_staff", "username", AccounttextBox.Text);
			}
			listView1.Items.Remove(listView1.SelectedItems[0]);
		}
		public bool DeleteSInfo(string tb_name, string whereKey, string whereCondition)
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

		private void button4_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(AccounttextBox.Text)) QueryByAccount();
			else
			{
				MessageBox.Show("您必须输入账户名才可以查询哦");
				AccounttextBox.Focus();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
				UpdateInfo(PasswordtextBox.Text, AccounttextBox.Text);
			else MessageBox.Show("您必须选择其中的一行才能进行修改");
		}
		private bool UpdateInfo(string password, string username)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			MySqlDataReader mysqlDataReader;

			string sql = "Update tb_staff set password = '" + @password
														+ "' where username = '" + @username + "';"; // 查询SQL语句
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

		private void button6_Click(object sender, EventArgs e)
		{
			Clear();
			AccounttextBox.Focus();
		}
		private void Init()
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sqlSuper = "select * from tb_staff;"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			int index;
			string account;
			string password;
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
				if (mysqlDataReader.HasRows)
				{
					listView1.Items.Clear();
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						account = mysqlDataReader["username"].ToString();
						password = mysqlDataReader["password"].ToString();
						index = listView1.Items.Count + 1; // 现在已经存在的行数
						ListViewItem i_item = new ListViewItem();
						//添加行的其他列内容
						i_item.SubItems.Add((index).ToString());
						i_item.SubItems.Add(account);
						i_item.SubItems.Add(password); //pw
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
