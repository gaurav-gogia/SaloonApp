﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Sassy_Saloons.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class commonRegister : Page
    {

        CheckingType parameters;
        string privateKey, publicKey;

        public commonRegister()
        {
            this.InitializeComponent();
            parameters = new CheckingType();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            parameters.TypeUser = e.Parameter.ToString();
        }

        private void goNext_Click(object sender, RoutedEventArgs e)
        {
            parameters.Username = usernameBox.Text;            
            parameters.City = cityBox.Text;
            parameters.State = stateBox.Text;
            parameters.Pin = pinBox.Text;

            #region For Encryption            
            privateKey = Constants.PRIVATEKEY;
            publicKey = Constants.PUBLICKEY;
            # endregion

            parameters.Password = EncryptionLayer1.CreateHash(privateKey, publicKey, passBox.Password);

            if (parameters.TypeUser.Equals("EndUser"))
                Frame.Navigate(typeof(personReg), parameters);
            else
                Frame.Navigate(typeof(saloonRegister), parameters);
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(logorReg), parameters.TypeUser);
        }
    }

    internal class CheckingType
    {
        public string TypeUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
    }
}
