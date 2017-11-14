using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Models;

namespace VABI.Repository
{
    public interface IStoreLegoSets
    {
        Task<LegoSet> Save(LegoSet legoSet);
    }
}
