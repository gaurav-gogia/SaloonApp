﻿using Sassy_Saloons.Managers;
using Sassy_Saloons.Models;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Sassy_Saloons.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class logorReg : Page
    {
        LoginInfo log;
        CommonResponse response;
        string type, privateKey, publicKey;
        static internal bool intent;

        public logorReg()
        {
            this.InitializeComponent();
            log = new LoginInfo();
            intent = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {            
            base.OnNavigatedTo(e);

            type = e.Parameter.ToString();            
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {            
            Frame.Navigate(typeof(commonRegister), type);
        }

        private async void login_Click(object sender, RoutedEventArgs e)
        {
            log.Username = username.Text;            
            log.TypeLogin = type;

            #region For Encryption            
            privateKey = Constants.PRIVATEKEY;
            publicKey = Constants.PUBLICKEY;
            #endregion

            log.Password = EncryptionLayer1.CreateHash(privateKey, publicKey, passBox.Password);

            try
            {
                response = await CommonCall.RegisterYourselfAsync(null, null, null, log);

                var keepTemp = Windows.Storage.ApplicationData.Current.LocalSettings;

                keepTemp.Values["user"] = log.Username;
                keepTemp.Values["type"] = log.TypeLogin;

                var dialog = new MessageDialog(response.response.ToString());
                await dialog.ShowAsync();

                if (response.response.Equals("Success"))
                {
                    if (type.Equals("EndUser"))
                        Frame.Navigate(typeof(userProfile), log);
                    else
                    {
                        salMore obSal = new salMore();

                        Frame.Navigate(typeof(salProfile), log);
                        intent = true;
                    }
                    
                }
            }

            catch (Exception) { }                        
        }
    }

    sealed class LoginInfo
    {
        public string Username  { get; set; }
        public string Password  { get; set; }
        public string TypeLogin { get; set; }
    }
}
