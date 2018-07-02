using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class Employee:IEntityModel,IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public bool IsDeleted { get; set; }
        public bool Delete()
        {
            IsDeleted = true;
            return true;
        }
    }
}
