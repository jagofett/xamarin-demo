using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Pickers.Pages {
	public partial class PickersPage : ContentPage {
		public PickersPage() {
			InitializeComponent();

			this.Appearing += PickersPage_Appearing;
		}
		private void PickersPage_Appearing(object sender, EventArgs e) {
			DatePicker1.MinimumDate = DateTime.Parse("2018/6/14");
			foreach (var stop in TourStops.Models.TourSource.GetAllTourStops())
			{
				Picker1.Items.Add(stop.Name);

			}
		}

		private void MeetButton_Clicked(object sender, EventArgs e) {
			var tourStop = TourStops.Models.TourSource.GetAllTourStops()[Picker1.SelectedIndex];
			MessageLabel.Text = String.Format("Meet me at {0} on {1} at {2}",
																					tourStop.Name,
																					DatePicker1.Date.ToString("d"),
																					TimePicker1.Time);
		}
	}
}
