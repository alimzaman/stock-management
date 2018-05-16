using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;

namespace StockManagement.Models.ViewModels
{
    public class StockInCreateVM
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StockDate { get; set; }

        [NotMapped]
        public List<Category> Categories { get; set; }
        [NotMapped]
        public List<StockInDetail> StockInDetails { get; set; }

    }
}
