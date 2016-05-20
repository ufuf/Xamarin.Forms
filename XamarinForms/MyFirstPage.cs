using System;

using Xamarin.Forms;

namespace XamarinForms
{
	public class MyFirstPage : ContentPage
	{
		public MyFirstPage ()
		{
			Title = "İlk Sayfa";

			Label testLabel = new Label ();
			testLabel.Text = "İlk Sayfa";

			Button testButton = new Button ();
			testButton.Text = "Deneme Butonu";
			testButton.Clicked += (object sender, EventArgs e) => Navigation.PushAsync(new MySecondPage());

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					testLabel,
					testButton
				}
			};
		}
	}
}


