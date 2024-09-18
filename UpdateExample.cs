using System;
using MySql.Data.MySqlClient;

namespace MySqlExample{
    class UpdateExample{
        static void Main(string[] args)
        {
            string connectionString= "server=localhost;database=bca;user=root;password=noorkhan786";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string updateQuery = "UPDATE bca.students SET first_name = 'aloo', last_name = 'prasad' WHERE student_id = 3";
            try{
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected>0){
                    Console.WriteLine("Record updated successfully");
                    Console.WriteLine("rows affected: " + rowsAffected);
                }else{
                    Console.WriteLine("No records were updated");
                }
            }catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }finally{
                conn.Close();
            }
        }
    }
}