using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();
		}

		private void NoBindingButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.WithoutBinding());
		}

		private void BindingButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.WithBinding());
		}
		private void ViewButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.ViewToViewBinding());
		}

		private void ConverterButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.UseValueConverterPage());
		}

		private void ChangeButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.ChangeNotificationPage());
		}
		private void ListsButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.BasicList());
		}

		private void DataTemplateButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.DataTemplatePage());
		}

		private void ViewModelButton_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new Pages.WithViewModel());
		}
	}
}
