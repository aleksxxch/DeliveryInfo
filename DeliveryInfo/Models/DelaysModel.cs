using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryInfo.Models
{
    public class DelaysModel
    {
        public int C_ { get; set; }
        public string Zone { get; set; }
        public string Delay { get; set; }
        public int IntDelay { get; set; }
        public System.DateTime SetTime { get; set; }
        public Nullable<System.DateTime> DelTime { get; set; }
        public Nullable<int> DiffTime { get; set; }
        public string Type { get; set; }
        public Nullable<int> Typeid { get; set; }
        public string Cause { get; set; }
        public Nullable<int> Causeid { get; set; }
        public string fullCause { get; set; }
        public Nullable<int> Flag { get; set; }
        public Nullable<long> RestExtId { get; set; }
    }   

}
