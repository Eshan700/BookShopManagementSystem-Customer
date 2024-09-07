using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookShop_shenuLogin
{
    class DBConection
    {
        public static MySqlConnection ConnectDB()
        {
            try
            {
                /*string server = "localhost";
                string database = "payroll_test";
                string uid = "root";
                string password = "password";*/
                string connectionString;

                connectionString = "Server=localhost;User=root;Database=bookshop;Port=3306;Password=password;SslMode=Required";

                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        }
}
