using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourStops.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		
		}

	
		public void ShowImageButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pages.ImagePage());

		}
		public void EmbeddedImageButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pages.EmbeddedImagePage());

		}
		
	}
}
