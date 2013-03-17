using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Devices;
using Windows.Devices.Geolocation;
using Microsoft.Xna.Framework.Media;
using LocalD.Services;

namespace LocalD
{
    public partial class MainPage : PhoneApplicationPage
    {
        private PhotoCamera _myCam;
        private Geolocator _loc;
        private Geoposition _pos;

        public MainPage()
        {
            InitializeComponent();

            CameraButtons.ShutterKeyPressed += OnButtonFullPress;

            Status.Text = "Page loaded";
            Status.Text = "Checking if camera OK";

            _loc = new Geolocator();

            if (PhotoCamera.IsCameraTypeSupported(CameraType.Primary))
            {

                _myCam = new PhotoCamera(CameraType.Primary);
                Status.Text = "Camera OK!";

                Resolution.Text = (_myCam.Resolution.Width + "x" + _myCam.Resolution.Height);
                ViewfinderCanvas.Height = _myCam.Resolution.Height;
                ViewfinderCanvas.Width = _myCam.Resolution.Width;

                ViewfinderBrush.SetSource(_myCam);
                _myCam.CaptureCompleted += myCam_CaptureCompleted;
            }
            else
            {
                MessageBox.Show("A Camera is not available on this device.", "Error!", MessageBoxButton.OK);
                Status.Text = "Camera ERROR!";
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Geo.Text = (UserGeo.UserPos.Coordinate.Latitude + " / " + UserGeo.UserPos.Coordinate.Longitude);
        }
        private void TakePhoto()
        {
            try
            {
                _myCam.CaptureImage();
            }
            catch (Exception)
            {
                MessageBox.Show("The camera couldn't take an image, please try again", "CaptureImage() failed",
                                MessageBoxButton.OK);
            }
        }
        private void ApplicationBarIconButton_Photo_OnClick(object sender, EventArgs e)
        {
            TakePhoto();
        }

        private void OnButtonFullPress(object sender, EventArgs e)
        {
            TakePhoto();
        }

        private void myCam_CaptureCompleted(object sender, CameraOperationCompletedEventArgs e)
        {
            //todo do stuff when photo taken
        }
        private void ApplicationBarIconButton_Settings_OnClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }

        private void CameraBox_Ontap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/CameraPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_MainHelp_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
    }
}