using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using LocalD.Services.Implementation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LocalD.Services;

namespace LocalD.Pages
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void UserSubmit_OnClick(object sender, RoutedEventArgs e)
        {

            //display processing circle
            Spinner.Visibility = Visibility.Visible;
            SpinningAnimation.Begin();

            //Validate Fields
            if (UserEmail.Text.Contains('@') && UserEmail.Text.Contains('.') && !string.IsNullOrEmpty(UserPwd.Password))
            {
                //ILogin testLogin = new Login();
                //todo login shit

                //DEBUG
                MessageBox.Show("For now this is overriding the login system, as it does not yet exist", "DEBUG!!",
                                MessageBoxButton.OK);
                NavigationService.Navigate(new Uri("/Pages/MainHub.xaml"));

            }
            else
            {
                MessageBox.Show("The credentials entered are either blank or not in a valid format. Try again.", "PEBKAC Error!",
                                MessageBoxButton.OK);
                UserPwd.Password = "";
            }
            Spinner.Visibility = Visibility.Collapsed;
            SpinningAnimation.Stop();
        }

        private void ApplicationBarIconButton_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
    }
}