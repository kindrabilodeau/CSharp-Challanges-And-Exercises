using System;
using System.Data.SQLite;

namespace SQLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            DropTable(sqlite_conn);
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn); 

        }

        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= database.db; New = True; Compress = True;");

            try
            {
                sqlite_conn.Open();
                Console.WriteLine("SQLite connection created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return sqlite_conn; 
        }

        private static void DropTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "drop table if exists Snacks";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            string Createsql1 = "drop table if exists Drinks";
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Dropping table");
        }

        private static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string createsql = "CREATE TABLE Snacks (Name STRING, QTY INT)";
            string createsql1 = "CREATE TABLE Drinks (NAME STRING, TYPE STRING, QTY INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = createsql1;
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Creating Tables");
        }

        private static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Snacks (NAME, QTY) VALUES ('Chocolate Chip Cookies', 12);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Snacks (NAME, QTY) VALUES ('Chips', 7);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Drinks (NAME,TYPE, QTY) VALUES ('MR.Fizzy Pop', 'Soda', 4);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Drinks (NAME,TYPE, QTY) VALUES ('Aqua', 'Water', 5);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Drinks (NAME,TYPE, QTY) VALUES ('Jumping Beans', 'Coffee', 5);";
            sqlite_cmd.ExecuteNonQuery();
        }

        private static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sql_cmd;
            sql_cmd = conn.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM Snacks";

            sqlite_datareader = sql_cmd.ExecuteReader();
            while(sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
                int myreader2 = sqlite_datareader.GetInt32(1);
                Console.WriteLine(myreader2);
            }
            
            sql_cmd = conn.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM Drinks";

            sqlite_datareader = sql_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
                string myreader1 = sqlite_datareader.GetString(1);
                Console.WriteLine(myreader1);
                int myreader2 = sqlite_datareader.GetInt32(2);
                Console.WriteLine(myreader2);
            }
        }
    }
}
