using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;

namespace StockManagement.Repositories.Base
{
    public abstract class Repository<T> where T : class
    {
        StockDBContext db = new StockDBContext();
        public bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges()>0;
        }

        public bool Update(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public ICollection<T> GetAll(bool withDeleted = false)
        {
           return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }


    }
}
