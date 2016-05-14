using Xamarin.Forms;

namespace XFApp
{
    public class SimpleContentPage : ContentPage
    {
        public SimpleContentPage()
        {
            var label1 = new Label()
            {
                Text = "This is my label",
                FontSize = Device.GetNamedSize(NamedSize.Large, this)
            };

            var entry1 = new Entry()
            {
                Placeholder = "Type something here"
            };

            var btn1 = new Button()
            {
                Text = "Click me"
            };

            btn1.Clicked += (sender, e) =>
            {
                label1.Text = $"Text: {entry1.Text}";
            };

            Content = new StackLayout()
            {
                Padding = 30,
                Spacing = 10,
                Children =
                {
                    label1,
                    entry1,
                    btn1
                }
            };
        }
    }
}
