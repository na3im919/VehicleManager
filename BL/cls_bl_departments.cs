using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class cls_bl_departments
    {
        public static List<Models.cls_ml_departments> GetAllDepartments(string kw, bool isActive, out string error)
        {
            return cls_dal_departments.GetAllDepartments(kw, isActive, out error);
        }

        public static int AddNewDepartment(string department_name, out string error)
        {
                       return cls_dal_departments.AddNewDepartment(department_name, out error);
        }

        public static int GetDepartmentIdByName(string department_name, out string error)

        {          
            return cls_dal_departments.GetDepartmentIdByName(department_name, out error);
        }

        public static string GetDepartmentName(int departmentID, out string error)
        {
            return cls_dal_departments.GetDepartmentName(departmentID, out error);
        }

        public static bool UpdateDepartment(int departmentID, string departmentName, out string error)
        {
            return cls_dal_departments.UpdateDepartment(departmentID, departmentName, out error);
        }

        public static bool DeleteDepartment(int departmentID, out string error)
        {
            return cls_dal_departments.DeleteDepartment(departmentID, out error);
        }

        public static bool ReactivateDepartment(int departmentID, out string error)
        {
            return cls_dal_departments.ReactivateDepartment(departmentID, out error);
        }


    }
}
