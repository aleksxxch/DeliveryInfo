using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryInfo.Models
{
    public class TimesModel
    {
        public int Num { get; set; }
        public string Zone { get; set; }
        public string Time { get; set; }
        public DateTime SetTime { get; set; }
        public object DelTime { get; set; }
        public string Flag { get; set; }
        public int RestExtId { get; set; }
        public DateTime DateOfStop { get; set; }
    }
}
