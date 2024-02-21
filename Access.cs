using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{
    internal class Access
    {
        SqlConnection conn;
        public bool OpenConnection(string server, int port, string databaseName, string user, string password)
        {
            conn = new SqlConnection($"Serve={server};Database={databaseName};User={user};Password={password}");
            try
            {
                conn.Open();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public SqlDataReader Query(string SQL)
        {
            SqlDataReader reader = new SqlDataReader();
        }
    }
}
