using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace XamarinForms
{
	public class MyListViewPage : ContentPage
	{
		public MyListViewPage ()
		{
			//Dizi oluştur
			string[] dizi = new string[] {
				"Ufuk ARSLAN",
				"Ekin MİRAL", 
				"Burak Güner",
				"Gökçe Sarsılmaz", 
				"Oğuzhan Gedik", 
				"Ömer Köksür"
			};

			// Liste oluştur.
			ListView list = new ListView ();
			list.ItemsSource = dizi;

			list.ItemTapped += (object sender, ItemTappedEventArgs e) => {

				string item = (string)e.Item; //Seçili öğeyi al

				//Yeni ekran push et.
				Navigation.PushAsync (new ContentPage() { 
					Content = new StackLayout { 
						Children = {
							new Label { 
								Text = item,
								VerticalOptions = LayoutOptions.CenterAndExpand, 
								HorizontalOptions = LayoutOptions.CenterAndExpand 
							}
						}
					}
				});

				list.SelectedItem = null; //Listenin seçili kalmasını engelle
			};

			//Listeyi sayfaya ekle.
			Content = list;
		}
	}
}


