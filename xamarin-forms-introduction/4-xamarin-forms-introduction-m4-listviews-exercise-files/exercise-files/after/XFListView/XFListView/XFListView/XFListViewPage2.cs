using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFListView
{
    class XFListViewPage2 : ContentPage
    {
        public XFListViewPage2()
        {
            var classNames = new[] {
                "Building Cross Platform Apps with Xamarin Part 1",
                "Building Cross Platform Apps with Xamarin Part 2",
                "Building Google Glass Apps with c# and Xamarin",
                "Android for .NET Developers"
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            //listView.ItemsSource = classNames;
            listView.ItemsSource = PluralsightCourse.GetCourseList() ;

            var cell = new DataTemplate(typeof(TextCell));
            //cell.SetBinding(TextCell.TextProperty, new Binding("."));
            cell.SetBinding(TextCell.TextProperty, new Binding("Title"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Author"));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Yellow);

            listView.ItemTemplate = cell;

            Content = listView;

        }
    }
}
