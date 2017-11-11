using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public double ServiceFee { get; set; }
        public string Description { get; set; }
        [ForeignKey("UserCompany")]
        public int UserCompanyId { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany { get; set; }
        public ICollection<ServiceTransaction> ServiceTransaction { get; set; }

        public Service()
        {
            ServiceTransaction = new HashSet<ServiceTransaction>();
        }
    }
}
