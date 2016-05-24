using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TakeAPicture
{
    class ThePage : ContentPage
    {
        public ThePage()
        {
            Padding = new Thickness(
                20, 
                Device.OnPlatform(40, 20, 0), 
                10, 
                20);

            var theButton = new Button
            {
                Text = "Take Pic"
            };

            theButton.Clicked += (sender, e) =>
            {
                // Take the picture
            };

            var theImage = new Image
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { theButton, theImage }
            };

        }
    }
}
