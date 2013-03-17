using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Devices;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LocalD.Pages
{
    public partial class CameraPage : PhoneApplicationPage
    {
        private PhotoCamera myCam;

        public CameraPage()
        {
            InitializeComponent();

            CameraButtons.ShutterKeyPressed += OnButtonFullPress;

            if (PhotoCamera.IsCameraTypeSupported(CameraType.Primary))
            {
                myCam = new PhotoCamera(CameraType.Primary);

                ViewfinderCanvas.Height = myCam.Resolution.Height;
                ViewfinderCanvas.Width = myCam.Resolution.Width;

                ViewfinderBrush.SetSource(myCam);
                //myCam.Initialized += cam_Initialized;
                myCam.CaptureCompleted += myCam_CaptureCompleted;
            }
            else
            {
                MessageBox.Show("A Camera is not available on this device.", "Error!", MessageBoxButton.OK);
            }
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

        private void myCam_CaptureCompleted(object sender, CameraOperationCompletedEventArgs e)
        {
            //todo stuff when photo taken
        }

       

        private void ApplicationBarIconButton_Photo_Tap(object sender, EventArgs eventArgs)
        {
            TakePhoto();
        }

        private void CameraViewbox_Tap(object sender, GestureEventArgs e)
        {
            TakePhoto();
        }
        private void OnButtonFullPress(object sender, EventArgs e)
        {
            TakePhoto();
        }

        private void ApplicationBarIconButton_MainHelp_Tap(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }

        private void ApplicationBarMenuItem_FlashOff_OnClick(object sender, EventArgs e)
        {
            myCam.FlashMode = FlashMode.Off;
        }

        private void ApplicationBarMenuItem_FlashAuto_OnClick(object sender, EventArgs e)
        {
            myCam.FlashMode = FlashMode.Auto;
        }

        private void ApplicationBarMenuItem_FlashOn_OnClick(object sender, EventArgs e)
        {
            myCam.FlashMode = FlashMode.On;
        }

        
    }
}