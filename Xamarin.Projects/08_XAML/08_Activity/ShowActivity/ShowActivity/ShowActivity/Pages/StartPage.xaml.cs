using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowActivity.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}
		private void ActivityButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.ShowActivityPage());
		}
		private void ProgressButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.ShowProgressPage());
		}
	}
}
