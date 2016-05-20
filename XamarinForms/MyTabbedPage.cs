using System;

using Xamarin.Forms;

namespace XamarinForms
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			var firstPage = new NavigationPage(new MyFirstPage());
			firstPage.Title = "İlk Sayfa";
			firstPage.Icon = "visitPlan.png";

			var secondPage = new MySecondPage ();
			secondPage.Title = "İkinci Sayfa";
			secondPage.Icon = "visitCalendar.png";

			Children.Add (firstPage);
			Children.Add (secondPage);
		}
	}
}


