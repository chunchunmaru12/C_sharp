using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace MySqlExample
{
    class SelectExample
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;database=bca;user=root;password=noorkhan786";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "SELECT * FROM bca.students WHERE address LIKE '%patan%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();

                adapter.Fill(dataSet, "students");
                foreach (DataRow row in dataSet.Tables["students"]!.Rows)
                {
                    int studentId = Convert.ToInt32(row["student_id"]);
                    string studentName = row["first_name"].ToString()+" "+ row["last_name"].ToString();
                    string address = row["address"].ToString()+"";

                    Console.WriteLine($"Student ID: {studentId}, Name: {studentName}, Address: {address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}