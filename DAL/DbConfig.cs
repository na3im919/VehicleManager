using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DAL
{
  

    public static class DbConfig
    {
        public static string ConnectionString { get; private set; }

        // هذا الكود يعمل مرة واحدة عند تشغيل البرنامج
        static DbConfig()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // قراءة سلسلة الاتصال من الملف
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
    }
}
