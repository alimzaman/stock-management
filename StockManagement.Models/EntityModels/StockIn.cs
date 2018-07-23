using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class StockIn:IEntityModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StockDate { get; set; }
        public int? PartyId { get; set; }

        public Party Party { get; set; }
        public List<StockInDetail> StockInDetails { get; set; }

    }
}
