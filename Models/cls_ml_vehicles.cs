using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class cls_ml_vehicles
    { 
        public int vehicle_id { get; set; }
        public string vehicle_brand { get; set; }
        public string registration_number { get; set; }
        public int provider_id { get; set; }
        public string provider_name { get; set; }
        public int? department_id { get; set; }
        public string department_name { get; set; }
        public int? driver_id { get; set; }
        public string driver_name { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string observation { get; set; }

        public string status_label { get; set; }
        public int status_id { get; set; } = 1;

    }
}
