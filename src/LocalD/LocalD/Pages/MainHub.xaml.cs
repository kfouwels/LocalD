using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            DataContext = App.ViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
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
                //myCam.CaptureCompleted += myCam_CaptureCompleted;

            }
            else
            {
                MessageBox.Show("A Camera is not available on this device.", "Error!", MessageBoxButton.OK);
                Status.Text = "Camera ERROR!";
            }

        }

        //private void myCam_CaptureCompleted(object sender, CameraOperationCompletedEventArgs e)
        //{

        //}

        //private void cam_Initialized(object sender, CameraOperationCompletedEventArgs e)
        //{
        //    status.Text = "Camera initialised";
        //}



        private void ViewfinderCanvas_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //try
            //{
            //    myCam.CaptureImage();
            //    status.Text = "Capture ok!";
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("The camera couldn't take an image, please try again", "CaptureImage() failed",
            //                    MessageBoxButton.OK);
            //    status.Text = "Capture failed";
            //}
        }

        private void ApplicationBarIconButton_Settings_OnClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }
    }
}