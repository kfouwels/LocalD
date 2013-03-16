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
        public static string UserCity = "Geo Not updated";

        public async Task<bool> UpdateGeoCity()
        {
            var loc = new Geolocator();

            try
            {
                Geoposition _pos = await loc.GetGeopositionAsync();
                UserCity = _pos.CivicAddress.City;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
