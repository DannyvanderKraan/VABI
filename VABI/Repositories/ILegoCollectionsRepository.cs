using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Repositories
{
    public interface ILegoCollectionsRepository: IProvideLegoCollections, IStoreLegoCollections
    {
    }
}
