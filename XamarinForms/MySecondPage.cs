using System;

using Xamarin.Forms;

namespace XamarinForms
{
	public class MySecondPage : ContentPage
	{
		public MySecondPage ()
		{
			Title = "İkinci Sayfa";
				
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "İkinci Sayfa" }
				}
			};
		}
	}
}


