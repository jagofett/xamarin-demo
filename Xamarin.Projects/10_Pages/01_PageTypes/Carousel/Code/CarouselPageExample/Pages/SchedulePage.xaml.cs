using System;

using Xamarin.Forms;

namespace CarouselPageExample.Pages {

	public partial class SchedulePage : ContentPage {

		public SchedulePage() {
			InitializeComponent();

			this.Appearing += SchedulePage_Appearing;
		}

		private void SchedulePage_Appearing(object sender, EventArgs e) {

			AddHoursColumn();
			AddBusyBlock();
		}


		private const int HourCount = 10;
		private const int DayCount = 7;

		private void AddHoursColumn() {
			for (int i = 0; i < HourCount; i++)
			{
				var label = new Label()
				{
					Text = String.Format("{0:D2}:00 ", i + HourCount - 1)
				};

				Grid.SetColumn(label, 0);
				Grid.SetRow(label, i + 1);
				ScheduleGrid.Children.Add(label);
			}
		}

		private void AddBusyBlock() {
			var ran = new Random();


			for (int colCounter = 0; colCounter < DayCount; colCounter++)
			{
				for (int rowCounter = 0; rowCounter < HourCount; rowCounter++)
				{
					var crowdPercent = ran.NextDouble();
					var box = new BoxView()
					{
						Color = Color.FromRgb(crowdPercent, 0, 1 - crowdPercent)
					};

					Grid.SetColumn(box, colCounter + 1);
					Grid.SetRow(box, rowCounter + 1);
					ScheduleGrid.Children.Add(box);
				}
			}
		}
	}
}