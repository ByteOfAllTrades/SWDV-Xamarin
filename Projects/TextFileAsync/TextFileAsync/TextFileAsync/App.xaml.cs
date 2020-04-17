using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextFileAsync
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Xamarin.FormsBook.Platform.Toolkit.Init();
            MainPage = new TextFileAsyncPage();
            
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
