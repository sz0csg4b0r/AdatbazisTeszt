using AdatbazisTeszt.Database;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    public static readonly string connectionString = "Server=localhost;Database=foldrajz;User=root;";
   

    private static void Main(string[] args)
    {
        //Console.WriteLine(connectionString);
        DBCheck(connectionString);
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}