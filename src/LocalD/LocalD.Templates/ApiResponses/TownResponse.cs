using System.Collections.Generic;

namespace LocalD.Templates.ApiResponses
{
    public class TownItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string countyid { get; set; }
        public string keywords { get; set; }
    }

    public class TownResponseRootObject
    {
        public List<TownItem> response { get; set; }
    }
}
