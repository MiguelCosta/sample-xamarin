using Mpc.XFApp.Models;
using Xamarin.Forms;

namespace Mpc.XFApp.PagesCode
{
    internal class CoursePage : ContentPage
    {
        public CoursePage(Course course)
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            this.Title = course.TitleShort;

            var titleLabel = new Label
            {
                Text = course.Title,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var authorLabel = new Label
            {
                Text = course.Author,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            var descriptionLabel = new Label
            {
                Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

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
