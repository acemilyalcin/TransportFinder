using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportFinder;

namespace TransportFinder
{
    public class TariffTemplateDetail : BaseClass
    {
        public long TariffNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DayofWeekArrival { get; set; }
        public string DayofWeekDeparture { get; set; }
        public long ArrivalTime { get; set; }
        public long Hub { get; set; }
    }
}
