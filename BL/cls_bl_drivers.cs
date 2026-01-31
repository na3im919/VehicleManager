using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class cls_bl_drivers
    {
        public static List<Models.cls_ml_drivers> GetAllDrivers(out string error)
        {
            return DAL.cls_dal_drivers.GetAllDrivers(out error);
        }
    }
}
