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

		public void ShowDetailsButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DetailsPage());

		}
		public void ShowTilesButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new TilesPage());

		}
		public void ShowScheduleButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new SchedulePage());

		}
		public void ShowTabbedButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new TourTabbedPage());
		}
	}
}
