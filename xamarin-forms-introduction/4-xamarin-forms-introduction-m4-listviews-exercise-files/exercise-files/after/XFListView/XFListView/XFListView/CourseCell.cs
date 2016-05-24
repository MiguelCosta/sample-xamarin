using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFListView
{
    class CourseCell : ViewCell
    {
        public CourseCell()
        {
            var titleLabel = new Label
            {
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium)
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var authorLabel = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                XAlign = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            View = new StackLayout
            {
                Children = { titleLabel, authorLabel},
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
