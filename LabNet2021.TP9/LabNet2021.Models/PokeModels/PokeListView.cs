using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNet2021.Models.PokeModels
{
    public class PokeListView
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public Uri Previous { get; set; }

        [JsonProperty("results")]
        public List<PokeView> ListPokemons { get; set; }
    }
}