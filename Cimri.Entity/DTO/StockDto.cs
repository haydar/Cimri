using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity.DTO
{
    public class StockDto
    {        
        public class StockHeader
        {
            public int StockId { get; set; }
            public string StockName { get; set; }
            public int? Quantity { get; set; }

            /* public int? Quantity
             {  
                 get
                 {
                     if (this.Quantity == null)
                     {
                         Quantity = 0;
                     }
                     else { Quantity = this.Quantity; }
                     return this.Quantity;
                 }
                 set
                 {

                 }
             }*/

        }
    }
}
