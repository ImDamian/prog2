using System;
using MySqlConnector;

namespace database
{
    class Database
    {
        private static Database instance = new Database();

        private Database()
        {
        }

        public static Database getInstance()
        {
            return instance;
        }

        public void executeSql(string statement)
        {
            string connectionString = "Server=localhost;Database=bier;Uid=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string sql = statement;
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetValue(i));
                }

                Console.WriteLine("\n");
            }

            connection.Close();
        }
    }
}