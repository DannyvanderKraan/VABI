using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Models
{
    public class LegoSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("legoBlocks")]
        public List<LegoBlockCollected> LegoBlocks { get; set; } = new List<LegoBlockCollected>();
    }
}
