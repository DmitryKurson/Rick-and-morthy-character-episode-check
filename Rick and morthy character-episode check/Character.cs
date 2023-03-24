using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System;
using RestSharp;
using Newtonsoft.Json;

namespace Rick_and_morthy_character_episode_check
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string origin { get; set; }
        public string location { get; set; }
        public string image { get; set; }
        public string episode { get; set; }
        public string url { get; set; }
        public string created { get; set; }

        public static Character[] GetCharacters()
        {
            string json = "https://rickandmortyapi.com/api/character";
            var mydata = JsonConvert.DeserializeObject<Rootobject>(json);
            //var client = new RestClient();
            //var request = new RestRequest("character");
            //var response = client.Execute(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    string rawResponse = response.Content;
            //    Rootobject cr = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
            //}
            return null;// mydata.character;
        }
    }  
}
