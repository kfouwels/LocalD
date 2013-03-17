using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalD.Data.ApiResponses
{
    public class TownResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public int lat { get; set; }
        public int lon { get; set; }
        public int countyid { get; set; }
        public string keywords { get; set; }
    }

    public class TownResponseRootObject
    {
        public List<TownResponse> response { get; set; }
    }
}
