using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportFinder;

namespace TransportFinder
{
    public class Address : BaseClass
    {
        public string Country { get; set; }
        public string City { get; set; }
        public long PostalCode { get; set; }
    }
}
