using AdatbazisTeszt.Database;
using System.Security.Cryptography.X509Certificates;

internal class Program
{


    public static readonly string connectionString = "Server=localhost;Database=11a_foldrajz;User:Root;";
  

    private static void Main(string[] args)
    {
<<<<<<<<< Temporary merge branch 1
=========
        //Console.WriteLine(connectionString);
>>>>>>>>> Temporary merge branch 2
        DBCheck(connectionString);
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}