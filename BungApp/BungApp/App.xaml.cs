using Xamarin.Forms;

namespace BungApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var np = new NavigationPage(new NavPage1());
            var tp = new TabbedPage();
			tp.Children.Add(new TabMyPage2());
			tp.Children.Add(new TabMyPage3());

			var cp = new CarouselPage();
			cp.Children.Add(new TabMyPage1());
			cp.Children.Add(new TabMyPage2());
			cp.Children.Add(new TabMyPage3());

			var mp = new MasterDetailPage();
			mp.Master = new MenuPage();
			mp.Detail = new NavigationPage(new  TabMyPage1());

			MainPage = new AbsoluteLayoutPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
