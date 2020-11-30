using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryInfo.Models
{

    public class DelaysSumInfoModel
    {
        public RestDelaysInfoModel[] Consolidated_delay{ get; set; }
    }

    public class RestDelaysInfoModel
    {
        public string restName { get; set; }
        public int durationSum { get; set; }
        public int numOfDelays { get; set; }
        public double averageDuration { get; set; }
        public double avgDelay { get; set; }
    }

    public class RestDelaysInfoModelCauses: RestDelaysInfoModel
    {
        public string cause { get; set; }
    }

    

}
