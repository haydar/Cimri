using System;

namespace Cimri.Entity.DTO
{
    public class CompanyInfoDto
    {
        public class CompanyHeader
        {
            public int CompanyInfoId { get; set; }
            public string Title { get; set; }
        }
        public class Search
        {
            public string Title { get; set; }
            public string Tel { get; set; }
            public bool IsSupplier { get; set; }
            public bool IsCustomer { get; set; }
            public bool IsActive { get; set; }

            public int UserCompanyId { get; set; }

        }
    }
}
