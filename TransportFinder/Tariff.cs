using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportFinder;

namespace TransportFinder
{
    public class Tariff : BaseClass
    {
        public long Hub { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public long Id { get; set; }
    }
}
