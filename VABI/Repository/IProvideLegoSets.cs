using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Models;

namespace VABI.Repository
{
    public interface IProvideLegoSets
    {
        Task<List<LegoSet>> GetAll();
        Task<LegoSet> Get(string id);
        Task<List<LegoSet>> GetByLegoBlocksInCollection(List<LegoBlockCollected> legoBlocksInCollection);
    }
}
