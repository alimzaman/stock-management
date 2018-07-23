using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using StockManagement.BLL.Contracts;
using StockManagement.Repositories.Base;
using StockManagement.Repositories.Contracts;
using StockManagementApp.Models.Contracts;

namespace StockManagement.BLL.Base
{
    public abstract class Manager<T>:IManager<T> where T:class,IEntityModel
    {
        protected IRepository<T> _repository;

        public Manager(IRepository<T> repository)
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

        public virtual bool Remove(IDeletable entity)
        {
            bool isDeleteable = entity is IDeletable;
            if (!isDeleteable)
            {
                throw new Exception("This Item is not Deleteable!");
            }
            return _repository.Remove((IDeletable)entity);
        }

        public bool Remove(ICollection<IDeletable> entities)
        {
           return _repository.Remove(entities);
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
