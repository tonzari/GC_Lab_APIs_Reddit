using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace GC_Demo_APIs.Models
{
    public class RedditDAL
    {
        public string GetData(string subreddit)
        {
            string url = @$"https://www.reddit.com/r/{subreddit}/.json";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public RedditModel ConvertDataToRedditModel(string subreddit)
        {
            string data = GetData(subreddit);
            RedditModel redditModel = JsonConvert.DeserializeObject<RedditModel>(data);

            return redditModel;
        }
    }
}
