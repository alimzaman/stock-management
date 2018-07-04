using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Repositories.Base;
using StockManagementApp.Models.Contracts;

namespace StockManagement.BLL.Base
{
    public abstract class Manager<T>:IDisposable where T:class
    {
        protected Repository<T> _repository;

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
            bool isDeleteable = entity is IDeletable;
            if (!isDeleteable)
            {
                throw new Exception("This Item is not Deleteable!");
            }
            return _repository.Remove((IDeletable)entity);
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual ICollection<T> GetAll(bool withDeleted=false)
        {
            return _repository.GetAll(withDeleted);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }
    }
}
