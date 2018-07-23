using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.BLL.Base;
using StockManagement.BLL.Contracts;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;
using StockManagement.Repositories.Base;
using StockManagement.Repositories.Contracts;
using StockManagementApp.Models.Contracts;

namespace StockManagement.BLL
{
    public class PartyManager:Manager<Party>,IPartyManager
    {
        private IPartyRepository _partyRepository;
        
        public PartyManager(IPartyRepository partyRepository) : base(partyRepository)
        {
            this._partyRepository = partyRepository;
        }
        public override bool Add(Party party)
        {
            if (string.IsNullOrEmpty(party.Name))
            {
                throw new Exception("Party Name is not provided!");
            }

            if (string.IsNullOrEmpty(party.ContactNo))
            {
                throw new Exception("Party Contact No is not provided!");
            }

            
            return _partyRepository.Add(party);
        }

        public ICollection<Party> GetByName(string name)
        {
            return _partyRepository.GetByName(name);
        }
        

       
       
    }
}
