using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Repositories.DTOs
{
    public class LegoBlock
    {
        [JsonProperty("id")]
        public string Id { get; set; }

    }
}
