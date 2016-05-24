using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFP
{
    class CourseMasterDetail : MasterDetailPage
    {
        public CourseMasterDetail()
        {
            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            listView.ItemSelected += (sender, e) =>
                {
                    if (e.SelectedItem != null)
                    {
                        Detail = new CoursePage(e.SelectedItem as PluralsightCourse);

                        IsPresented = false;
                    }
                };
            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePage(PluralsightCourse.GetCourseList().First());
        }
    }
}
