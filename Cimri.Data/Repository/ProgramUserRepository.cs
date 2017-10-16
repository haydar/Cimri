using Cimri.Data.Context;
using Cimri.Entity;
using Cimri.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Data.Repository
{
    public class ProgramUserRepository:BaseRepository<ProgramUser>
    {
        public ProgramUser VerifyUser(VerifyUserDto loginInfo)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.ProgramUsers.FirstOrDefault(p => p.UserName == loginInfo.GivenUsername &&
                p.UserPassword == loginInfo.GivenPassword && p.UserCompanies.Any(u => u.UserCompanyId.Equals(loginInfo.GivenUserCompanyId)));
            }
        }
    }
}
