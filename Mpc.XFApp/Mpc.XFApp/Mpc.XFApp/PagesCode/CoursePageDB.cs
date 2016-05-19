using Mpc.XFApp.Models;
using Xamarin.Forms;

namespace Mpc.XFApp.PagesCode
{
    internal class CoursePageDB : ContentPage
    {
        public CoursePageDB()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            this.SetBinding(ContentPage.TitleProperty, nameof(Course.TitleShort));

            var titleLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            titleLabel.SetBinding(Label.TextProperty, nameof(Course.Title));

            var authorLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            authorLabel.SetBinding(Label.TextProperty, nameof(Course.Author));

            var descriptionLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            descriptionLabel.SetBinding(Label.TextProperty, nameof(Course.Description));

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children = { titleLabel, authorLabel, descriptionLabel }
                }
            };
        }
    }
}
