using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories.Base;

namespace StockManagement.Repositories
{
    public class EmployeeRepository:Repository<Employee>
    {
    }
}
