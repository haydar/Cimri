using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "datetime2")]
        public DateTime PeriodicServiceCreatedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime NextServiceDate { get; set; }
        [Column(TypeName = "datetime2")]
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
