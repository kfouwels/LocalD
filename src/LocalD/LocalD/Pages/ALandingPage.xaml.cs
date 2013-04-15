using System;
using System.Windows.Navigation;
using LocalD.Data;
using LocalD.Services;
using Microsoft.Phone.Controls;

namespace LocalD.Pages
{
    public partial class ALandingPage : PhoneApplicationPage
    {
        public ALandingPage()
        {
            InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            status.Text = "Getting Geo Location";
            Description.Text = "";
            var ugeo = new UserGeo();
            try
            {
                FilingCabinet.UserPos = await ugeo.GetGeoposition();
            }
            catch (Exception ex)
            {

            }

            status.Text = "Updating Towns";
            Description.Text = "";
            var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");
            try
            {
                FilingCabinet.TownsList = await uapi.ApiTown();
                NavigationService.Navigate(new Uri("/Pages/UserLogin.xaml", UriKind.Relative));

            }
            catch (Exception ex)
            {
                status.Text = ":(";
                Description.Text = ("Error accessing the LocalD services\nPlease check your network connection");
            }

        }
    }
}