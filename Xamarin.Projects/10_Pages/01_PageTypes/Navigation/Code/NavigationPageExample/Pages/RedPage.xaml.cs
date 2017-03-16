using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationPageExample.Pages {
	public partial class RedPage : ContentPage {
		public RedPage() {
			InitializeComponent();
		}
		private void OddButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new OddPage());
		}
		private void EvenButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new EvenPage());
		}
	}
}
