using System;
using System.Collections.Generic;
using System.Text;
using VABI.Repositories.DTOs;

namespace VABI.Tests.Unit.Utils
{
    public class LegoBlockCollectedDTOEqualityComparer : IEqualityComparer<LegoBlockCollected>
    {
        public bool Equals(LegoBlockCollected x, LegoBlockCollected y)
        {
            return x.Id == y.Id && x.Amount == y.Amount;
        }

        public int GetHashCode(LegoBlockCollected obj)
        {
            return 0;
        }
    }
}
