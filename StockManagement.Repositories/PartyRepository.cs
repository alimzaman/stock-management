using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories.Base;
using StockManagement.Repositories.Contracts;

namespace StockManagement.Repositories
{
    public class PartyRepository:DeleteableRepository<Party>,IPartyRepository
    {
        public StockDBContext StockDbContext {
            get
            {
                return db as StockDBContext;
        
            }
        }

        public ICollection<Party> GetByName(string name)
        {
            return Get(c => c.Name.Contains(name));
        }

        public ICollection<Party> GetParties()
        {
           return StockDbContext.Parties.ToList();
        }

        public PartyRepository(DbContext db) : base(db)
        {
        }
    }
}
