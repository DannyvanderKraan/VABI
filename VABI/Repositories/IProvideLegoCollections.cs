using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Repositories
{
    public interface IProvideLegoCollections
    {
        Task<List<LegoCollection>> GetAll();
        Task<LegoCollection> Get(string id);
        Task<List<LegoBlockCollected>> GetLegoBlocksInCollection(string id);
    }
}
