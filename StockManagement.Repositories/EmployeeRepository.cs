using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;

namespace StockManagement.Repositories
{
    public class EmployeeRepository
    {
        StockDBContext db = new StockDBContext();

        public bool Add(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Entry(employee).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Employee employee)
        {
            employee.IsDeleted = true;
            return Update(employee);
        }

        public Employee GetById(int id)
        {
            return db.Employees.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Employee> GetAll(bool withDeleted=false)
        {
            return db.Employees.Where(c=>c.IsDeleted==false||c.IsDeleted==withDeleted).ToList();
        }


    }
}
