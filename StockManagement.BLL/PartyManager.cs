using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;

namespace StockManagement.BLL
{
    public class PartyManager
    {
        PartyRepository repository = new PartyRepository();
        public bool Add(Party party)
        {
            if (string.IsNullOrEmpty(party.Name))
            {
                throw new Exception("Party Name is not provided!");
            }

            if (string.IsNullOrEmpty(party.ContactNo))
            {
                throw new Exception("Party Contact No is not provided!");
            }

            return repository.Add(party);
        }

        public bool Update(Party party)
        {
            return repository.Update(party);
        }

        public bool Remove(Party party)
        {
            return repository.Remove(party);
        }

        public List<Party> GetAll(bool withDeleted=false)
        {
            return repository.GetAll(withDeleted);
        }

        public Party GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
