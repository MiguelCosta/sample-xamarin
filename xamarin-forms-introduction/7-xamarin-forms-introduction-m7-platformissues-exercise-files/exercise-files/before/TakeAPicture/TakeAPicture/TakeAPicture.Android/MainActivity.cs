using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Media;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TakeAPicture.Droid
{
    [Activity(Label = "TakeAPicture", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AndroidActivity, IPictureTaker
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            SetPage(App.GetMainPage());
        }

    }
}

