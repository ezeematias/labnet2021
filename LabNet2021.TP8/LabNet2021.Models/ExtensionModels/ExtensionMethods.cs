using LabNet2021.Models.PokeModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic.ExtensionModels
{
    public static class ExtensionMethods
    {
        public static long PokeWeight(this PokeView pokeView)
        {
            PokeStatsView pokeStats;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(pokeView.Url);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string response = streamReader.ReadToEnd();
                    pokeStats = Deserialize<PokeStatsView>(response);
                    return pokeStats.Weight;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Deserialize<T>(string jsonData)
        {
            JsonSerializer json = new JsonSerializer();
            return json.Deserialize<T>(new JsonTextReader(new StringReader(jsonData)));
        }

    }
}
