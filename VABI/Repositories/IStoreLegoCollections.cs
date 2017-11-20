using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Repositories
{
    public interface IStoreLegoCollections
    {
        Task<LegoCollection> Save(LegoCollection legoCollection);

    }
}
