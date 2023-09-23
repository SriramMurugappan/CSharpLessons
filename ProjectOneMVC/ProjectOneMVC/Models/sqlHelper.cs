using Microsoft.Data.SqlClient;

namespace ProjectOneMVC.Models
{
    public class sqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2748\SQLEXPRESS;database=testdb;
                                integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
