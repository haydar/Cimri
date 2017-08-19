using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    class Invoice
    {
        public int InvoiceId { get; set; }
        public string Description { get; set; }
        public DateTime InvoiceDate { get; set; }

    }
}
