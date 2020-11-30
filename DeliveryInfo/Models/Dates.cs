using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DeliveryInfo.Models
{
    public class Dates
    {
        public DateTime dateFirst { get; set; }
        public DateTime dateLast { get; set; }

        public event Action OnChange;
        
        public void SetDate(DateTime sdate, DateTime edate)
        {
            dateFirst = sdate;
            dateLast = edate;
            
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

    public class TrafficState
    {
        public bool trafState { get; set; }
        
    }

    public class ActivePageView
    {
        public bool list { get; set; }
        public bool card { get; set; }

        public void Set(string view)
        {
            if (view == "list")
            {
                list = true;
                card = false;
            }
            else if (view == "card")
            {
                list = true;
                card = true;
            }
            else
            {
                Console.WriteLine("Wrong View type, must be 'list' or 'card'");
            }
        }
              
    }
}
