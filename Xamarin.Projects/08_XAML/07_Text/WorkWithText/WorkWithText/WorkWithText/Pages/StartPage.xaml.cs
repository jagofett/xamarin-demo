using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WorkWithText.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}

		private void TextEntryButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.TextEntryPage());
		}
		private void FontsButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.FontsPage());
		}
		private void LabelFormattingButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.LabelFormattingPage());
		}
	}
}
