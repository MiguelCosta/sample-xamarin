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

[assembly: Dependency(typeof(TakeAPicture.Droid.MainActivity))]

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

        public void SnapPic()
        {
            var activity = Forms.Context as Activity;

            var picker = new MediaPicker(activity);
            var intent = picker.GetTakePhotoUI(new StoreCameraMediaOptions
            {
                Name = "test.jpg",
                Directory = "Pluralsight"
            });
            activity.StartActivityForResult(intent, 1);
        }

        protected override async void OnActivityResult(int requestCode, Result resultCode, 
            Android.Content.Intent data)
        {
            if (resultCode == Result.Canceled)
                return;

            var mediaFile = await data.GetMediaFileExtraAsync(Forms.Context);
            System.Diagnostics.Debug.WriteLine(mediaFile.Path);

            MessagingCenter.Send<IPictureTaker, string>(this, "pictureTaken", mediaFile.Path);

        }
    }
}

