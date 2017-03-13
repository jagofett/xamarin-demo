using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PlatformSettings.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}

		private void OnPlatformButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.OnPlatformPage());
		}
		private void DeviceButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.DevicePage());
		}
	}
}
