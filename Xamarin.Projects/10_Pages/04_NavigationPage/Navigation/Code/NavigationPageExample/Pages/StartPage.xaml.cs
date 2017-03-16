using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationPageExample.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}

		private void RedButton_Clicked(object sender, EventArgs e) {
			// Currently one page on the Navigation stack
			// Start page was pushed on the stack in the app constructor
			var stackCount = Navigation.NavigationStack.Count; 
			Navigation.PushAsync(new RedPage());
		}

		private void BlueButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new BluePage());
		}
	}
}
