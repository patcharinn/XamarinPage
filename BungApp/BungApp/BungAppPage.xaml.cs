using Xamarin.Forms;

namespace BungApp
{
    public partial class BungAppPage : ContentPage
    {
        public string Text { get; set; }
        public BungAppPage()
        {
            InitializeComponent();
            BindingContext = this;
			myButton.Clicked += MyButton_Clicked;

        }

		void MyButton_Clicked(object sender, System.EventArgs e)
		{

		}
	}
}
