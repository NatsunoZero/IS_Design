using MemoryPassword;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Visualization
{
    public partial class Login : Form
    {
		bool flag = false;
		bool keyShiftFlag = false;
		List<User> users;   //声明一个用户的泛型集合
		public Login()
        {
            InitializeComponent();
        }
		private void LoginForm_Load(object sender, EventArgs e)
		{
			skinEngine1.SkinFile = Application.StartupPath + @"\WaveColor1.ssk";
			if (File.Exists("userInfo.exe"))
			{
				/*创建文件流对象 参数1:文件的(相对)路径也可以再另一个文件夹下如:User(文件夹)/userInfo.exe 
                                 参数2:指定操作系统打开文件的方式
                                 参数3:指定文件的访问类型(这里为只读)  */

				//为了安全在这里创建了一个userInfo.exe文件(用户信息),也可以命名为其他的文件格式的(可以任意)                     
				FileStream fs = new FileStream("userInfo.exe", FileMode.Open, FileAccess.Read); //使用第6个构造函数

				BinaryFormatter bf = new BinaryFormatter();  //创建一个序列化和反序列化类的对象
				users = (List<User>)bf.Deserialize(fs);  //调用反序列化方法，从文件userInfo.exe中读取对象信息

				for (int i = 0; i < users.Count; i++)//将集合中的用户登录ID读取到下拉框中
				{
					if (i == 0 && users[i].LoingPassword != "")  //如果第一个用户已经记住密码了。
					{
						chkMemoryPwd.Checked = true;
						textBox2.Text = users[i].LoingPassword;  //给密码框赋值
					}
					comboBox1.Items.Add(users[i].LoginName.ToString());
				}
				fs.Close();   //关闭文件流
				if (comboBox1.Items.Count != 0) comboBox1.SelectedIndex = 0;   //默认下拉框选中为第一项
				else {
					comboBox1.Text = "<请输入您的用户名>"; 
					comboBox1.Focus(); 
				}

			}
			else
			{
				users = new List<User>();
				comboBox1.Text = "<请输入您的用户名>";
				comboBox1.Focus();
			}
		}
		private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox1.Text == "<请输入您的用户名>")
            {
				ToolTip tt = new ToolTip
				{
					IsBalloon = true   //设置气泡对象的显示样式。如果false就是一个方块型的提示框
				};   //实例化一个气泡对象
				tt.SetToolTip(comboBox1, "请输入用户名！");  //设定气泡的内容及作用于哪个控件
                tt.Show("请输入用户名！", comboBox1);   //将气泡显示出来
                return;
            }
            else if (textBox2.Text == "")
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;   //如果false就是一个方块型的提示框
                tt.SetToolTip(textBox2, "请输入用户密码！");
                tt.Show("请输入用户密码！", textBox2);
                return;
            }
            //...................可以加密并(本地)记住密码了

            string loginName = comboBox1.Text.Trim();  //将下拉框的登录名先保存在变量中
            for (int i = 0; i < comboBox1.Items.Count; i++)  //遍历下拉框中的所有元素
            {
                if (comboBox1.Items[i].ToString() == loginName)
                {
                    comboBox1.Items.RemoveAt(i);  //如果当前登录用户在下拉列表中已经存在，则将其移除
                    break;
                }
            }

            for (int i = 0; i < users.Count; i++)    //遍历用户集合中的所有元素
            {
                if (users[i].LoginName == loginName)  //如果当前登录用户在用户集合中已经存在，则将其移除
                {
                    users.RemoveAt(i);
                    break;
                }
            }

            comboBox1.Items.Insert(0, loginName);  //每次都将最后一个登录的用户放插入到第一位
			if(!keyShiftFlag)
			{
				User user;
				if (chkMemoryPwd.Checked == true)    //如果用户要求要记住密码
				{
					string newPwd = MyEncrypt.EncryptDES(textBox2.Text.Trim());  //***********如果用户要求记住密码则对该密码进行加密***************
					user = new User(loginName, newPwd);  //将登录ID和密码一起插入到用户集合中
				}
				else
					user = new User(loginName, "");  //否则只插入一个用户名到用户集合中，密码设为空
				users.Insert(0, user);   //在用户集合中插入一个用户
				comboBox1.SelectedIndex = 0;   //让下拉框选中集合中的第一个
			}
        }
		//当窗体关闭之后
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
　　　　		//为了安全在这里创建了一个userInfo.exe文件(用户信息),也可以命名为其他的文件格式的(可以任意)
            FileStream fs = new FileStream("userInfo.exe", FileMode.Create, FileAccess.Write);  //创建一个文件流对象
            BinaryFormatter bf = new BinaryFormatter();  //创建一个序列化和反序列化对象
            bf.Serialize(fs, users);   //要先将User类先设为可以序列化(即在类的前面加[Serializable])。将用户集合信息写入到硬盘中
            fs.Close();   //关闭文件流
        }

        //当下拉框选择的项的值发生改变时
        private void cboLgoinName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (users[comboBox1.SelectedIndex].LoingPassword != "") //如果用户的密码不是为空时
            {
                //把用户ID所对应的密码赋给密码框(这时的数据还在用户集合中)
                textBox2.Text = users[comboBox1.SelectedIndex].LoingPassword.ToString();
                chkMemoryPwd.Checked = true;  
            }
            else
            {
                textBox2.Text = "";  //如果用户的密码本身就是空，那只能给空值给密码框了。
                chkMemoryPwd.Checked = false;
            }
        }
		private void button1_Click(object sender, EventArgs e)
		{
			btnLogin_Click(sender, e);
			flag = false;
			GlobalClass.user.strUsrId = comboBox1.Text;
			GlobalClass.user.strUsrName = textBox2.Text;
			if (textBox2.Text == Qurey(comboBox1.Text, textBox2.Text))
            {
				GlobalClass.user.isSuperAccount = keyShiftFlag;
				DialogResult = DialogResult.OK;
				Close();
			}
            else
            {
				comboBox1.Focus();
				if(!flag)MessageBox.Show("用户名或密码错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();

		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				textBox2.Focus();
			}
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1.Focus();
			}
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			textBox2.SelectAll();
		}

		private string Qurey(string username, string password)
		{
			MySQLHelper mySQLHelper = new MySQLHelper();
			string sqlSuper = "select password from "+ (keyShiftFlag ? "tb_supper_manager" : "tb_staff") + " where username = '" + @username + "';"; // 查询SQL语句
			MySqlDataReader mysqlDataReader;
			string gettedPassword = "This_is_the_no_password";
			try
			{
				mysqlDataReader = mySQLHelper.Query(sqlSuper); // 查询管理员
				if (mysqlDataReader.HasRows)
				{
					//Read方法使DataReader对象前进到下一条记录
					while (mysqlDataReader.Read())
					{
						gettedPassword = mysqlDataReader["password"].ToString();
					}
					GlobalClass.user.isSuperAccount = true;
				}
				else
				{
					MessageBox.Show((keyShiftFlag ? "管理员" : "员工") + "用户名不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					flag = true;
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


			return gettedPassword;
		}
		// 按下指定内容前往管理员界面
		private void Shift_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.Control && Keys.S == e.KeyCode) { keyShiftFlag = true; } 
		}
		private void Shift_KeyUP(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.Control && Keys.S == e.KeyCode) keyShiftFlag = false;
		}

	}
}

/*
 *	记住密码部分参考：https://blog.csdn.net/Cyanapple_wen/article/details/5417561
 *	
	 */
