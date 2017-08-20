using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string StockUnit { get; set; }
        public int StockNumber { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
