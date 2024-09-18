using System;
using MySql.Data.MySqlClient;
/*
Working with database

---Localhost(127.0.0.1)---------------------------------------------------------------
-
-                                                   PHPmyAdmin Server
-
-
-       ----------------                            ASP.NET PORT 80
-       - MySQL Server -                            
-       - Port 3306    -        
-       ----------------                            c# Cosole App
-
-
-
-
--------------------------------------------------------------------------------------
 
Local Compter

* ADO vs ADO.NET(self study)

* Data Reader, Data Adapter, Dataset and data table
-> The key components of ADO.NET used for accessing and manipulating data from database
*Data Reader=> fast, forward-only. read only cursor for accessing data
            -> Consumes fewer resources compared to Data set and Data table
* Dataset=> in-memory  representation of data that can contain multiple Data table objects
            -> Supports relationships between table and can Work in disconnected manner
* Data table => represents single table in-memory data

*/
namespace MySqlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;database=bca;user=root;password=pass";
            // datasource=localhost;port=3306;username=root;password=pass
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                try
                {
                    //Open the database connection
                    connection.Open();
                    Console.WriteLine("Connection to the database successful!");
                      string query = "SELECT student_id, first_name, address FROM students";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            int studentId = reader.GetInt32("student_id");
                            string studentName = reader.GetString("first_name");
                            string address = reader.GetString("address");

                            Console.WriteLine($"Student ID: {studentId}, Name: {studentName}, Address: {address}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally{
                    connection.Close();
                }
            }
        }
    }
}