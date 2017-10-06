using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
   public class PeriodicServiceHistory
    {
        public int PeriodicServiceHistoryId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ServiceDate { get; set; }
        public double ServiceFee { get; set; }

        //Navigation Property

        public virtual PeriodicService PeriodicService { get; set; }

        public PeriodicServiceHistory()
        {

        }
    }
}
