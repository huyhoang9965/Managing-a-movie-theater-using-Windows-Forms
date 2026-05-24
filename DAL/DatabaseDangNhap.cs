using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseDangNhap
    {
        public static SqlConnection Connect()
        {
            string str = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
    }
    
}
