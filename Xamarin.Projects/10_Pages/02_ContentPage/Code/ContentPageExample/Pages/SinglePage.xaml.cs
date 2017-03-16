using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ContentPageExample.Pages {
	public partial class SinglePage : ContentPage {
		public SinglePage() {
			InitializeComponent();
		}

		public void MoreButton_Clicked(object sender, EventArgs e) {

			FirstStackLayout.IsVisible = !FirstStackLayout.IsVisible;
			SecondStackLayout.IsVisible = !SecondStackLayout.IsVisible;
		}
	}
}
