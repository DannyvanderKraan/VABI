using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Models;

namespace VABI.Repository
{
    public class LegoBlockInCollectionEqualityComparer : IEqualityComparer<LegoBlockCollected>
    {
        public bool Equals(LegoBlockCollected x, LegoBlockCollected y)
        {
            return x.Id == y.Id && x.Amount >= y.Amount;
        }

        public int GetHashCode(LegoBlockCollected obj)
        {
            return 0;
        }
    }
}
