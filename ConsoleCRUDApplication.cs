using System;
using System.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
namespace MySQLExample{
    class CRUD{
        static MySqlConnection Connection(){
            string connectionString = "server=localhost;database=bca;user=root;password=noorkhan786";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection to the database successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return connection;
        }
        static void Delete(MySqlConnection connection){
            Console.WriteLine("Enter the id of the student u want to delete: ");
            int id=int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM student_information where id="+id;
            try{
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected>0){
                    Console.WriteLine("Record deleted successfully");
                    Console.WriteLine("rows affected: " + rowsAffected);
                }else{
                    Console.WriteLine("No records were deleted");
                }
            }catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        static void Search(MySqlConnection connection){
            Console.WriteLine("Enter the value to search:");
            string searchValue = Console.ReadLine();
            
            string searchQuery = $"SELECT * FROM bca.student_information WHERE name LIKE '%{searchValue}%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
            DataSet dataSet = new DataSet();
            try
            {
            adapter.Fill(dataSet, "student_information");
            foreach (DataRow row in dataSet.Tables["student_information"]!.Rows)
            {
                Console.Write($"name: {row["name"]} , marks: {row["marks"]} , addresses: {row["address"]}");
                Console.WriteLine();
            }
            }
            catch (Exception ex)
            {
            Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Update(MySqlConnection connection){
            Console.WriteLine("Enter your student id to be updated: ");    
            int id = int.Parse(Console.ReadLine());
            int reg_id; string name; int marks; string address;
            Console.WriteLine("Enter your registration id:");
            if (!int.TryParse(Console.ReadLine(), out reg_id))
            {
                Console.WriteLine("Invalid registration id.");
                return;
            }
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your marks:");
            if (!int.TryParse(Console.ReadLine(), out marks))
            {
                Console.WriteLine("Invalid marks.");
                return;
            }
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();
            string updateQuery = "UPDATE bca.student_information SET reg_id = "+
            reg_id+", name = '"+name+"', marks="+marks+", address='"+address+"' WHERE id = "+id;
            try{
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected>0){
                    Console.WriteLine("Record updated successfully");
                    Console.WriteLine("rows affected: " + rowsAffected);
                }else{
                    Console.WriteLine("No records were updated");
                }
            }catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Read(MySqlConnection connection){
            string sql = "SELECT * FROM bca.student_information";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            try
            {
                adapter.Fill(dataSet, "student_information");
                foreach (DataRow row in dataSet.Tables["student_information"]!.Rows)
                {
                    int studentId = Convert.ToInt32(row["id"]);
                    int regId = Convert.ToInt32(row["reg_id"]);
                    int studentMarks = Convert.ToInt32(row["marks"]);
                    string studentName = row["name"].ToString()+"";
                    string address = row["address"].ToString()+"";
                    Console.WriteLine($"Student ID: {studentId}, Registration Id:{regId}, Name: {studentName}, Marks:{studentMarks}, Address: {address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Insert(MySqlConnection conn){
            int reg_id; string name; int marks; string address;
            Console.WriteLine("Enter your registration id:");
            if (!int.TryParse(Console.ReadLine(), out reg_id))
            {
                Console.WriteLine("Invalid registration id.");
                return;
            }
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your marks:");
            if (!int.TryParse(Console.ReadLine(), out marks))
            {
                Console.WriteLine("Invalid marks.");
                return;
            }
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();
            string insertQuery = "INSERT INTO bca.student_information(reg_id,name,marks,address) VALUES('"+
            reg_id+"','"+name+"','"+marks+"','"+address+"')";
            try{
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("***********************************");
                Console.WriteLine("Record inserted successfully.");
                Console.WriteLine("***********************************");
            }catch(Exception ex){
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            MySqlConnection connection = Connection();
            while (true){
                Console.WriteLine("********************************");
                Console.WriteLine("   CONSOLE CRUD APPLICATION:");
                Console.WriteLine("********************************");
                int choice;
                Console.WriteLine("1.Insert 2.Update 3.Delete 4.Select 5.Searches 6.Exit");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
                switch (choice){
                    case 1:
                        Insert(connection);
                        break;
                    case 2:
                        Update(connection);
                        break;
                    case 3:
                        Delete(connection);
                        break;
                    case 4:
                        Read(connection);
                        break;
                    case 5:
                        Search(connection);
                        break;
                    case 6:
                        connection.Close();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}