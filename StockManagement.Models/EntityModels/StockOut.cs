using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class StockOut:IEntityModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StockOutDate { get; set; }

        public List<StockOutDetail> StockOutDetails { get; set; }

    }
}
