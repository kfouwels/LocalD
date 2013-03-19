using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using LocalD.Services;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
//using LocalD.Services;

namespace LocalD.Pages
{
    public partial class UserLogin : PhoneApplicationPage
    {

        public UserLogin()
        {
            InitializeComponent();
        }

        private async void UserToLogin_OnClick(object sender, RoutedEventArgs e)
        {
            ProgressBar.Visibility = Visibility.Visible;
            var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");

            if (string.IsNullOrEmpty(UserUsername.Text) || string.IsNullOrEmpty(UserPwd.Password))
            {
                ProgressBar.Visibility = Visibility.Collapsed;
                UserPwd.Password = "";
                MessageBox.Show(
                    "The credentials entered are either blank or not in a valid format. Try again.",
                    "User Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    var y = await uapi.ApiLogin(UserPwd.Password, UserUsername.Text);
                    NavigationService.Navigate(new Uri("/Pages/MainHub.xaml", UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("We could not sign you in at this time, please check details and try again.", ":(",
                                    MessageBoxButton.OK);
                }
                
            }

            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NavigationService.RemoveBackEntry();
        }

        private void UserToRegister_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/UserRegister.xaml", UriKind.Relative));
        }
        private void ApplicationBarIconButton_help_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }

        
    }
}