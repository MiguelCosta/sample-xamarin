using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class XFListViewPage2 : ContentPage
    {
        public XFListViewPage2()
        {
            Padding = new Thickness(20, Device.OnPlatform(20, 0, 0), 20, 20);

            var listView = new ListView();
            listView.ItemsSource = Models.Course.GetCourseList();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding(nameof(Models.Course.Title)));
            cell.SetBinding(TextCell.DetailProperty, new Binding(nameof(Models.Course.Author)));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Green);

            // se fosse por exemplo uma array de strings era utilizado o ponto 
            // para indicar que é para utilizar o próprio elemento, se for
            // usado um ponto num objeto é aplicado o ToString do objeto
            //cell.SetBinding(TextCell.TextProperty, new Binding("."));

            listView.ItemTemplate = cell;
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
