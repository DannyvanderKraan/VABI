﻿using System;
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
            List<LegoBlockCollected> xLegoBlocks = x.LegoBlocks.OrderBy(b => b.Id).ToList();
            List<LegoBlockCollected> yLegoBlocks = y.LegoBlocks.OrderBy(b => b.Id).ToList();
            if (x.Id == y.Id && xLegoBlocks.SequenceEqual(yLegoBlocks, new LegoBlockCollectedEqualityComparer())) return true;
            return false;
        }

        public int GetHashCode(LegoSet obj)
        {
            return 0;
        }
    }
}
