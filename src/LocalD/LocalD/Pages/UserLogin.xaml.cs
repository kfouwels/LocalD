using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LocalD.Services;

namespace LocalD.Pages
{
    public partial class UserLogin : PhoneApplicationPage
    {
        private UserGeo myUserGeo = new UserGeo();

        public UserLogin()
        {
            InitializeComponent();
        }

        private async void UserSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            ProgressBar.Visibility = Visibility.Visible;
            if (UserEmail.Text.Contains('@') && UserEmail.Text.Contains('.') && !string.IsNullOrEmpty(UserPwd.Password))
            {
                //todo login shit
                //todo prevent going back to this page

                if (!await myUserGeo.UpdateGeoCity())
                {
                    ProgressBar.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Could not update Geolocation", "Error", MessageBoxButton.OK);
                }
                else
                {
                    ProgressBar.Visibility = Visibility.Collapsed;
                }

                NavigationService.Navigate(new Uri("/Pages/MainHub.xaml", UriKind.Relative));

            }
            else
            {
                MessageBox.Show("The credentials entered are either blank or not in a valid format. Try again.", "PEBKAC Error!",
                                MessageBoxButton.OK);
                UserPwd.Password = "";
            }
            ProgressBar.Visibility = Visibility.Collapsed;
        }

        private void ApplicationBarIconButton_help_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
    }
}