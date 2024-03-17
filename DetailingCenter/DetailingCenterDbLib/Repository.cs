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
        private const string TableName = "Employees";

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
            _db.Execute(
                $"CREATE TABLE IF NOT EXISTS {TableName} (" +
                    "SqlId              INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "Name               TEXT NOT NULL," +
                    "Surname            TEXT NOT NULL," +
                    "Patronymic         TEXT NOT NULL," +
                    "Phone              TEXT NOT NULL," +
                    "Education          TEXT NOT NULL," +
                    "Position           TEXT NOT NULL," +
                    "Salary             TEXT NOT NULL" +
                    "); " +
                $"INSERT INTO {TableName} (Name, Surname, Patronymic, Phone, Education, Position, Salary) " +
                $"VALUES (@Name, @Surname, @Patronymic, @Phone, @Education, @Position, @Salary);",
                employee);
        }
        
        public bool TryGetEmployees(out Employee[] employees)
        {
            try
            {
                employees = _db
                    .Query<Employee>($"SELECT SqlId, Name, Surname, Patronymic, Phone, Education, Position, Salary" +
                        $" FROM {TableName}")
                    .ToArray();
                return true;
            }
            catch(Exception ex)
            {
                employees = new Employee[0];
                Console.WriteLine($"Какая то ошибка!{ex.Message} {ex.StackTrace}");
                return false;
            }
        }
    }
    
}
