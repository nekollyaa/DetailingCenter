using Dapper;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace DetailingCenterDbLib
{
    /// <summary>
    /// Обёртка над бд
    /// </summary>
    public class Repository
    {
        private readonly IDbConnection _db;

        public Repository()
        {
            var folderpath = "C:\\Users\\PC\\Desktop";
            string fileName = "Test2";
            if (!Directory.Exists(folderpath))
                Directory.CreateDirectory(folderpath);

            var connectionString = Path.Combine($"Data Source={folderpath}",
            $"{fileName}.sq3db;Compress=True;foreign keys=true;DateTimeFormat=Ticks;UTF8Encoding=True;FailIfMissing=False;");
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            connection.Execute("PRAGMA journal_mode = WAL;");
            connection.Execute("PRAGMA cache_size = 100000;");
            connection.Execute("PRAGMA page_size = 4096;");
            _db = connection;
        }
        public void SaveEmployee(Employee employee)
        {
            string tableName = "Employees";
            _db.Execute(
                $"CREATE TABLE IF NOT EXISTS {tableName} (" +
                    "SqlId              INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "Name               TEXT NOT NULL," +
                    "Surname            TEXT NOT NULL" +
                    "); " +
                $"INSERT INTO {tableName} (Name, Surname) " +
                $"VALUES (@Name, @Surname);",
                employee);
        }
    }
    
}
