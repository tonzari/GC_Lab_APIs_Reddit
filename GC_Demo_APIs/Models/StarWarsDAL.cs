using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GC_Demo_APIs.Models
{
    // DAL: Data Access Layer
    public class StarWarsDAL
    {
        public string GetData(int id, string section)
        {
            string url = @$"https://swapi.dev/api/{section}/{id}/";
            HttpWebRequest request = WebRequest.CreateHttp(url); // set up a call to API server. Pass in a url.

            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // get our response an store it

            // Response codes
            // 200 means it worked
            // 404 means nothing found
            // 5** means there was a server error. server may be down, or your request is incorrect

            // The response has a stream. Feed the stream into a stream reader
            // then stuff the stream reader into a string
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public StarWarsCharacter ConverToSWCharacter(int id)
        {
            string data = GetData(id, "people");
            StarWarsCharacter swCharacter = JsonConvert.DeserializeObject<StarWarsCharacter>(data);

            return swCharacter;
        }

        public Planet ConverToPlanet(int id)
        {
            string data = GetData(id, "planets");
            Planet swPlanet = JsonConvert.DeserializeObject<Planet>(data);

            return swPlanet;
        }
    }
}
