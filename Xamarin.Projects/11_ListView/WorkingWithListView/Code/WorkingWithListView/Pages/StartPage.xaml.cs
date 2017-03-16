using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WorkingWithListView.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}
		private void BasicList_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.BasicList());
		}
		private void DeviceButton_Clicked(object sender, EventArgs e) {
		//	Navigation.PushAsync(new Pages.DevicePage());
		}
	}
}
