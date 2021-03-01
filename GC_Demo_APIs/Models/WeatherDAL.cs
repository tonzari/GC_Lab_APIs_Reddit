using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GC_Demo_APIs.Models
{
    public class WeatherDAL
    {
        public string GetData(int lat, int lon)
        {
            //user agent
            string userAgent = "(grandcircus.com, antoniomanzari@gmail.com)";

            string url = @$"https://api.weather.gov/gridpoints/LWX/{lat},{lon}/forecast"; // set the url
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.UserAgent = userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public WeatherModel ConvertJsonToWeatherModel(int lat, int lon)
        {
            string data = GetData(lat, lon);
            WeatherModel weatherModel = JsonConvert.DeserializeObject<WeatherModel>(data);

            return weatherModel;
        }
    }
}
