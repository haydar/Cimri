using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Data.Context;
using System.Data.Entity;

namespace Cimri.Data.Repository
{
    public class UserCompanyRepository:BaseRepository<UserCompanyRepository>
    {
        public Cimri.Entity.UserCompany BringByIdWithCompany(int userCompanyId)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.UserCompanies.Include(t => t.CompanyInfos).FirstOrDefault(t => t.UserCompanyId == userCompanyId);
            }
            //lan çok ilginç :D değil anlatıcam, bussines'a ekle önce bunu, sonra cs tara
        }
    }
}
