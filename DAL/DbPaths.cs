using System;
using System.IO;

namespace DAL
{
    internal static class DbPaths
    {
        public const string DatabaseName = "VehcileManagerDB";

        public static readonly string DataFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                "VehcileManager",
                "Data");

        public static readonly string MdfPath =
            Path.Combine(DataFolder, "VehcileManagerDB.mdf");

        public static string SourceMdfPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VehcileManagerDB.mdf");
    }
}
