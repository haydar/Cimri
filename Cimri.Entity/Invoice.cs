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

        [ForeignKey("InvoiceDetailProduct")]
        public int? InvoiceDetailProductId{ get; set; }
       
        [ForeignKey("InvoiceDetailService")]
        public int? InvoiceDetailServiceId { get; set; }
        

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual ICollection< InvoiceDetailProduct> InvoiceDetailProduct { get; set; }
        public virtual ICollection< InvoiceDetailService> InvoiceDetailService { get; set; }

        public Invoice()
        {
           
        }

    }
}
