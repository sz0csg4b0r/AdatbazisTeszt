using AdatbazisTeszt.Database;
using MySqlConnector;
using System.Net;

internal class Program
{
    public static readonly string connectionString = "Server=localhost;Database=foldrajz;User=root;";

    private static void Main(string[] args)
    {
        
        DBCheck(connectionString);


    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}