using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Demo_APIs.ViewModels
{
    public class RedditPostViewModel
    {
        public string Title { get; set; }
        public string subredditName { get; set; }
        public string url { get; set; }
        public string thumbUrl { get; set; }
        public DateTimeOffset dateCreated { get; set; }
    }
}
