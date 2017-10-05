using Cimri.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Data.Repository
{
    public class BaseRepository<TEntity> where TEntity:class
    {
        CimriContext context = new CimriContext();

        // Add, Update, Delete, BringAll and BringByID with generic type.

        public void Add(TEntity data)
        {
            context.Set<TEntity>().Add(data);
            context.SaveChanges();
        }

        public void Update(TEntity data)
        {
            context.Entry(data).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity data)
        {
            context.Set<TEntity>().Remove(data);
            context.SaveChanges();
        }
        public TEntity BringById(int id)
        {
            using (CimriContext context = new CimriContext())
            {
                return context.Set<TEntity>().Find(id);
            }
           
        }
        public List<TEntity> BringAll()
        {
            return context.Set<TEntity>().ToList();
        }
       
    }
}
