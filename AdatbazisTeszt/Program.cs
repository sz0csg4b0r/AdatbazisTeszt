using AdatbazisTeszt.Database;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

<<<<<<< HEAD
    public static readonly string connectionString = "Server=localhost;Database=foldrajz;User=root;";
=======
    public static readonly string connectionString = "Server=localhost;Database=11a_foldrajz;User:Root;";
>>>>>>> 971a7774c508bd5c7d70cf5fedd6024bd62f327b
   

    private static void Main(string[] args)
    {
<<<<<<< HEAD
        //Console.WriteLine(connectionString);
=======
>>>>>>> 971a7774c508bd5c7d70cf5fedd6024bd62f327b
        DBCheck(connectionString);
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}