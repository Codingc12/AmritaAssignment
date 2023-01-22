using System;
using MySql.Data;
//Created By Ramanan S
/*
 Front End part of the API For viewing data by
the user
 
 
 *Uses MySQL.Data NuGET Package
 
 */
namespace AmritaAssignment.Data
{
	public class DepartmentViewFrontEnd
	{
        MySql.Data.MySqlClient.MySqlConnection? conn;
        string myConnectionString;
        public DepartmentViewFrontEnd()
        {
            this.myConnectionString = "server=localhost;uid=root;" +
        "pwd=10032004@Ra;database=project01";
        }

        public void create_conn()
        {
            try
            {
                this.conn = new MySql.Data.MySqlClient.MySqlConnection();
                this.conn.ConnectionString = myConnectionString;
                this.conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Console.Write($"{ex}");
            }
        }




        public void Insert(string name_)
        {
            try
            {
                create_conn();
                string name_p = $"CALL insert_('{name_}');";
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p, conn);
                command.ExecuteReader();
                closeconnection();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                closeconnection();
                System.Console.Write($"{ex}");
            }


        }


        public void Delete_(string name_)
        {
            try
            {
                create_conn();
                string name_p = $"CALL delete_('{name_}');";
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p, conn);
                command.ExecuteReader();
                closeconnection();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                closeconnection();
                System.Console.Write($"{ex}");
            }


        }

        public MySql.Data.MySqlClient.MySqlDataReader Select(string? name)
        {
            try
            {
                create_conn();
                string name_p = $"CALL select_dept('{name}');";
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p, conn);
                MySql.Data.MySqlClient.MySqlDataReader dt = command.ExecuteReader();
                
                return dt;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                closeconnection();
                System.Console.Write($"{ex}");
                return null;
            }
        }

        private int closeconnection()
        {
            this.conn.Close();
            return 1;

        }

    }
}

