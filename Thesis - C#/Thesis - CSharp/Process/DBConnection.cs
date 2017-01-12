using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Thesis___CSharp.Process
{
    class DBConnection
    {

        public static SqlConnection con;

        public static String DB_PATH = "Data Source=TAYLAN;" +
                                        "Initial Catalog=mythesis;" +
                                        "User id=sa;" +
                                        "Password=12345";
    
        public static SqlConnection getConnection()
        {

            try
            {
                con = new SqlConnection(DB_PATH);
                con.Open();
                return con;
            }
            catch (Exception) {
                return null;
            }
        
        }

        public static bool addDB(String SQL)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DB_PATH);
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public static bool deleteDB(String SQL)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DB_PATH);
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool updateDB(String SQL)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DB_PATH);
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable selectDB(String SQL)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DB_PATH);
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                connection.Close();
                return dTable;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
