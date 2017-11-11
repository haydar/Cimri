using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class ProductTransaction
    {
        public int ProductTransactionId { get; set; }
        public int ProductNumber { get; set; }
        [Column(TypeName ="datetime2")]
        public DateTime Date { get; set; }
        public int TakenBy { get; set; }
        public int GivenBy { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        [ForeignKey("FinancialTransaction")]
        public int? FinancialTransactionId { get; set; }
        
        public virtual FinancialTransaction FinancialTransaction { get; set; }
        public virtual Stock Product { get; set; }
    }
}
