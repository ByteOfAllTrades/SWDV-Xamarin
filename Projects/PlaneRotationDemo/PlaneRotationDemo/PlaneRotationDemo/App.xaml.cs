using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaneRotationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PlaneRotationDemoPage();
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
