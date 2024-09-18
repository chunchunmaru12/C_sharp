using System;
using MySql.Data.MySqlClient;

namespace MySqlExample{
    class CreateExample{
        static void Main(string[] args)
        {
            string connectionString= "server=localhost;database=bca;user=root;password=noorkhan786";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string insertQuery = "INSERT INTO bca.students(first_name,last_name,address) VALUES('soda','buddi','patan')";
            // string insertQuery = "INSERT INTO bca.students(first_name,last_name,address) VALUES('@FirstName','@LastName','@Address')";

            try{
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                /*
                cmd.Parameters.AddWithValue("@FirstName",firstName);
                cmd.Parameters.AddWithValue("@LastName",lastName);
                cmd.Parameters.AddWithValue("@Address",address);
                */
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected>0){
                    Console.WriteLine("Record inserted successfully");
                    Console.WriteLine("rows affected: " + rowsAffected);
                }else{
                    Console.WriteLine("No records were inserted");
                }
            }catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }finally{
                conn.Close();
            }
        }
    }
}