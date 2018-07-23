using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;

namespace StockManagement.Repositories.Contracts
{
    public interface IPartyRepository:IRepository<Party>
    {
        ICollection<Party> GetByName(string name);
        ICollection<Party> GetParties();
    }
}
