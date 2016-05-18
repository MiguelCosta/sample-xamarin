using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class XFListViewPage3 : ContentPage
    {
        public XFListViewPage3()
        {
            Padding = new Thickness(20, Device.OnPlatform(20, 0, 0), 20, 20);

            var listView = new ListView
            {
                SeparatorColor = Color.Blue
            };

            ObservableCollection<Models.Course> courses = new ObservableCollection<Models.Course>();

            foreach(var item in Models.Course.GetCourseList())
            {
                courses.Add(item);
            }

            listView.ItemsSource = courses;
            listView.ItemTemplate = new DataTemplate(typeof(Layout.CourseCell));

            listView.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    DisplayAlert("Selection", e.SelectedItem.ToString(), "ok");
                    ((ListView)sender).SelectedItem = null;
                }
            };

            var titleLabel = new Label
            {
                Text = "Title",
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var titleEntry = new Entry
            {
                Placeholder = "Title"
            };

            var authorLabel = new Label
            {
                Text = "Author",
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var authorEntry = new Entry
            {
                Placeholder = "Author",
                InputTransparent = true
            };

            var btnAdd = new Button
            {
                Text = "Add",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Green,
                BorderWidth = 1
            };

            btnAdd.Clicked += (sender, e) =>
            {
                var title = titleEntry.Text;
                Models.Course course = courses.ToList().FirstOrDefault(x => x.Title == title);

                if(course == null)
                {
                    course = new Models.Course()
                    {
                        Title = title,
                        Author = authorEntry.Text
                    };
                    courses.Add(course);
                }

                listView.ScrollTo(course, ScrollToPosition.Center, true);
            };

            Content = new StackLayout
            {
                Children = {
                    listView,
                    titleLabel,
                    titleEntry,
                    authorLabel,
                    authorEntry,
                    btnAdd }
            };
        }
    }
}
