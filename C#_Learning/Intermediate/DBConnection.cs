using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define the connection string (server, database, auth)
            string connectionString = @"Server=YOUR_SERVER_NAME;Database=YOUR_DB_NAME;User Id=YOUR_USER;Password=YOUR_PASSWORD;";
            
            // 2. Instantiate the SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // 3. Open the database connection
                    connection.Open();
                    Console.WriteLine("Connection opened successfully.");

                    // 4. Prepare a SQL query or command text
                    string sql = "SELECT Id, Name FROM Employees";

                    // 5. Create a SqlCommand associated with the connection
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // 6. Execute the command (ExecuteReader for queries)
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // 7. Read and process the result set
                            while (reader.Read())
                            {
                                int id   = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                Console.WriteLine($"Employee #{id}: {name}");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // 8. Handle SQL-specific exceptions
                    Console.WriteLine("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    // 9. Handle other general exceptions
                    Console.WriteLine("General Error: " + ex.Message);
                }
                finally
                {
                    // 10. Ensure the connection is closed
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection closed.");
                    }
                }
            }
        }
    }
}
