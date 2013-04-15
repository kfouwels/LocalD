using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace LocalD.Services
{
    public class UserGeo
    {
        public async Task<Geoposition> GetGeoposition()
        {
            var loc = new Geolocator();
            return await loc.GetGeopositionAsync();
        }
    }
}
