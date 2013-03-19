using System.Collections.Generic;
using LocalD.Templates;
using LocalD.Templates.ApiResponses;

namespace LocalD.Data
{
    public class FilingCabinet
    {
        public static List<TownResponse> TownsList = new List<TownResponse>();
        public static UserCredentials CurrentUserCredentials = new UserCredentials();
    }
    //todo dumping data to a json file in isolated storage
}
