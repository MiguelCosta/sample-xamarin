using System;
using Xamarin.Forms;

namespace Mpc.XFApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void OnSlideColorChanged(object sender, EventArgs e)
        {
            var red = sliderRed.Value;
            var green = sliderGreen.Value;
            var blue = sliderBlue.Value;

            boxviewColor.Color = Color.FromRgb(red, green, blue);
        }
    }
}
