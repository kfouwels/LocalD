using System.Collections.Generic;

namespace LocalD.Templates.ApiResponses
{
    public class TownResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public int countyid { get; set; }
        public string keywords { get; set; }
    }

    public class TownResponseRootObject
    {
        public List<TownResponse> response { get; set; }
    }
}
