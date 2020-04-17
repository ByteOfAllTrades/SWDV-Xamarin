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
    public partial class FizzBuzzPage : ContentPage
    {
        public FizzBuzzPage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout();
            string result;
            for (int count = 1; count <= 100; count++)
            {
                result = count.ToString();
                if (count % 3 == 0)
                {
                    result = "Fizz";
                }
                if (count % 5 == 0)
                {
                    result = "Buzz";
                }
                if (count % 15 == 0)
                {
                    result = "FizzBuzz";
                }
                Label label = new Label()
                {
                    Text = result
                };
                stackLayout.Children.Add(label);
            }
            Padding = new Thickness(20, 20, 20, 20);
            Content = new ScrollView()
            {
                Content = stackLayout
            };
        }
    }
}