using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;



namespace Dental.Core.Functions
{
    public class ConnectionStringInfo
    {
        private static string FilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Connection.dat";

        public static string Get()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }

            return null;
        }

        public static void Set(string connectionString)
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            }
            File.WriteAllText(FilePath, connectionString);
        }

        public static bool Check(string connectionString = null)
        {          //?? connectionString null ise Get() metodunu kullan,null değilse connectionString kullan
            SqlConnectionStringBuilder connectionStringBuilder =
                new SqlConnectionStringBuilder(connectionString ?? Get()) { InitialCatalog = "master" };
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
