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

        public static List<cls_ml_providers> GetAllProviders(string kw, out string error, bool isActive)
        {
            var providers = new List<cls_ml_providers>();

            error = string.Empty;
            string activeCondition = isActive ? "isActive = 1" : "isActive = 0";
            string query = $"SELECT provider_id, provider_name FROM providers WHERE {activeCondition} AND (@keyword IS NULL OR provider_name LIKE '%' + @keyword + '%')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(
                    "@keyword",
                    string.IsNullOrWhiteSpace(kw) ? (object)DBNull.Value : kw
                );
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

        public static cls_ml_providers GetProvidersData(int providerID, out string error)
        {
            error = string.Empty;
            string query = "SELECT provider_id, provider_name FROM providers WHERE provider_id = @providerID AND isActive = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerID", providerID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var provider = new cls_ml_providers
                        {
                            provider_id = Convert.ToInt32(reader["provider_id"]),
                            provider_name = reader["provider_name"].ToString(),
                            isActive = true
                        };
                        reader.Close();
                        return provider;
                    }
                    else
                    {
                        reader.Close();
                        return null; // Not found
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
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

        public static bool UpdateProvider(int providerID, string providerName, out string error)
        {
            error = string.Empty;
            string query = "UPDATE providers SET provider_name = @providerName WHERE provider_id = @providerID AND isActive = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerID", providerID);
                command.Parameters.AddWithValue("@providerName", providerName);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if update was successful
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }

        public static bool DeactivateProvider(int providerID, out string error)
        {
            error = string.Empty;
            string query = "UPDATE providers SET isActive = 0 WHERE provider_id = @providerID AND isActive = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerID", providerID);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if deactivation was successful
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }
        public static bool ActivateProvider(int providerID, out string error)
        {
            error = string.Empty;
            string query = "UPDATE providers SET isActive = 1 WHERE provider_id = @providerID AND isActive = 0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@providerID", providerID);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if activation was successful
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }
        }
}
