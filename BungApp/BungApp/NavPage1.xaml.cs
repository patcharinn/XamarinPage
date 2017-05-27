using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BungApp
{
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();
            NextButton.Clicked+= NextButton_Clicked;
        }
		void NextButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new NavPage2());
		}
    }
}
