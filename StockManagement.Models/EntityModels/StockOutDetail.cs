using StockManagementApp.Models.Contracts;

namespace StockManagement.Models.EntityModels
{
    public class StockOutDetail:IEntityModel
    {
        public int Id { get; set; }
        public int StockOutId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public StockOut StockOut { get; set; }
        public Product Product { get; set; }


    }
}