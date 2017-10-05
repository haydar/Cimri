using Cimri.Data.Migrations;
using Cimri.Data.Repository;
using Cimri.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Entity.DTO;

namespace Cimri.Business
{
    public class CompanyInfoBusiness:BaseBusiness<CompanyInfo>
    {
        CompanyInfoRepository repo = new CompanyInfoRepository();
        public ICollection<CompanyInfoDto.CompanyHeader> FillDataGrid(int userCompanyId, out string error)
        {
            error = null;
            try
            {
                return repo.FillDataGrid(userCompanyId);
            }
            catch (Win32Exception)
            {
                error += "Veritabanına bağlanmaya çalışırken işlem zaman aşamına uğradı." +
                         "İşletim sistemi veya başka yazılımların sabit diskinizde aşırı " +
                         "işlem görmesi bu soruna neden olabilir.";
                return null;
            }
           
        }
    }
}
