using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace WebApplication.Models
{
    public class Students
    {
        public string registrationNumber { get; set; }
        public string name { get; set; }
        public int credits { get; set; }

        //private bool connection_open;
        private MySqlConnection connection;

        public Students()
        {
        }
        public Students(string arg_id)
        {
            Get_Connection();
            registrationNumber = arg_id;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("SELECT * FROM students");

                MySqlDataReader reader = cmd.ExecuteReader();
                /*try
                {
                    reader.Read();

                    if (reader.IsDBNull(0) == false)
                        name = reader.GetString(0);
                    else
                        name = null;
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    string MessageString = "Read error occurred " + e.ErrorCode + " - " + e.Message + ";";
                    reader.Close();
                }*/
                while(reader.Read())
                {
                    Console.WriteLine(reader["mvc"].ToString());
                }
            }
            catch (MySqlException e)
            {
                string MessageString = "The following error occurred "
                    + e.ErrorCode + " - " + e.Message;
                name = "Marvelous Gentleman";//MessageString;
            }
        }
        private void Get_Connection()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["mvc"].ConnectionString;
            Open_Local_Connection();
        }

        private bool Open_Local_Connection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {   
                return false;
            }
        }
    }
}