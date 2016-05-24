using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFListView
{
    class XFListViewPage1 : ContentPage
    {
        public XFListViewPage1()
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
            //listView.ItemsSource =
            //    from c in classNames
            //    where c.StartsWith("Building")
            //    select c;
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Debug.WriteLine("Selected: " + e.SelectedItem);

                    listView.SelectedItem = null;
                }
            };

            Content = listView;

        }
    }
}
