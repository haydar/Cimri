using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class CompanyInfo
    {
        public int UserCompanyId { get; set; }
        public string Title { get; set; }
        public string AdressCity { get; set; }
        public string AddressNeighborhood { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNo { get; set; }
        public string AdressFloor { get; set; }
        public string TaxNo { get; set; }
        public string TaxAdministration { get; set; }
        public string AuthorizedPerson { get; set; }
        public bool AuthorizedPersonGender { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string TradeRegistryNo { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }


        //Navigation Property
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PeriodicService> PeriodicServices{ get; set; }
        public virtual ICollection<FinancialTransaction> FinancialTransactions { get; set; }

        public CompanyInfo()
        {
            UserCompanies = new HashSet<UserCompany>();
            Invoices = new HashSet<Invoice>();
            PeriodicServices = new HashSet<PeriodicService>();
            FinancialTransactions = new HashSet<FinancialTransaction>();
        }
    }
}
