using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class File:IEntityModel
    {
        public int FileRefId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
