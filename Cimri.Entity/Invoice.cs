using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InvoiceDate { get; set; }

        [ForeignKey("ProductTransactions")]
        public int? ProductTransactionId { get; set; }
       
        [ForeignKey("ServiceTransactions")]
        public int? ServiceTransactionId { get; set; }
        
        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }
        public virtual ICollection<ServiceTransaction> ServiceTransactions { get; set; }
        public Invoice()
        {
            ProductTransactions = new HashSet<ProductTransaction>();
            ServiceTransactions = new HashSet<ServiceTransaction>();
        }

    }
}
