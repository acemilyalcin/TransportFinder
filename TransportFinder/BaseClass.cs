
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportFinder
{
    public abstract class BaseClass
    {
        public long ID { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
