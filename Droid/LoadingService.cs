using System;
using Xamarin.Forms;
using AndroidHUD;
using XamarinFormsSamples.Droid;

[assembly: Dependency(typeof(LoadingService))]
namespace XamarinFormsSamples.Droid
{
	public class LoadingService : ILoadingService
	{
		public LoadingService()
		{
		}

		public void Hide()
		{
			Device.BeginInvokeOnMainThread(() => {
				AndHUD.Shared.Dismiss(Forms.Context);
			});
		}

		public void Show(string title = "Loading")
		{
			Device.BeginInvokeOnMainThread(() => {
				AndHUD.Shared.Show(Forms.Context, title, maskType: MaskType.Black);
			});
		}
	}
}
