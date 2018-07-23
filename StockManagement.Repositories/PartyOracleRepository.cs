using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories.Base;
using StockManagement.Repositories.Contracts;

namespace StockManagement.Repositories
{
    public class PartyOracleRepository:Repository<Party>,IPartyRepository
    {
        public ICollection<Party> GetByName(string name)
        {
            //ORACLE Code 
            return null;
        }

        public PartyOracleRepository(DbContext db) : base(db)
        {
        }
    }
}
