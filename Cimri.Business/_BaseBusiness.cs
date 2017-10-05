using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cimri.Data.Repository;

namespace Cimri.Business
{
    public  class BaseBusiness<Tentity> where Tentity : class
    {
        BaseRepository<Tentity> repo = new BaseRepository<Tentity>();

        // Add, Update, Delete, BringAll and BringByID with generic type.

        public void Add(Tentity data)
        {
            repo.Add(data);
        }

        public void Update(Tentity data)
        {
            repo.Update(data);
        }

        public void Delete(Tentity data)
        {
            repo.Delete(data);
        }

        public List<Tentity> BringAll()
        {
           return repo.BringAll();
        }

        public Tentity BringById(int id)
        {
            return repo.BringById(id);
        }
    }
}
