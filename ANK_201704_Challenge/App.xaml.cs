using Xamarin.Forms;

namespace ANK_201704_Challenge
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new ANK_201704_ChallengePage();
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
