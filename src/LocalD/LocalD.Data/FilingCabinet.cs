using System.Collections.Generic;
using LocalD.Templates;
using LocalD.Templates.ApiResponses;
using Windows.Devices.Geolocation;

namespace LocalD.Data
{
    public static class FilingCabinet
    {
        public static List<TownItem> TownsList = new List<TownItem>();
        public static UserCredentials CurrentUserCredentials = new UserCredentials();
        public static Geoposition UserPos;
    }
    //todo dumping data to a json file in isolated storage
}
