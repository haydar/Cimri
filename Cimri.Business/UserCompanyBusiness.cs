using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Data.Repository;

namespace Cimri.Business
{
    public class UserCompanyBusiness:BaseBusiness<UserCompany>
    {
        UserCompanyRepository repo = new UserCompanyRepository();
        public UserCompany BringByIdWithCompany(int userCompanyId)
        {
            return repo.BringByIdWithCompany(userCompanyId);
        }
    }
}
