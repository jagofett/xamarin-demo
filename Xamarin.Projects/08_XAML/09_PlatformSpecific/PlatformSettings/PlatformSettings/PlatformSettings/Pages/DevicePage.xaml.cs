using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PlatformSettings.Pages
{
	public partial class DevicePage : ContentPage
	{
		public DevicePage()
		{
			InitializeComponent();
			// get the font sizes for each platform and assign to label font size
			PageHeaderLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

			// get the device information and show on screen

			OsLabel.Text = "OS: " + Device.OS.ToString();


			BoxView1.WidthRequest = Device.OnPlatform(iOS: 50, Android: 100, WinPhone: 200);

			Device.OnPlatform(iOS: SetiOSServiceUrl,
												Android: SetAndroidServiceUrl,
												WinPhone: SetWinphoneServiceUrl);
			CustomizedTextLabel.Text = _url;
		}
		private string _url;
		private void SetiOSServiceUrl()
		{
			_url = "http://tourstops.io/ios";
		}
		private void SetAndroidServiceUrl()
		{
			_url = "http://tourstops.io/android";
		}
		private void SetWinphoneServiceUrl()
		{
			_url = "http://tourstops.io/winphone";
		}
	}
}
