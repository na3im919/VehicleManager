using System;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public static class DbInitializer
    {
        private static string masterConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
        private static string dbName = "VehcileManager";

        public static void InitializeDatabase()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
                RunSqlScript();
            }
        }

        private static bool DatabaseExists()
        {
            using (var conn = new SqlConnection(masterConnection))
            {
                conn.Open();
                using (var cmd = new SqlCommand($"SELECT COUNT(*) FROM sys.databases WHERE name = '{dbName}'", conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private static void CreateDatabase()
        {
            using (var conn = new SqlConnection(masterConnection))
            {
                conn.Open();
                using (var cmd = new SqlCommand($"CREATE DATABASE [{dbName}]", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void RunSqlScript()
        {
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatabaseScript.sql");
            if (!File.Exists(scriptPath))
                throw new FileNotFoundException("Database script not found.", scriptPath);

            string script = File.ReadAllText(scriptPath);

            // تقسيم السكربت حسب GO
            var commands = script.Split(new[] { "GO\r\n", "GO\n" }, StringSplitOptions.RemoveEmptyEntries);

            using (var conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog={dbName};Integrated Security=True"))
            {
                conn.Open();
                foreach (var commandText in commands)
                {
                    if (string.IsNullOrWhiteSpace(commandText)) continue;

                    using (var cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
