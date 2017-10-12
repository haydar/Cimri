
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class CompanyInfo
    {
        public int CompanyInfoId { get; set; }
        public string Title { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressNeighborhood { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNo { get; set; }
        public string AddressFloor { get; set; }
        public string TaxNo { get; set; }
        public string TaxAdministration { get; set; }
        public string AuthorizedPerson { get; set; }
        public bool AuthorizedPersonGender { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string TradeRegistryNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public string Iban { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsCustomer { get; set; }
        [ForeignKey("UserCompany")]
        public int UserCompanyId { get; set; }

        //Navigation Property
        public virtual UserCompany UserCompany{ get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PeriodicService> PeriodicServices{ get; set; }
        public virtual ICollection<FinancialTransaction> FinancialTransactions { get; set; }

        public CompanyInfo()
        {
            Invoices = new HashSet<Invoice>();
            PeriodicServices = new HashSet<PeriodicService>();
            FinancialTransactions = new HashSet<FinancialTransaction>();
        }
    }
}
