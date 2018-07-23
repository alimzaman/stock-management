using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.BLL.Base;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;
using StockManagement.Repositories.Base;

namespace StockManagement.BLL
{
    public class EmployeeManager : Manager<Employee>
    {
       
        public EmployeeManager(EmployeeRepository repository) : base(repository)
        {
        }

        public override bool Add(Employee employee)
        {
            EmployeeRepository repository = new EmployeeRepository();


            return base.Add(employee);
        }

        
    }
}
