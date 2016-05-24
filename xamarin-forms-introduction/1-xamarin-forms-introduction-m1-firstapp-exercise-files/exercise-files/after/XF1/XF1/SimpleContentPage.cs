using System;
using Xamarin.Forms;

namespace XF1
{
	public class SimpleContentPage : ContentPage
	{
		public SimpleContentPage ()
		{
			var label1 = new Label {
				Text = "This is my label",
				Font = Font.BoldSystemFontOfSize(NamedSize.Large)
			};

			var entry1 = new Entry {
				Placeholder = "Type something here"
			};

			var button1 = new Button {
				Text = "Click Me!"
			};

			button1.Clicked += (sender, e) => {
				label1.Text = "User typed: " + entry1.Text;
			};

			Content = new StackLayout {
				Padding = 30,
				Spacing = 10,
				Children = {label1, entry1, button1}
			};
		}
	}
}

