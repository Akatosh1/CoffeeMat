using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMat
{
    internal class Database
    {
        public static string connec = Properties.Settings.Default.Database1ConnectionString;
        readonly SqlConnection sqlConnection = new SqlConnection(connec);

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConection()
        {
            return sqlConnection;
        }
    }
}
