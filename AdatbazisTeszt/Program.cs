using AdatbazisTeszt.Database;
using System.Security.Cryptography.X509Certificates;

internal class Program
{


    public static readonly string connectionString = "Server=localhost;Database=11a_foldrajz;User=root;";
  

    public static readonly string connectionString = "Server=localhost;Database=11a_foldrajz;User:Root;";
>>>>>>> 971a7774c508bd5c7d70cf5fedd6024bd62f327b


    private static void Main(string[] args)
    {
>>>>>>>>> Temporary merge branch 2
        DBCheck(connectionString);
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}