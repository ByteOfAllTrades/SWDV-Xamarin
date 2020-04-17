﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TranslationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TranslationDemoPage();
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