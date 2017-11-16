using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VABI.Models;

namespace VABI.Tests.Unit.Utils
{
    public class LegoSetEqualityComparer : IEqualityComparer<LegoSet>
    {
        public bool Equals(LegoSet x, LegoSet y)
        {
            if(x.Id == y.Id && x.LegoBlocks.OrderBy(b => b.Id).SequenceEqual(y.LegoBlocks.OrderBy(b => b.Id))) return true;
            return false;
        }

        public int GetHashCode(LegoSet obj)
        {
            return 0;
        }
    }
}
