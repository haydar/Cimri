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
using KellermanSoftware.CompareNetObjects;

namespace Cimri.Business
{
    public class CompanyInfoBusiness:BaseBusiness<CompanyInfo>
    {
        CompanyInfoRepository repo = new CompanyInfoRepository();
        public ICollection<CompanyInfoDto.CompanyHeader> FillDataGrid(int userCompanyId, out ErrorDto error)
        {
            error = new ErrorDto();
            try
            {
                return repo.FillDataGrid(userCompanyId);
            }
            catch (Win32Exception ex)
            {
                error.ProcessResult = false;
                error.Description="Veritabanına bağlanmaya çalışırken işlem zaman aşamına uğradı." +
                         "İşletim sistemi veya başka yazılımların sabit diskinizde aşırı " +
                         "işlem görmesi bu soruna neden olabilir.";
                error.ErrorMessage = ex.Message;
                return null;
            }
        }
        public bool Compare(CompanyInfo cachedCurrentCompany, CompanyInfo currentCompany)
        {
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult result = compareLogic.Compare(cachedCurrentCompany, currentCompany);

            return result.AreEqual;
        }

        public ICollection<CompanyInfoDto.CompanyHeader> Search(CompanyInfoDto.Search searchParameters, out ErrorDto error)
        {
            error = new ErrorDto();
            try
            {
                return repo.Search(searchParameters);
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "Firmayı aramaya çalışırken işlem bilinmeyen nedenle yürüyülemedi.";
                error.ErrorMessage = ex.Message;
                return null;
            }
           
        }
    }
  
}
