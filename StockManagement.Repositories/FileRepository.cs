using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories.Base;

namespace StockManagement.Repositories
{
    public class FileRepository:Repository<File>
    {
        public FileRepository(DbContext db) : base(db)
        {
        }
    }
}
