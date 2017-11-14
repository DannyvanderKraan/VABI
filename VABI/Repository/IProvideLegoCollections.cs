using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Models;

namespace VABI.Repository
{
    public interface IProvideLegoCollections
    {
        Task<List<LegoCollection>> GetAll();
        Task<LegoCollection> Get(string id);
    }
}
