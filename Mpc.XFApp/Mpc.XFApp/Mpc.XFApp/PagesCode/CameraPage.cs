using Plugin.Media;
using Xamarin.Forms;

namespace Mpc.XFApp.PagesCode
{
    public class CameraPage : ContentPage
    {
        public CameraPage()
        {
            var takePhoto = new Button()
            {
                Text = "Take a photo"
            };

            var image = new Image();

            var txtPath = new Entry()
            {
                Placeholder = "Path"
            };

            takePhoto.Clicked += async (sender, args) =>
            {
                await CrossMedia.Current.Initialize();

                if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "test.jpg"
                });

                if(file == null)
                    return;

                MessagingCenter.Send<CameraPage, Plugin.Media.Abstractions.MediaFile>(this, "pictureTaken", file);
            };

            MessagingCenter.Subscribe<CameraPage, Plugin.Media.Abstractions.MediaFile>(this, "pictureTaken", (sender, arg) =>
            {
                txtPath.Text = arg.Path;
                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = arg.GetStream();
                    arg.Dispose();
                    return stream;
                });

                // Not work in Windows 8.1
                //image.Source = ImageSource.FromFile(arg.Path);
            });

            Content = new StackLayout()
            {
                Children = { takePhoto, txtPath, image }
            };
        }
    }
}
