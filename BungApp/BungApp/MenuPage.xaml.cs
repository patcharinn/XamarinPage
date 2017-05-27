using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BungApp
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();
			Menu1Button.Clicked += MenuButton_Clicked;
			Menu2Button.Clicked += MenuButton_Clicked;
			Menu3Button.Clicked += MenuButton_Clicked;
		}



		void MenuButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;

			if (sender == Menu1Button)
			{
				mp.Detail = new NavigationPage(new TabMyPage1());
			}
			else if (sender == Menu2Button)
			{
				//mp.Detail = new NavigationPage(new TabMyPage2());
				var tp = new TabbedPage();
				tp.Children.Add(new TabMyPage2());
				tp.Children.Add(new TabMyPage3());
			}
			mp.IsPresented = false;
		}

		void Menu1Button_Clicked(object sender, EventArgs e)
		{

		}

		void Menu2Button_Clicked(object sender, EventArgs e)
		{

		}
	}
}
