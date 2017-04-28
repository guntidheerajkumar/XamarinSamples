using System;
using Xamarin.Forms;

namespace XamarinFormsSamples
{
	public class BasePage : ContentPage
	{
		public void Show()
		{
			DependencyService.Get<ILoadingService>().Show();
		}

		public void Hide()
		{
			DependencyService.Get<ILoadingService>().Hide();
		}

		public BasePage()
		{

		}
	}
}
