﻿using Xamarin.Forms;

namespace XamarinFormsSamples
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			DependencyService.Register<ILoadingService>();
			MainPage = new NavigationPage(new LoadingPage());
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
