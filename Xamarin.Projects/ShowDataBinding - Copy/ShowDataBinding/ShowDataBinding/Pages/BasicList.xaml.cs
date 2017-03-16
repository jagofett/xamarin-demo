using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class BasicList : ContentPage {
		public BasicList() {
			InitializeComponent();
		}

		private void AddDataButton_Clicked(object sender, EventArgs e) {
			var tourGuides = new ObservableCollection<string>();

			tourGuides.Add("Andrew");
			tourGuides.Add("Jen");
			tourGuides.Add("Miguel");
			tourGuides.Add("Edmar");
			tourGuides.Add("Triss");

			#region Change Visibility
			ExampleListView.IsVisible = true;
			ExampleBindingListView.IsVisible = false;
			#endregion

			ExampleListView.ItemsSource = tourGuides;


		}
		private void AddData2Button_Clicked(object sender, EventArgs e) {
			var guides = new ObservableCollection<Models.Guide>();
			guides.Add(new Models.Guide
			{
				GuideName = "Nikki",
				HomeCity = "Atlanta",
				NumberOfToursLed = 35
			});
			guides.Add(new Models.Guide
			{
				GuideName = "Marcel",
				HomeCity = "Quebec ",
				NumberOfToursLed = 271
			});
			guides.Add(new Models.Guide
			{
				GuideName = "Gwen",
				HomeCity = "Singapore",
				NumberOfToursLed = 92
			});

			#region Change Visibility
			ExampleListView.IsVisible = true;
			ExampleBindingListView.IsVisible = false;
			#endregion
			ExampleListView.ItemsSource = guides;

		}
		private void AddData3Button_Clicked(object sender, EventArgs e) {
			
			#region Change Visibility
			ExampleListView.IsVisible = false;
			ExampleBindingListView.IsVisible = true;
			#endregion
			ExampleBindingListView.BindingContext = Models.TourSource.TourStops;
		}
	}
}

