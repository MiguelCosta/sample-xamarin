using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeAPicture;
using Xamarin.Media;
using Xamarin.Forms;

[assembly: Dependency(typeof(TakeAPicture.iOS.PictureTaker_iOS))]

namespace TakeAPicture.iOS
{
    class PictureTaker_iOS : IPictureTaker
    {
        public async void SnapPic()
        {
            var picker = new MediaPicker();

            var mediaFile = await picker.PickPhotoAsync();
            System.Diagnostics.Debug.WriteLine(mediaFile.Path);

            MessagingCenter.Send<IPictureTaker, string>(this, "pictureTaken", mediaFile.Path);
        }
    }
}
