using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXFApp
{
    public partial class MyPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void OnColorSliderChanged(Object sender, EventArgs e)
        {
            var red = sliderRed.Value;
            var green = sliderGreen.Value;
            var blue = sliderBlue.Value;

            boxviewColor.Color = Color.FromRgb(red, green, blue);
        }
    }
}
