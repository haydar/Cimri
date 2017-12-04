using Cimri.Data.Repository;
using Cimri.Entity;
using Cimri.Entity.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Business
{
    public class StockBusiness:BaseBusiness<Stock>
    {
        StockRepository repo = new StockRepository();
        public ICollection<StockDto.StockHeader> FillDataGrid(int userCompanyId, out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                return repo.FillDataGrid(userCompanyId);
            }
            catch (Win32Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "Veritabanına bağlanmaya çalışırken işlem zaman aşamına uğradı." +
                         "İşletim sistemi veya başka yazılımların sabit diskinizde aşırı " +
                         "işlem görmesi bu soruna neden olabilir.  \n";
                error.ErrorMessage = ex.Message;
                return null;
            }
            catch(NullReferenceException ex)
            {
                error.ProcessResult = false;
                error.Description = "Kayıtlı bir ürün bulunamadı.  \n";
                error.ErrorMessage = ex.Message;
                return null;
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "İşlem başarısız. Beklenmedik Hata. \n";
                error.ErrorMessage = ex.Message;
                return null;
            }
        }
    }
}
