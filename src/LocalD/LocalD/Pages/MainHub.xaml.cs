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
using Microsoft.Xna.Framework.Media;

namespace LocalD
{
    public partial class MainPage : PhoneApplicationPage
    {
        private PhotoCamera myCam;

        public MainPage()
        {
            InitializeComponent();

            CameraButtons.ShutterKeyPressed += OnButtonFullPress;

            Status.Text = "Page loaded";
            Status.Text = "Checking if camera OK";
            if (PhotoCamera.IsCameraTypeSupported(CameraType.Primary))
            {

                myCam = new PhotoCamera(CameraType.Primary);
                Status.Text = "Camera OK!";

                Resolution.Text = (myCam.Resolution.Width + "x" + myCam.Resolution.Height);
                ViewfinderCanvas.Height = myCam.Resolution.Height;
                ViewfinderCanvas.Width = myCam.Resolution.Width;

                ViewfinderBrush.SetSource(myCam);
                //myCam.Initialized += cam_Initialized;
                myCam.CaptureCompleted += myCam_CaptureCompleted;
            }
            else
            {
                MessageBox.Show("A Camera is not available on this device.", "Error!", MessageBoxButton.OK);
                Status.Text = "Camera ERROR!";
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        private void TakePhoto()
        {
            try
            {
                myCam.CaptureImage();
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