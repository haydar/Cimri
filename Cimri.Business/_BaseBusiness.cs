using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Data.Repository;
using Cimri.Entity.DTO;

namespace Cimri.Business
{
    public  class BaseBusiness<Tentity> where Tentity : class
    {
        BaseRepository<Tentity> repo = new BaseRepository<Tentity>();

        // Add, Update, Delete, BringAll and BringByID with generic type.

        public void Add(Tentity data, out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                repo.Add(data);
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "İşlem başarısız. Beklenmedik Hata. \n";
                error.ErrorMessage = ex.Message;
            }         
        }

        public void Update(Tentity data, out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                repo.Update(data);
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "İşlem başarısız. Beklenmedik Hata. \n";
                error.ErrorMessage = ex.Message;
            }
          
        }

        public void Delete(Tentity data, out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                repo.Delete(data);
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "İşlem başarısız. Beklenmedik Hata. \n";
                error.ErrorMessage = ex.Message;
            }
        }

        public List<Tentity> BringAll(out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                return repo.BringAll();
            }
            catch (Exception ex)
            {
                error.ProcessResult = false;
                error.Description = "İşlem başarısız. Beklenmedik Hata. \n";
                error.ErrorMessage = ex.Message;
                return null;
            }
            
        }

        public Tentity BringById(int id, out ErrorDto error)
        {
            error = new ErrorDto();

            try
            {
                return repo.BringById(id);
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
