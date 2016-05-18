using Xamarin.Forms;

namespace Mpc.XFApp.Layout
{
    public class CourseCell : ViewCell
    {
        public CourseCell()
        {
            var titleLabel = new Label
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Models.Course.Title)));

            var authorLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            authorLabel.SetBinding(Label.TextProperty, new Binding(nameof(Models.Course.Author)));

            View = new StackLayout
            {
                Children = { titleLabel, authorLabel },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
