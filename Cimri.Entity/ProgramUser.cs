using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity
{
    public class ProgramUser
    {
        public int ProgramUserId { get; set; }
        public string UserName { get; set; }
        public string UserRealName{ get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }

        //Navigation Property
        public virtual ICollection<UserCompany> UserCompanies { get; set; }

        public ProgramUser()
        {
            UserCompanies = new HashSet<UserCompany>();
        }
    }
}
