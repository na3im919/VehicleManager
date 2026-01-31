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
        public static List<Models.cls_ml_departments> GetAllDepartments(out string error)
        {
            return cls_dal_departments.GetAllDepartments(out error);
        }
    }
}
