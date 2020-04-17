using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmEnforcement
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MvvmEnforcementHomePage());
        }

        public LittleViewModel ModalPageViewModel { private set; get; }

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
