using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class ServiceTransaction
    {
        public int ServiceTransactionId { get; set; }
        public int ServiceNumber { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        public double ServicePrice { get; set; }
        public string Description { get; set; }
        [ForeignKey("FinancialTransaction")]
        public int? FinancialTransactionId { get; set; }

        public virtual FinancialTransaction FinancialTransaction { get; set; }
        public virtual Service Service { get; set; }
    }
   
}
