using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class Inventory:IEntityModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public Product Product { get; set; }

    }
}
