using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BungApp
{
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
            NextButton.Clicked+= NextButton_Clicked;
        }
		void NextButton_Clicked(object sender, System.EventArgs e)
		{
            Navigation.PushModalAsync(new MyPage2());
		}

    }
	
}
