using System.ComponentModel.DataAnnotations;
using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class Product :IEntityModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}