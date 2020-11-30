using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryInfo.Models
{
    public class Rests
    {
        public string name { get; set; }
        public string alter_name { get; set; }
        public string ext_name { get; set; }
        public int applied { get; set; }
        public int drv_group { get; set; }
        public int rest_id { get; set; }
        public int drv_num { get; set; }
        public int walk_num { get; set; }
        public int drv_num_default { get; set; }
        public int walk_num_default { get; set; }
        public int scheme_id { get; set; }
        public int rest_external_id { get; set; }
    }
}
