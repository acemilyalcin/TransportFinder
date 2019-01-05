using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportFinder
{
    public class TariffDetail : BaseClass
    {
        public long Hub { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public long Id { get; set; }
    }
}
