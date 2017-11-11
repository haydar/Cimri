using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class FinancialTransaction
    {
        public int FinancialTransactionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public string Note { get; set; }
        public double Debt { get; set; }
        public double Paid { get; set; }
        [ForeignKey("Invoice")]
        public int? InvoiceId { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual Invoice Invoice { get; set; }
        public FinancialTransaction()
        {
            
        }

    }
}
