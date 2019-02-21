﻿using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuikRide.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPageXAML : ContentPage
    {
        public AboutPageXAML()
        {
            InitializeComponent();
        }

        private async void Email_Tapped(object sender, EventArgs e)
        {
            await Helpers.Helpers.SendEmail("Question about QuikTrip", "I was wondering...", new List<string>() { "info@quikride.com" });
        }

        private void Facebook_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://facebook.com"));
        }

        private void PhoneNumber_Tapped(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("11234567890");
            }
            catch (FeatureNotSupportedException)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Sorry, the phone dialer is not supported on this device.", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void Slack_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert(
                        "Wait!",
                        "You must be a member to join our Slack Channel!",
                        "OK");
        }

        private void Twitter_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com"));
        }
    }
}