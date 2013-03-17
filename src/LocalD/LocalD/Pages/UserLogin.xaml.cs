﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
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

        private void UserToLogin_OnClick(object sender, RoutedEventArgs e)
        {
            ProgressBar.Visibility = Visibility.Visible;
            if (!string.IsNullOrEmpty(UserUsername.Text) || !string.IsNullOrEmpty(UserPwd.Password))
            {
                //todo save login info

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