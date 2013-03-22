using System;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using LocalD.Services;
using LocalD.Data;

namespace LocalD.Pages
{
    public partial class UserRegister : PhoneApplicationPage
    {
        public UserRegister()
        {
            InitializeComponent();
            if (FilingCabinet.TownsList.Count != 0)
            {
                UserTown.ItemsSource = FilingCabinet.TownsList.Select(e => e.name);
            }
        }
        private async void UserToSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            UserHasInputControl(false);

            var uapi = new UserApi("5940771a096a5bf6e36f530769a6ba2f");

            //todo REGEX
            if (string.IsNullOrWhiteSpace(UserEmail.Text) ||
                string.IsNullOrWhiteSpace(UserUsername.Text) ||
                string.IsNullOrWhiteSpace(UserPwd.Password) ||
                !(UserPwd.Password.Length > 3) ||
                !(UserUsername.Text.Length > 3) ||
                !(UserEmail.Text.Length > 6) ||
                !UserEmail.Text.Contains("@") ||
                !UserEmail.Text.Contains("."))
            {
                MessageBox.Show(
                    "One or more of he fields contains an invalid entry.\nPasswords must be between 3 and 20 alphanumeric characters",
                    ":(", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    var y = await uapi.ApiReg(UserPwd.Password, UserUsername.Text, UserEmail.Text, FilingCabinet.TownsList.Find(i => i.name == (UserTown.SelectedItem.ToString())).id);

                    if (y.success.Contains("Account created") || y.success.Contains("Account Created") || y.success.Contains("account created"))
                    {
                        MessageBox.Show("Registration successful. Account Created", ":)", MessageBoxButton.OK);

                        NavigationService.Navigate(new Uri("/Pages/UserLogin.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Registration unsuccessful.\nComputer says: " + y.success, ":(", MessageBoxButton.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("We could not sign you up at this time, please check details and try again.", ":(",
                                    MessageBoxButton.OK);
                }
                
            }
            UserHasInputControl(true);
        }
        private void UserHasInputControl(bool doThey)
        {

            if (doThey)
            {
                UserUsername.IsEnabled = true;
                UserPwd.IsEnabled = true;
                UserEmail.IsEnabled = true;
                UserTown.IsEnabled = true;
                UserRegisterSubmit.IsEnabled = true;
            }
            else
            {
                UserUsername.IsEnabled = false;
                UserPwd.IsEnabled = false;
                UserEmail.IsEnabled = false;
                UserTown.IsEnabled = false;
                UserRegisterSubmit.IsEnabled = false;
            }

        }

        private void ApplicationBarIconButton_help_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Earth that was could no longer sustain our numbers, we were so many. We found a new solar system, dozens of planets and hundreds of moons. Each one terraformed, a process taking decades, to support human life, to be new Earths. The Central Planets formed the Alliance. Ruled by an interplanetary parliament, the Alliance was a beacon of civilization. The savage outer planets were not so enlightened and refused Alliance control. The war was devastating, but the Alliance's victory over the Independents ensured a safer universe. And now everyone can enjoy the comfort and enlightenment of our civilization. ",
                "Help", MessageBoxButton.OK);
        }
    }
}