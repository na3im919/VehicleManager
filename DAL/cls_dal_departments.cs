using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_departments
    {
        static string connectionString  = DbConfig.ConnectionString;

        public static List<Models.cls_ml_departments> GetAllDepartments(out string error)
        { 
            var departments = new List<Models.cls_ml_departments>();
            error = string.Empty;
            string query = "SELECT department_id, department_name FROM departments WHERE isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var department = new Models.cls_ml_departments
                        {
                            department_id = Convert.ToInt32(reader["department_id"]),
                            department_name = reader["department_name"].ToString(),
                            isActive = true
                        };
                        departments.Add(department);
                    }
                    reader.Close();
                    return departments;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static int GetDepartmentIdByName(string department_name, out string error)
        {
            error = string.Empty;
            int department_id = -1;
            string query = "SELECT department_id FROM departments WHERE department_name = @department_name AND isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", department_name);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        department_id = Convert.ToInt32(result);
                    }
                    return department_id;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1;
                }
            }
        }

        public static int AddNewDepartment(string department_name, out string error)
        {
            error = string.Empty;
            int new_department_id = -1;
            string query = "INSERT INTO departments (department_name, isActive) OUTPUT INSERTED.department_id VALUES (@department_name, 1)";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", department_name);
                try
                {
                    connection.Open();
                    new_department_id = (int)command.ExecuteScalar();
                    return new_department_id;
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
