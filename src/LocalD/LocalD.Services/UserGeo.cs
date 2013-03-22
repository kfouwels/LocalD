using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
