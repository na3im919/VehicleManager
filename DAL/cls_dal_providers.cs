using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_providers
    {
        static string connectionString = DbConfig.ConnectionString;

        public static List<cls_ml_providers> GetAllProviders(out string error)
        {
            var providers = new List<cls_ml_providers>();

            error = string.Empty;

            string query = "SELECT provider_id, provider_name FROM providers WHERE isActive = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var provider = new cls_ml_providers
                        {
                            provider_id = Convert.ToInt32(reader["provider_id"]),
                            provider_name = reader["provider_name"].ToString(),
                            isActive = true
                        };
                        providers.Add(provider);
                    }
                    reader.Close();
                    return providers;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static int GetProviderIDByName(string providerName, out string error)
        {
            error = string.Empty;
            string query = "SELECT provider_id FROM providers WHERE provider_name = @providerName AND isActive = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerName", providerName);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Not found
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1;
                }
            }

            

        }

        public static int AddNewProvider(string providerName, out string error)
        {
            error = string.Empty;
            string query = "INSERT INTO providers (provider_name, isActive) VALUES (@providerName, 1); SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerName", providerName);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Insert failed
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1;
                }
            }
        }
    }
}
