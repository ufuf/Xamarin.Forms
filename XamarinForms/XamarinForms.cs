using System;

using Xamarin.Forms;

namespace XamarinForms
{
	public class App : Application
	{
		public App ()
		{
			Label testLabel = new Label ();
			testLabel.Text = "Merhaba";

			Button testButton = new Button ();
			testButton.Text = "Deneme Butonu";
			testButton.Clicked += (object sender, EventArgs e) => testLabel.Text = "Botuna Basıldı";

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						testLabel,
						testButton
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

