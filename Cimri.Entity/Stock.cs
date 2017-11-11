using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int CurrentUnitPrice { get; set; }
        public string Description { get; set; }

        [ForeignKey("UserCompany")]
        public int UserCompanyId { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }

        public Stock()
        {
            ProductTransactions = new HashSet<ProductTransaction>();
        }
    }
}
