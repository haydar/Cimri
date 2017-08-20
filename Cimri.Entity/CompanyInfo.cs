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
        public string AdressNeighborhood { get; set; }
        public string AdressStreet { get; set; }
        public string AdressNo { get; set; }
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
    }
}
