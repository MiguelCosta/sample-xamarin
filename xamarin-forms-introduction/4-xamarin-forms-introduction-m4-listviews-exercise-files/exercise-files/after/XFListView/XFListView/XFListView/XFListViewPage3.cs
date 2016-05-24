using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFListView
{
    class XFListViewPage3 : ContentPage
    {
        public XFListViewPage3()
        {

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();
            listView.ItemTemplate = new DataTemplate(typeof(CourseCell));

            Content = listView;

        }
    }
}
