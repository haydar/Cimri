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
        public DateTime InvoiceDate { get; set; }
        [ForeignKey("InvoiceDetailProductsId")]
        public int? InvoiceDetailProductsId { get; set; }
        [ForeignKey("InvoiceDetailServicesId")]
        public int? InvoiceDetailServicesId { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual InvoiceDetailProduct InvoiceDetailProducts { get; set; }
        public virtual InvoiceDetailService InvoiceDetailServices { get; set; }

        public Invoice()
        {
            InvoiceDetailProducts = new InvoiceDetailProduct();
            InvoiceDetailServices = new InvoiceDetailService();
        }

    }
}
