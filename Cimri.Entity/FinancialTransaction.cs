using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class FinancialTransaction
    {
        public int FinancialTransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public string Note { get; set; }
        public double Debt { get; set; }
        public double Paid { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }

        public FinancialTransaction()
        {
            
        }

    }
}
