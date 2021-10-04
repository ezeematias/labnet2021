using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Models.PokeModels
{
    public class PokeStatsView
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}
