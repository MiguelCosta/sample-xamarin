using Mpc.XFApp.Pages;
using System.Linq;
using Xamarin.Forms;

namespace Mpc.XFApp.PagesCode
{
    internal class HomePage : ContentPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Pages";

            var button1 = new Button { Text = "Simple Page" };
            button1.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CoursePage(Models.Course.GetCourseList().First()));
            };

            var button2 = new Button { Text = "MyPage" };
            button2.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new MyPage());
            };

            var button3 = new Button { Text = "XFListViewPage1" };
            button3.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new XFListViewPage1());
            };

            var button4 = new Button { Text = "XFListViewPage2" };
            button4.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new XFListViewPage2());
            };

            var button5 = new Button { Text = "XFListViewPage3" };
            button5.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new XFListViewPage3());
            };

            var button6 = new Button { Text = "XFPage2" };
            button6.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new XFPage2());
            };

            var button7 = new Button { Text = "XFPage3" };
            button7.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new XFPage3());
            };

            var button8 = new Button { Text = "Master/Detail" };
            button8.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CourseMasterDetail());
            };

            var button9 = new Button { Text = "Master/Detail (binding)" };
            button9.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CourseMasterDetailDB());
            };

            var button10 = new Button { Text = "Tabbed" };
            button10.Clicked += (o, e) =>
            {
                var page = new TabbedPage()
                {
                    Title = "Courses"
                };
                foreach(var c in Models.Course.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = c;
                    page.Children.Add(coursePage);
                }

                Navigation.PushAsync(page);
            };

            var button11 = new Button { Text = "Corousel" };
            button11.Clicked += (o, e) =>
            {
                var page = new CarouselPage()
                {
                    Title = "Courses"
                };
                foreach(var c in Models.Course.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = c;
                    page.Children.Add(coursePage);
                }

                Navigation.PushAsync(page);
            };

            Content = new ScrollView()
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children =
                    {
                        button1,
                        button2,
                        button3,
                        button4,
                        button5,
                        button6,
                        button7,
                        button8,
                        button9,
                        button10,
                        button11
                    }
                }
            };

        }
    }
}
