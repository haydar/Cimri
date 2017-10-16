using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Entity.DTO
{
    public class VerifyUserDto
    {
        public int GivenUserCompanyId { get; set; }
        public string GivenUsername { get; set; }
        public string GivenPassword { get; set; }
    }
}
