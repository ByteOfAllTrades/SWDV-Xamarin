using System;
using Xamarin.Forms;

namespace Showcase
{
    public partial class CircleButtonPage : ContentPage
    {
        Point center;
        double radius;

        public CircleButtonPage()
        {
            InitializeComponent();
        }

        void OnSizeChanged(object sender, EventArgs args)
        {
            center = new Point(absoluteLayout.Width / 2, absoluteLayout.Height / 2);
            radius = Math.Min(absoluteLayout.Width, absoluteLayout.Height) / 2;
            AbsoluteLayout.SetLayoutBounds(button,
                new Rectangle(center.X - button.Width / 2, center.Y - radius,
                              AbsoluteLayout.AutoSize,
                              AbsoluteLayout.AutoSize));
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            button.AnchorY = radius / button.Height;
            await button.RotateTo((button.Rotation)+60, 250, Easing.SinInOut);
            if (button.Rotation == 360)
            {
                button.Rotation = 0;
            }
        }
    }
}


