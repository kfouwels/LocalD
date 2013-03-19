//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using Windows.Devices.Geolocation;

//namespace LocalD.Services
//{
//    public class UserGeo
//    {
//        public static Geoposition UserPos;

//        public async Task<bool> UpdateGeoCity()
//        {
//            var loc = new Geolocator();
            
//            try
//            {
//                UserPos = await loc.GetGeopositionAsync();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//    }
//}
