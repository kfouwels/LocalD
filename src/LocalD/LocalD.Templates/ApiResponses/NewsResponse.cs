using System.Collections.Generic;

namespace LocalD.Templates.ApiResponses
{
    public class NewsItem
    {
        // ReSharper disable InconsistentNaming

        public string id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string slug { get; set; }
        public string user { get; set; }
        public string town { get; set; }
        public string keywords { get; set; }

        // ReSharper restore InconsistentNaming
    }

    public class NewsResponseRootObject
    {
        public List<NewsItem> response { get; set; }
    }
}
