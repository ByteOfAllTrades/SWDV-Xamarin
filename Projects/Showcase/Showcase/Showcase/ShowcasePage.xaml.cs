using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Showcase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowcasePage : ContentPage
    {
        Marquee.Marquee marqueeA;
        Marquee.Marquee marqueeB;
        Marquee.Marquee marqueeC;
        Marquee.Marquee marqueeD;
        FizzBuzzPage fizzBuzzPage = new FizzBuzzPage();
        MonkeyTapWithSoundPage MTWPage = new MonkeyTapWithSoundPage();
        LightBrightPage LBPage = new LightBrightPage();
        CircleButtonPage CBPage = new CircleButtonPage();
        public ShowcasePage()
        {
            InitializeComponent();

            this.BackgroundColor = Color.SandyBrown;
            // 
            string title = "Do a demo of the game FizzBuzz";
            string buttonLabel = "See a FizzBuzz listing";
            // the numbers are the grid origin for this marquee.
            marqueeA = new Marquee.Marquee(mainGrid, contentView, 0, 20, buttonLabel, title);
            // can't add the clicked handler in Marquee because it has the wrong context.
            marqueeA.button.Clicked += OnFizzBuzzButtonClicked;

            title = "Do a demo of the game MonkeyTap";
            buttonLabel = "See a MonkeyTap listing";
            // the numbers are the grid origin for this marquee.
            marqueeB = new Marquee.Marquee(mainGrid, contentView, 0, 0, buttonLabel, title);
            marqueeB.button.Clicked += OnMTWButtonClicked;

            title = "Do a demo of the game LightBright";
            buttonLabel = "See a LightBright listing";
            // the numbers are the grid origin for this marquee.
            marqueeC = new Marquee.Marquee(mainGrid, contentView, 20, 20, buttonLabel, title);
            marqueeC.button.Clicked += OnLBButtonClicked;

            title = "Do a demo of the game CircleButton";
            buttonLabel = "See a Circlebutton listing";
            // the numbers are the grid origin for this marquee.
            marqueeD = new Marquee.Marquee(mainGrid, contentView, 20, 0, buttonLabel, title);
            marqueeD.button.Clicked += OnCBButtonClicked;

        }

        async void OnFizzBuzzButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            fizzBuzzPage.Title = "FizzBuzz";
            await Navigation.PushAsync(fizzBuzzPage);
        }
        async void OnMTWButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            MTWPage.Title = "Monkey Tap";
            await Navigation.PushAsync(MTWPage);
        }
        async void OnLBButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            MTWPage.Title = "Light Bright";
            await Navigation.PushAsync(LBPage);
        }

        async void OnCBButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            MTWPage.Title = "Circle Button";
            await Navigation.PushAsync(CBPage);
        }
    }
}