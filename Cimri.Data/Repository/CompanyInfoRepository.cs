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
        public ICollection<CompanyInfoDto.CompanyHeader> FillDataGrid(int userCompanyId)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.CompanyInfos.Where(c => c.UserCompany.UserCompanyId.Equals(userCompanyId)).
                Select(c => new  CompanyInfoDto.CompanyHeader() {
                CompanyInfoId = c.CompanyInfoId,
                Title = c.Title

            }).ToList();

            }
               
        }
    }
}
