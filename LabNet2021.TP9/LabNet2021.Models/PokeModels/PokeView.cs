using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNet2021.Models.PokeModels
{
    public class PokeView
    {
        [JsonProperty("name")]
        public string NamePokemon { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

}