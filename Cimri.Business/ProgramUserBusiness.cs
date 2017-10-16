using Cimri.Entity;
using Cimri.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Entity.DTO;

namespace Cimri.Business
{
    public  class ProgramUserBusiness:BaseBusiness<ProgramUser>
    {
        ProgramUserRepository repo = new ProgramUserRepository();

        public void VerifyUser(ref VerifyUserDto loginRequestInfo, out ProgramUser loggedInUser, out ErrorDto error)
        {
            loggedInUser = null;
            error = new ErrorDto();
            try
            {
                loggedInUser = repo.VerifyUser(loginRequestInfo);
                if (loggedInUser==null)
                {
                    error.ProcessResult = false;
                    error.Description = "Seçili firmaya ait girilen kullanıcı adı ve şifreli bir hesap bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "Kullanıcı doğrulanırken nedeni bilinmeyen bir hatayla karşılaşıldı.";
                error.ErrorMessage = ex.Message;
            }
        }
    }
}
