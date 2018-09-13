using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace proyecto
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var navigationPage = new NavigationPage(new MainPage());
            var color = "ffff";
            navigationPage.BackgroundColor = Color.FromHex(color);
            navigationPage.BarTextColor = Color.White;

            MainPage = navigationPage;

           // MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
