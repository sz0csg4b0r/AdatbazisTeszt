using AdatbazisTeszt.Database;

internal class Program
{
    public static readonly string connectionString = "Server=localhost;Database=11a_foldrajz;User=root;";

    private static void Main(string[] args)
    {
        DBCheck(connectionString);
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}