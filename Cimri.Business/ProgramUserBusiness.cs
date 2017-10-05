using Cimri.Entity;
using Cimri.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Business
{
    public  class ProgramUserBusiness:BaseBusiness<ProgramUser>
    {
        ProgramUserRepository repo = new ProgramUserRepository();

        public void VerifyUser(ref string GivenUsername, ref string GivenPassword, ref int GivenUserCompmanyID,
                               out string error, out ProgramUser LoggedInUser,out bool isThereError)
        {
            LoggedInUser=null;
            isThereError = false;
            error = "Aşağıdaki alanlar boş geçilemez: \n\n";
            
            #region CheckFields
            if (string.IsNullOrEmpty(GivenUsername))
            {
                error += "- Kullanıcı Adı\n";
                isThereError = true;
            }

            if (string.IsNullOrEmpty(GivenPassword))
            {
                error += "- Şifre\n";
                isThereError = true;
            }
            #endregion

            else
            {
                try
                {
                    LoggedInUser = repo.VerifyUser(GivenUsername, GivenPassword, GivenUserCompmanyID);
                }
                catch (Exception ex)
                {
                    error += "Kullanıcı yetki doğrulaması yaparken şu hata ile karşılaşıldı; \n" + ex.Message;
                    isThereError = true;
                }
                if (LoggedInUser==null)
                {
                    error = string.Empty;
                    error = "Girdiğiniz kullancı adı veya şifre seçili firma için geçerli değil.";
                    isThereError = true;
                }
            }
        }
    }
}
