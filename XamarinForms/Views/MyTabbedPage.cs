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

			//Liste sayfası
			var listPage = new NavigationPage(new MyListViewPage ());
			listPage.Title = "Liste";

			Children.Add (firstPage);
			Children.Add (secondPage);
			Children.Add (listPage); //Tab ekle
		}
	}
}


