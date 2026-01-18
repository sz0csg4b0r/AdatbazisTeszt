using AdatbazisTeszt.Database;
using AdatbazisTeszt.Model;
using System.Data;

internal class Program
{
    public static readonly string connectionString 
        = "Server=localhost;Database=foldrajz;User=root;";
    public static DataTable adatok = new DataTable();
    public static List<Orszag> orszagLista  = new List<Orszag>();

    private static void Main(string[] args)
    {
        //DBCheck(connectionString);
        SelectFromTable("orszagok", connectionString);
        AdatBetoltes(adatok);
        
    }

    private static void AdatBetoltes(DataTable adatok)
    {
        //Itt hagytuk abba előző órán 12A - péntek
        foreach (DataRow o in adatok.Rows)
        {
            Orszag orszag = new Orszag();

            orszag.id = o.Field<int>(0);
            orszag.orszag = o.Field<string>(1);
            orszag.fovaros = o.Field<string>(2);
            orszag.foldr_hely = o.Field<string>(3);
            orszag.terulet = Convert.ToDouble(o.Field<decimal>(4));
            orszag.allamforma = o.Field<string>(5);
            orszag.nepesseg = o.Field<int>(6);
            orszag.nep_fovaros = o.Field<int>(7);
            orszag.autojel = o.Field<string>(8);
            orszag.country = o.Field<string>(9);
            orszag.capital = o.Field<string>(10);
            orszag.penznem = o.Field<string>(11);
            orszag.penzjel = o.Field<string>(12);
            orszag.valtopenz = o.Field<string>(13);
            orszag.telefon = o.Field<int>(14);
            orszag.gdp = o.Field<int>(15);
            orszag.kat = o.Field<int>(16);
            orszagLista.Add(orszag);
        }
    }

    private static void SelectFromTable(string tableName, string connectionString)
    {
        adatok = DatabaseService.GetAllData(tableName, connectionString);
        Console.WriteLine("Adatok sikeresen szinkronizálva az adatbázisból, átmeneti tárolóba");
    }

    private static void DBCheck(string connectionString)
    {
         DatabaseService.DbConnectionCheck(connectionString);
    }
}