﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class InvoiceDetailService
    {
        public int InvoiceDetailServiceId { get; set; }
        public double ServiceFee { get; set; }
        public int ServiceNumber { get; set; }

        //Navigation Property 
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<Service> Service { get; set; }

        public InvoiceDetailService()
        {
            Service = new HashSet<Service>();
        }

    }
}
