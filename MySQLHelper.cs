using MySql.Data.MySqlClient;   //引用MySql
using System;

namespace Visualization
{
    class MySQLHelper
    {
        public static string DB_URL = "localhost"; //数据库连接
        public static string DB_NAME = "is_design";   //数据库名称
        public static string USER = "root";  //用户名
        public static string PASSWORD = "pwd"; //密码
        public MySqlConnection conn;//与数据库建立的连接
        public MySqlDataReader mysqlDataReader;

        public MySQLHelper()
        {
            GetConnect();
        }
        public void GetConnect()
        {
            //定义数据库 连接字符串（包含了数据库信息）
            string strConn = "server=" + DB_URL + ";database=" + DB_NAME + ";user=" + USER + ";password=" + PASSWORD + ";";
            //创建Conection对象
            conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
                //MessageBox.Show("连接成功");
                //Console.Write("打开成功 MySql版本" + conn.ServerVersion);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString() + "打开报错");
            }
        }
        // 关闭数据库
        public void CloseDB()
        {
            try
            {
                conn.Close();
                conn = null;
                mysqlDataReader.Close();
                mysqlDataReader = null;
                //MessageBox.Show("关闭成功");
            }
            catch (Exception)
            {
                //MessageBox.Show("关闭数据库出现错误！");
            }
        }
        public MySqlDataReader Query(string str)
        {
            //使用SqlCommand执行Sql语句
            MySqlCommand cmd = new MySqlCommand(str, conn);
            //SqlDataReader对象从数据源获取数据
            mysqlDataReader = cmd.ExecuteReader();
            return mysqlDataReader;
        }
    }
}
