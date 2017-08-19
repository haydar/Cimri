using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    class PeriodicService
    {
        public int PeriodicServiceId { get; set; }
        public double ServiceFee { get; set; }
        public int ServicePeriodDay { get; set; }
        public DateTime NextServiceDate { get; set; }



    }
}
