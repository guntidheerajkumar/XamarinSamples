using System;
using Xamarin.Forms;
using XamarinFormsSamples.iOS;
using BigTed;

[assembly: Dependency(typeof(LoadingService))]
namespace XamarinFormsSamples.iOS
{
	public class LoadingService : ILoadingService
	{
		public LoadingService()
		{
		}

		public void Hide()
		{
			BTProgressHUD.Dismiss();
		}

		public void Show(string title = "Loading")
		{
			BTProgressHUD.Show(status: title, maskType: ProgressHUD.MaskType.Black);
		}
	}
}
