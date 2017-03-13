using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowLayout.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}
		private void StackButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.StackPage());
		}
		private void StackButton2_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.StackPage2());
		}
		private void GridSizesButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pages.GridSizesPage());
		}
		private void GridLayoutButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.GridPage());
		}
		private void GridSpacingButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.GridSpacing());
		}
		private void AbsoluteButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pages.AbsolutePage	());
		}
		private void RelativeButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pages.RelativePage());
		}
	}
}
