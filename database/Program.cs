using System;
using MySqlConnector;

namespace database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Database db = Database.getInstance();
            db.executeSql("SELECT * FROM bier");
        }
    }
}