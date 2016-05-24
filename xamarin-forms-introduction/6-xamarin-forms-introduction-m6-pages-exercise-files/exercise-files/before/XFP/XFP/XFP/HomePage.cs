using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFP
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Pages";

            var button1 = new Button {  Text = "Simple Page"};
            button1.Clicked += (o, e) =>
                {  };

            var button2 = new Button { Text = "" };
            button2.Clicked += (o, e) =>
                {  };

            var button3 = new Button { Text = "" };
            button3.Clicked += (o, e) =>
                {  };

            var button4 = new Button { Text = "" };
            button4.Clicked += (o, e) =>
            {
            };

            var button5 = new Button { Text = "" };
            button5.Clicked += (o, e) =>
            {
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { button1, button2, button3, button4, button5 }
            };
        }
    }
}
