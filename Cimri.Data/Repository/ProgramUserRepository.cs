using Cimri.Data.Context;
using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Data.Repository
{
    public class ProgramUserRepository:BaseRepository<ProgramUser>
    {
        public ProgramUser VerifyUser(string GivenUsername, string GivenPassword, int GivenUserCompmanyId)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.ProgramUsers.FirstOrDefault(p => p.UserName == GivenUsername &&
                p.UserPassword == GivenPassword && p.UserCompanies.Any(u => u.UserCompanyId.Equals(GivenUserCompmanyId)));
            }
        }
    }
}
