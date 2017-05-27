using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BungApp
{
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();
            NextButton.Clicked += NextButton_Clicked;
            BackButton.Clicked += BackButton_Clicked;
        }
		void NextButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MyPage3());
		}
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MyPage1());
		}
    }
}
