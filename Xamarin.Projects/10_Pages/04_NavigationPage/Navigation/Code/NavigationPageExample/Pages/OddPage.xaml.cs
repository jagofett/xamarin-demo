using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationPageExample.Pages {
	public partial class OddPage : ContentPage {
		public OddPage() {
			InitializeComponent();
			StringBuilder sb = new StringBuilder();

			for (int i = 1; i < 99; i+=2)
			{
				sb.Append(i.ToString("D2"));
				sb.Append(" ");
			}


			MessageLabel.Text = sb.ToString();
		}
		private void OddMenuA_Clicked(object sender, EventArgs e) {
			this.DisplayAlert("Clicked", "OddMenuA Clicked", "OK");
		}
		private void OddMenuB_Clicked(object sender, EventArgs e) {
			this.DisplayAlert("Clicked", "OddMenuA Clicked", "OK");
		}
	}
}
