using System;
using Xamarin.Forms;

namespace MvvmEnforcement
{
    public partial class MvvmEnforcementHomePage : ContentPage
    {
        MvvmEnforcementModalPage modalPage = new MvvmEnforcementModalPage();
        public MvvmEnforcementHomePage() 
        {
            InitializeComponent();
        }

        async void OnGoToButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MvvmEnforcementModalPage());
        }
    }
}

