using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class Category:IEntityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Product> Products { get; set; }
       
    }
}
