using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    class PeriodicServiceHistory
    {
        public int PeriodicServiceHistoryId { get; set; }
        public DateTime ServiceDate { get; set; }
        public double ServiceFee { get; set; }
    }
}
