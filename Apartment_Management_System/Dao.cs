// 用于数据库的连接
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
namespace Apartment_Management_System {
    internal class Dao {
        SqlConnection sc;
        public SqlConnection Connection()
        {
            // str 是连接数据库的字符串
            string str = @"Data Source = XIN; Initial Catalog = Apartment_Management_System; Integrated Security = True";
            sc = new SqlConnection(str);
            sc.Open(); // 打开数据库
            return sc;
        }
        public SqlCommand Command(string sql) {
            SqlCommand cmd = new SqlCommand(sql, Connection());
            return cmd;
        }
        public int Execute(string sql) {  // 更新操作
            return Command(sql).ExecuteNonQuery();
        }
        public SqlDataReader Reader(string sql) { // 读取操作

            return Command(sql).ExecuteReader();
        }
        public void DaoClose() { // 关闭数据库连接
            sc.Close();
        }
    }
}



