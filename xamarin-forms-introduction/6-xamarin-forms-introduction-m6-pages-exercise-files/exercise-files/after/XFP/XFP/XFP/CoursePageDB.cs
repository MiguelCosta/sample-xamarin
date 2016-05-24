using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFP
{
    class CoursePageDB : ContentPage
    {
        public CoursePageDB()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            //this.Title = course.TitleShort;
            this.SetBinding(ContentPage.TitleProperty, "TitleShort");

            var titleLabel = new Label
            {
                //Text = course.Title,
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };
            titleLabel.SetBinding(Label.TextProperty, "Title");

            var authorLabel = new Label
            {
                //Text = course.Author,
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };
            authorLabel.SetBinding(Label.TextProperty, "Author");

            var descriptionLabel = new Label
            {
                //Text = course.Description,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            descriptionLabel.SetBinding(Label.TextProperty, "Description");

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
