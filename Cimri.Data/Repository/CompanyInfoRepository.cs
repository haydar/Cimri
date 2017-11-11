using Cimri.Data.Context;
using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Entity.DTO;

namespace Cimri.Data.Repository
{
    public class CompanyInfoRepository:BaseRepository<CompanyInfo>
    {
        CimriContext context = new CimriContext();
        public ICollection<CompanyInfoDto.CompanyHeader> FillDataGrid(int userCompanyId)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.CompanyInfos.Where(c => c.UserCompany.UserCompanyId.Equals(userCompanyId)).
                 Select(c => new CompanyInfoDto.CompanyHeader()
                 {
                        CompanyInfoId = c.CompanyInfoId,
                        Title = c.Title

                 }).ToList();
            }
               
        }

        public ICollection<CompanyInfoDto.CompanyHeader> Search(CompanyInfoDto.Search searchParameters)
        {
            return context.CompanyInfos.Where(c =>
             c.Title.StartsWith(searchParameters.Title) &&
             c.Tel.StartsWith(searchParameters.Tel) &&
             c.IsActive.Equals(searchParameters.IsActive) &&
             c.IsCustomer.Equals(searchParameters.IsCustomer) &&
             c.IsSupplier.Equals(searchParameters.IsSupplier) &&
             c.UserCompany.UserCompanyId.Equals(searchParameters.UserCompanyId)).
             Select(c => new CompanyInfoDto.CompanyHeader()
             {
                 CompanyInfoId = c.CompanyInfoId,
                 Title = c.Title
             }).ToList();


        }
    }
}
