﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimationTryout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimationTryoutPage();
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
