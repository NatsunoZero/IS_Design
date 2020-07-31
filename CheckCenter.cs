using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Visualization
{
	public partial class CheckCenter : Form
	{
		private double totalPrice = 0;
		CustomerScreen customerScreen;
		private string MemberID { get; set; } = "NULL";
		private double MemberDiscountPercent { get; set; } = 1.0;
		public CheckCenter()
		{
			InitializeComponent();
			if (!CheckFormIsOpen("CustomerScreen"))
			{
				customerScreen = new CustomerScreen(listView1);
				customerScreen.Show();
			}
			else
			{
				Application.OpenForms["CustomerScreen"].Show();
			}
			
		}
		private void FillViewList(string ISBN, string bookName, int count, double price)
		{
			int index = listView1.Items.Count + 1; // 现在已经存在的行数
			for (int i = 0; i < index - 1; i++)
			{
				if (ISBN == listView1.Items[i].SubItems[2].Text)
				{
					listView1.Items[i].SubItems[4].Text = (int.Parse(listView1.Items[i].SubItems[4].Text) + 1).ToString();
					listView1.Items[i].SubItems[6].Text = (int.Parse(listView1.Items[i].SubItems[4].Text) * double.Parse(listView1.Items[i].SubItems[5].Text)).ToString();

					totalPrice += price;
					ReflashData();

					return;
				}
			}
			totalPrice += price;
			TotalPrice.Text = "合计：" + totalPrice.ToString();
			ListViewItem i_item = new ListViewItem();
			//添加行的其他列内容
			i_item.SubItems.Add((index).ToString());  
			i_item.SubItems.Add(ISBN);
			i_item.SubItems.Add(bookName);
			i_item.SubItems.Add(count.ToString());
			i_item.SubItems.Add(price.ToString());
			i_item.SubItems.Add((count * price).ToString());
			listView1.Items.Add(i_item);    // 添加整行进入listview
			customerScreen.Reflash(totalPrice);
		}
		private void ReflashData()
		{
			customerScreen.Reflash(totalPrice);
			discountTotal.Text = "优惠：" + ((1 - MemberDiscountPercent) * totalPrice).ToString();
			TotalPrice.Text = "合计：" + (MemberDiscountPercent * totalPrice).ToString();
		}
		private void EnterGetISBN(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (!string.IsNullOrEmpty(ISBNtextBox.Text))
				{
					string title = Qurey("book_title", "tb_books_information", "book_ISBN", ISBNtextBox.Text);
					if (!String.IsNullOrEmpty(title))
					{
						string book_id = Qurey("book_id", "tb_books_information", "book_ISBN", ISBNtextBox.Text);
						string priceStr = Qurey("book_selling_price", "tb_book_stock_recording", "book_id", book_id);
						if (String.IsNullOrEmpty(priceStr)) priceStr = Qurey("book_basic_price", "tb_books_information", "book_id", book_id);
						double price = Convert.ToDouble(priceStr);
						FillViewList(ISBNtextBox.Text, title, 1, price);
					}
					else
					{
						MessageBox.Show("ISBN号错误或不存在，请重试！");
					}
				}
				else
				{
					MessageBox.Show("请输入内容");
				}
				ISBNtextBox.SelectAll();
			}
		}
		private void EnterGetMember(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode) // 回车键被按下查询ISBN
			{
				if (8 != MembertextBox.TextLength) MessageBox.Show("请输入正确的会员编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					if (!string.IsNullOrEmpty(MembertextBox.Text))
					{
						MySQLHelper mySQLHelper = new MySQLHelper();
						MySqlDataReader mysqlDataReader;
						string sqlSuper = "select * from tb_customer_list where customer_member_id = '" + MembertextBox.Text + "';"; // 查询SQL语句
						try
						{
							mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询语句
							if (mysqlDataReader.HasRows)
							{
								//Read方法使DataReader对象前进到下一条记录
								while (mysqlDataReader.Read())
								{
									MemberID = MembertextBox.Text;
									MemberId.Text = "会员编号: " + MemberID;
									MembertextBox.Visible = false;
									MemberName.Text = "用户信息：" + mysqlDataReader["customer_name"].ToString();
									MemberLevel.Text = "用户等级：" + mysqlDataReader["customer_member_level"].ToString();
									MemberDiscountPercent = double.Parse(Qurey("customer_discount", "tb_customer_membership_levels", "customer_memebership_level", mysqlDataReader["customer_member_level"].ToString()));
									MemberDiscount.Text = "用户折扣：" +	MemberDiscountPercent;
								}
							}
							else
							{
								MessageBox.Show("会员信息不存在，请重试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				}
				MembertextBox.SelectAll();
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
		private void OnlyDigital(object sender, KeyPressEventArgs e)
		{
			//如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
			if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
		private void OnlyCharacterDigital(object sender, KeyPressEventArgs e)
		{
			//如果输入的不是字母数字，也不是回车键、Backspace键，则取消该输入
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9]+$") && e.KeyChar != (char)13 && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MembertextBox.Visible = true;
		}
		public TextBox InputMemberTextBox
		{
			get { return MembertextBox; }
			set { MembertextBox = value; }
		}
		public TextBox ISBN
		{
			get { return ISBNtextBox; }
			set { ISBNtextBox = value; }
		}
		public void SendInputReceipter(string keys)
		{
			SendKeys.Send(keys);
		}
		public void ArrowControl(bool up)
		{
			listView1.Focus();
			SendKeys.Send(up ? "{UP}" : "{DOWN}");
		}
		public void DeleteControl()
		{
			SendKeys.Send("{BACKSPACE}");
		}
		public void EnterControl()
		{
			SendKeys.Send("{ENTER}");
		}
		public void QueryPrice()
		{
			string ISBN = Interaction.InputBox("请输入要查询的ISBN号", "价格查询", "", -1, -1);   //int型为弹出框坐标,str为返回的输入参数
			if (!String.IsNullOrEmpty(ISBN))
			{
				string book_id = Qurey("book_id", "tb_books_information", "book_ISBN", ISBN);
				string priceStr = Qurey("book_selling_price", "tb_book_stock_recording", "book_id", book_id);
				if (String.IsNullOrEmpty(priceStr)) priceStr = Qurey("book_basic_price", "tb_books_information", "book_id", book_id);
				if (!String.IsNullOrEmpty(priceStr)) MessageBox.Show("价格是：" + priceStr, "结果");
			}
		}
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0)
			{
				CountControlPanel.Visible = false;
				return; 
			}
			else
			{
				CountControlPanel.Visible = true;
				CountShow.Text = listView1.SelectedItems[0].SubItems[4].Text; // 显示数量
			}
			ReflashData();
		}
		public void GetPrice()
		{
			if (listView1.Items.Count > 0)
			{ 
				if (DialogResult.Yes == MessageBox.Show("是否确认结账？", "询问", MessageBoxButtons.YesNo))
				{
					string recording_id = Random.GetRandomID(); // 动态生成本次购物ID
																//MessageBox.Show(recording_id);
					string ISBN;
					int index = listView1.Items.Count + 1; // 现在已经存在的行数
					string book_id;
					decimal selled_price;
					int book_count;
					for (int i = 0; i < index - 1; i++)
					{
						ISBN = listView1.Items[i].SubItems[2].Text;
						book_id = Qurey("book_id", "tb_books_information", "book_ISBN", ISBN);
						book_count = int.Parse(listView1.Items[i].SubItems[4].Text);
						selled_price = decimal.Parse(listView1.Items[i].SubItems[5].Text) * (decimal)(1 - MemberDiscountPercent);
						InsertSInfo("tb_sales_recordings", recording_id, book_id, selled_price.ToString(), book_count.ToString());

					}

					if(InsertSInfo("tb_sales_recordings_date", recording_id, MemberID, totalPrice.ToString(), DateTime.Now.ToString("yyyy-MM-dd")))
					{
						MessageBox.Show("结账成功");
					}
					// TO DO LIST;
					listView1.Items.Clear();
					customerScreen.Reflash("欢迎光临");
					totalPrice = 0;
					MemberDiscountPercent = 1;
					discountTotal.Text = "优惠：0";
					TotalPrice.Text = "合计：0";
					MemberId.Text = "会员编号: NULL";
					MemberName.Text = "用户信息：无";
					MemberLevel.Text = "用户等级：无";
					MemberDiscount.Text = "用户折扣：无";
				}
			}
			else
			{
				MessageBox.Show("没有商品，无法结账。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

		private void SubButton_Click(object sender, EventArgs e)
		{
			if (int.Parse(listView1.SelectedItems[0].SubItems[4].Text) > 1)
			{ 
				listView1.SelectedItems[0].SubItems[4].Text = (int.Parse(listView1.SelectedItems[0].SubItems[4].Text) - 1).ToString(); 
				CountShow.Text = listView1.SelectedItems[0].SubItems[4].Text; // 显示数量
				totalPrice -= double.Parse(listView1.SelectedItems[0].SubItems[5].Text);
			}
			else
			{
				if (DialogResult.Yes == MessageBox.Show("是否要删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
				{
					totalPrice -= double.Parse(listView1.SelectedItems[0].SubItems[5].Text);
					DeleteButton_Click(sender, e);
				}
			}
			ReflashData();
		}

		private void PlusButton_Click(object sender, EventArgs e)
		{
			listView1.SelectedItems[0].SubItems[4].Text = (int.Parse(listView1.SelectedItems[0].SubItems[4].Text) + 1).ToString();
			totalPrice += double.Parse(listView1.SelectedItems[0].SubItems[5].Text);
			CountShow.Text = listView1.SelectedItems[0].SubItems[4].Text;
			ReflashData();
		}
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			listView1.Items.Remove(listView1.SelectedItems[0]);
			ReflashData();
		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			PrintService printService = new PrintService(listView1);
			printService.Print();
		}

		private void CountShow_KeyDown(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode)
			{
				int tmpCount = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
				int nowCount = int.Parse(CountShow.Text);
				int difference = nowCount - tmpCount;
				if (difference >= 0)
				{
					listView1.SelectedItems[0].SubItems[4].Text = nowCount.ToString();
					totalPrice += double.Parse(listView1.SelectedItems[0].SubItems[5].Text) * difference;
					ReflashData();
					listView1.SelectedItems[0].SubItems[6].Text = (int.Parse(listView1.SelectedItems[0].SubItems[4].Text) * double.Parse(listView1.SelectedItems[0].SubItems[5].Text)).ToString();
				}
				else
				{
					if (nowCount > 0)
					{
						listView1.SelectedItems[0].SubItems[4].Text = nowCount.ToString();
						totalPrice -= double.Parse(listView1.SelectedItems[0].SubItems[5].Text) * (-difference);
						ReflashData();
						listView1.SelectedItems[0].SubItems[6].Text = (int.Parse(listView1.SelectedItems[0].SubItems[4].Text) * double.Parse(listView1.SelectedItems[0].SubItems[5].Text)).ToString();
					}
					else
					{
						if (DialogResult.Yes == MessageBox.Show("是否要删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
						{
							totalPrice -= double.Parse(listView1.SelectedItems[0].SubItems[5].Text);
							DeleteButton_Click(sender, e);
						}
					}
				}
			}
		}

		private bool CheckFormIsOpen(string asFormName)
		{
			bool bResult = false;
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.Name == asFormName)
				{
					bResult = true;
					break;
				}
			}
			return bResult;
		}
	}
}
