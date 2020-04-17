using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CircularText;
namespace CircularText
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CircleTextPage();
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
