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
    public partial class UserRegister : PhoneApplicationPage
    {
        public UserRegister()
        {
            InitializeComponent();

            UserTown.ItemsSource = Data.FilingCabinet.TownsList.Select(e => e.name);

        }
        private void UserToSubmit_OnClick(object sender, RoutedEventArgs e)
        {

            var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");
            uapi.DownloadCompleted +=uapi_DownloadCompleted;

            //todo REGEX
            if (string.IsNullOrWhiteSpace(UserEmail.Text) ||
                string.IsNullOrWhiteSpace(UserUsername.Text) ||
                string.IsNullOrWhiteSpace(UserPwd.Password) ||
                //!string.IsNullOrWhiteSpace(UserTown.Text) ||
                !(UserPwd.Password.Length > 3) ||
                !(UserUsername.Text.Length > 3) ||
                !(UserEmail.Text.Length > 6) ||
                !UserEmail.Text.Contains("@") ||
                !UserEmail.Text.Contains("."))
            {
                MessageBox.Show(
                    "One or more of he fields contains an invalid entry. Passwords must be between 3 and 20 alphanumeric characters",
                    "User Error", MessageBoxButton.OK);
            }
            else
            {
                uapi.ApiReg(UserPwd.Password, UserUsername.Text, UserEmail.Text, "reading");
            }
        }

        void uapi_DownloadCompleted(string returnValue)
        {
            MessageBox.Show(("You will now be returned to the main page to login\n API says" + returnValue), "Success!",
                            MessageBoxButton.OK);
            NavigationService.Navigate(new Uri("/Pages/UserLogin.xaml", UriKind.Absolute));
        }


        private void ApplicationBarIconButton_help_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
    }
}