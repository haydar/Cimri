using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class PeriodicService
    {
        public int PeriodicServiceId { get; set; }
        public double ServiceFee { get; set; }
        public int ServicePeriodDay { get; set; }
        public DateTime PeriodicServiceCreatedDate { get; set; }
        public DateTime NextServiceDate { get; set; }
        public DateTime LastServiceDateByAgreement { get; set; }
        public bool IsActive { get; set; }
        public string ServiceAgreementPath { get; set; }

        //Navigation Property
        public virtual Service Service { get; set; }
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual ICollection<PeriodicServiceHistory> PeriodicServiceHistories { get; set; }
        public virtual UserCompany UserCompany { get; set; }

        public PeriodicService()
        {
            PeriodicServiceHistories = new HashSet<PeriodicServiceHistory>();
        }

    }
}
