namespace DAL
{
    public static class DbConfig
    {
        public static string ConnectionString { get; private set; } =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VehcileManager.mdf;Integrated Security=True";
    }
}
