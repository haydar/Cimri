using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class InvoiceDetailProduct
    {
        public int InvoiceDetailProductId { get; set; }
        public double ProductFee  { get; set; }
        public int ProductNumber { get; set; }

        //Navigation Property 
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<Stock>  Product { get; set; }

        public InvoiceDetailProduct()
        {
            Product = new HashSet<Stock>();
        }
    }
}
