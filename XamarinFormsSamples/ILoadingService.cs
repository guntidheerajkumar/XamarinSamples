using System;

namespace XamarinFormsSamples
{
	public interface ILoadingService
	{
		void Show(string title = "Loading");

		void Hide();
	}
}
