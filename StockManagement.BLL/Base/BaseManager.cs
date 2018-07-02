using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Repositories.Base;

namespace StockManagement.BLL.Base
{
    public abstract class Manager<T> where T:class
    {
        private Repository<T> _repository;

        public Manager(Repository<T> repository)
        {
            _repository = repository;
        }


        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Remove(T entity)
        {
            return false;
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual ICollection<T> GetAll(bool withDeleted=false)
        {
            return _repository.GetAll(withDeleted);
        }
    }
}
