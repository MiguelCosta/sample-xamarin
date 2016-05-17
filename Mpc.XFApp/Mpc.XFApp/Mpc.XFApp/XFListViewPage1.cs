using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class XFListViewPage1 : ContentPage
    {
        public XFListViewPage1()
        {
            var classNames = new[]
            {
                "The bewildered tourist was lost.",
                "The senile old man was confused.",
                "The lost puppy was a wet and stinky dog.",
                "The flu clinic had seen many cases of infectious disease.",
                "It was a story as old as time.",
                "The sports car drove the long and winding road.",
                "Saturday became a cool, wet afternoon.",
                "He was waiting for the rain to stop.",
                "The sports car drove the long and winding road.",
                "Saturday became a cool, wet afternoon.",
                "He was waiting for the rain to stop.",
                "The sports car drove the long and winding road.",
                "Saturday became a cool, wet afternoon.",
                "He was waiting for the rain to stop.",
                "The sports car drove the long and winding road.",
                "Saturday became a cool, wet afternoon.",
                "He was waiting for the rain to stop.",
                "She was upset when it didn't boil."
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.ItemsSource = classNames;

            listView.ItemSelected += (sender, e) =>
            {
                DisplayAlert("Selection", e.SelectedItem.ToString(), "ok");
                ((ListView)sender).SelectedItem = null;
            };

            Content = listView;
        }
    }
}
