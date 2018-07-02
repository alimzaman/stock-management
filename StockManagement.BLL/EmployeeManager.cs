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
       
        public EmployeeManager() : base(new EmployeeRepository())
        {
        }

        public override bool Add(Employee employee)
        {

            return base.Add(employee);
        }

        
    }
}
