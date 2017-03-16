using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WorkingWithListView.Pages {
	public partial class BasicList : ContentPage {
		public BasicList() {
			InitializeComponent();
		}

		private void AddDataButton_Clicked(object sender, EventArgs e) {
			var tourGuides = new List<string>();

			tourGuides.Add("Andrew");
			tourGuides.Add("Jen");
			tourGuides.Add("Miguel");
			tourGuides.Add("Edmar");
			tourGuides.Add("Triss");

			GuidesListView.ItemsSource = tourGuides;

		}
		private void AddData2Button_Clicked(object sender, EventArgs e) {
			var guides = new List<Guide>();
			guides.Add(new Guide { GuideName = "Nikki", HomeCity = "Atlanta", NumberOfToursLed = 35 });
			guides.Add(new Guide { GuideName = "Marcel", HomeCity = "Quebec ", NumberOfToursLed = 271 });
			guides.Add(new Guide { GuideName = "Gwen", HomeCity = "Singapore", NumberOfToursLed = 92 });

			GuidesListView.ItemsSource = guides;

		}
	}
}
	public class Guide {
		public string GuideName { get; set; }
		public string HomeCity { get; set; }
		public int NumberOfToursLed { get; set; }
		private void AddDataButton_Clicked(object sender, EventArgs e) {
		}
	}
