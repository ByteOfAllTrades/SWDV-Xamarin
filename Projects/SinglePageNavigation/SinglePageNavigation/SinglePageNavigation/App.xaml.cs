﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinglePageNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SinglePageNavigation.SinglePageNavigationPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
