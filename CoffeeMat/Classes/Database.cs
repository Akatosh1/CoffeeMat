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
        readonly SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-6934O1D;Initial Catalog=CoffeeBase; Integrated Security=True");

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
