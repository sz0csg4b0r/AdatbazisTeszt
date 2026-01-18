using MySqlConnector;

namespace AdatbazisTeszt.Database
{
    internal class DatabaseService
    {
        private static string connectionString;
        private static string table;
        private static string query_parameters;

        public static void DbConnectionCheck(string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Sikeres a csatlakozás!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sikertelen kapcsolódás");
                Console.WriteLine(ex);
            }

        }





    }
}
