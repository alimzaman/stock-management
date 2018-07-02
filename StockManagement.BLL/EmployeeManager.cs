using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;

namespace StockManagement.BLL
{
    public class EmployeeManager
    {
        EmployeeRepository _employeeRepository= new EmployeeRepository();


       public bool Add(Employee employee)
        {
            return _employeeRepository.Add(employee);
        }
    }
}
