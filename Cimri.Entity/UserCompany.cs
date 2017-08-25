using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
  public  class UserCompany
    {
        public int UserCompanyId { get; set; }
        public string Title { get; set; }
        public string AdressCity { get; set; }
        public string AdressNeighborhood { get; set; }
        public string AdressStreet { get; set; }
        public string AdressNo { get; set; }
        public string AdressFloor { get; set; }
        public string TaxNo { get; set; }
        public string TaxAdministration { get; set; }
        public string LogoPath { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string TradeRegistryNo { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        // Navigation Property
        public virtual ICollection<ProgramUser> ProgramUsers { get; set; }
        public virtual ICollection<CompanyInfo> CompanyInfos { get; set; }
        public virtual ICollection<PeriodicService> PeriodicServices { get; set; }
        public virtual ICollection<FinancialTransaction> FinancialTransactions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Service> Services  { get; set; }
        public virtual ICollection<Stock> Products { get; set; }

        public UserCompany()
        {
            ProgramUsers = new HashSet<ProgramUser>();
            CompanyInfos = new HashSet<CompanyInfo>();
            PeriodicServices = new HashSet<PeriodicService>();
            FinancialTransactions = new HashSet<FinancialTransaction>();
            Invoices = new HashSet<Invoice>();
            Services = new HashSet<Service>();
            Products = new HashSet<Stock>();
        }
    }
}
