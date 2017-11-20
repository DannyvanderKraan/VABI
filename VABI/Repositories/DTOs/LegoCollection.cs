using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Repositories.DTOs
{
    public class LegoCollection
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("legoBlocks")]
        public List<LegoBlockCollected> LegoBlocks { get; set; } = new List<LegoBlockCollected>();

        [JsonProperty("legoSets")]
        public List<string> LegoSets { get; set; } = new List<string>();
    }
}
