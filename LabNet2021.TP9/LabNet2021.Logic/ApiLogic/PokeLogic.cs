using LabNet2021.Models.PokeModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic.ApiLogic
{
    public class PokeLogic
    {
        public string Url { get; set; }
        PokeListView result;
        string response;

        public PokeLogic()
        {
            Url = "https://pokeapi.co/api/v2/pokemon?limit=150&offset=0";
            response = string.Empty;
            result = new PokeListView();
        }
        
        public PokeListView ListPoket()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                    result = Deserialize<PokeListView>(response);                    
                    return result;
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
