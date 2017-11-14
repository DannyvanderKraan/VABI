using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Configuration
{
    public class LegoCollectorCosmosDbSettings
    {
        public string EndpointUri { get; set; }
        public string PrimaryKey { get; set; }
        public string DatabaseName { get; set; }
    }
}
