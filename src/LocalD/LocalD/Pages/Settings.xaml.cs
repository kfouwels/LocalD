﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LocalD.Pages
{
	public partial class Settings : PhoneApplicationPage
	{
		public Settings()
		{
			InitializeComponent();
		}
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{

			MessageBox.Show("Yada Yada Yada",
			                "Nothing to see here! [yet]", MessageBoxButton.OK);


		}
	}
}