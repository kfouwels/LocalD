using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using LocalD.Data.ApiResponses;
using LocalD.Services;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LocalD.Data;
using Newtonsoft.Json;


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
            var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");

            await uapi.ApiTown();

            NavigationService.Navigate(new Uri("/Pages/UserLogin.xaml", UriKind.Relative));
        }
    }
}