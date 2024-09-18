using System;
using MySql.Data.MySqlClient;

namespace MySqlExample{
    class DeleteExample{
        static void Main(string[] args)
        {
            string connectionString= "server=localhost;database=bca;user=root;password=noorkhan786";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string deleteQuery = "DELETE FROM students where student_id= 3";
            try{
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected>0){
                    Console.WriteLine("Record deleted successfully");
                    Console.WriteLine("rows affected: " + rowsAffected);
                }else{
                    Console.WriteLine("No records were deleted");
                }
            }catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }finally{
                conn.Close();
            }
        }
    }
}