using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class XFListViewPage1 : ContentPage
    {
        public XFListViewPage1()
        {
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.ItemsSource = Models.Course.GetCourseList();

            listView.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    DisplayAlert("Selection", e.SelectedItem.ToString(), "ok");
                    ((ListView)sender).SelectedItem = null;
                }
            };

            Content = listView;
        }
    }
}
