﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Navigation;
using LocalD.Data;
using LocalD.Services;
using LocalD.Templates.ApiResponses;
using Microsoft.Phone.Controls;

//todo expand articles

namespace LocalD
{
    public partial class MainPage : PhoneApplicationPage
    {

        List<NewsItem> _newsFeed;
        private bool _isUpdaterRunning = false;

        public MainPage()
        {
            InitializeComponent();
            PanoramaTitle.Text = TempAppData.CurrentTown.name;
            RefreshNewsFeed();
            MainPano.DefaultItem = MainPano.Items[1];
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            NavigationService.RemoveBackEntry();
        }

        private async void RefreshNewsFeed()
        {
            if (_isUpdaterRunning == false)
            { 
                _isUpdaterRunning = true;
                var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");
                try
                {
                    _newsFeed = await uapi.ApiNews(TempAppData.CurrentTown.id);
                    foreach (var town in _newsFeed)
                    {
                        town.bodyClean = Regex.Replace(town.body, "<[^<]+?>", String.Empty);
                        town.bodyCleanShort = (town.bodyClean.Substring(1, 200) + " ...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accessing LocalD services, we can not fetch news at this time", ":(",
                                    MessageBoxButton.OK);
                }
                _isUpdaterRunning = false;

                NewsFeedBox.ItemsSource = _newsFeed;
            }
        }
        private void ApplicationBarIconButton_Settings_OnClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_MainHelp_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
        private void ApplicationBarIconButton_Refresh_OnClick(object sender, EventArgs e)
        {
            RefreshNewsFeed();
        }
    }
}