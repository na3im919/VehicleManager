using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BL
{
    public class cls_bl_vehicles
    {
        public static List<cls_ml_vehicles> GetAllVehicles(
            out string error_message,
            string columnName = null,
            string searchText = null)
        {
            return cls_dal_vehicles.GetAllVehicles(out error_message, columnName, searchText);


        }
         public static int GetTotalVehiclesCount(string status, out string error_message)
        {
            return cls_dal_vehicles.GetTotalVehiclesCount(status, out error_message);
        }


        public static int GetInServiceVehiclesCount(out string error_message)
        {
            return cls_dal_vehicles.GetInServiceVehiclesCount(out error_message);
        }




}

    public class vehiclesCountingChangedEventArgs : EventArgs
    {
        public int currentCounting { get; }
        public string label_name { get; }

        public vehiclesCountingChangedEventArgs(int currentCounting, string label_name)
        {
            this.currentCounting = currentCounting;
            this.label_name = label_name;
        }
    }

   
}
