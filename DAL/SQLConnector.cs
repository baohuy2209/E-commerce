using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLConnector
    {
        protected SqlConnection connection;
        protected string connectionString = "data source=LAPTOP-IR71K886\\SQLSERVER2022;initial catalog=Furniture; persist security info = True;integrated security= SSPI; TrustServerCertificate=True;";
        public SQLConnector()
        {
            connection = new SqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlDataReader Query(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader; 
        }
        public int NonQuery(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            int ret = command.ExecuteNonQuery();
            return ret;
        }
    }
}
