using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mpc.XFApp.PagesCode
{
    public class CourseMasterDetail : MasterDetailPage
    {
        public CourseMasterDetail()
        {
            var listView = new ListView();
            listView.ItemsSource = Models.Course.GetCourseList();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding(nameof(Models.Course.Title)));
            cell.SetBinding(TextCell.DetailProperty, new Binding(nameof(Models.Course.Author)));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Green);

            listView.ItemTemplate = cell;

            listView.ItemSelected += courseSelected;

            Master = new ContentPage()
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePage(Models.Course.GetCourseList().First());
        }

        private void courseSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                Detail = new CoursePage(e.SelectedItem as Models.Course);
                IsPresented = false;
            }
        }
    }
}
