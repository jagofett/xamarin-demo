using System;

using Xamarin.Forms;

namespace TourStops.Pages {

	public partial class SchedulePage : ContentPage {

		public SchedulePage() {
			InitializeComponent();

			this.Appearing += SchedulePage_Appearing;
		}

		private void SchedulePage_Appearing(object sender, EventArgs e) {
			SetupRows();
			AddHoursColumn();
			AddBusyBlock();
		}

		public void SetupRows() {
			for (int i = 0; i < HourCount+1; i++)
			{
				MainGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
			}
		}
		private const int HourCount = 10;
		private void AddHoursColumn() {
			for (int i = 0; i < HourCount; i++)
			{
				var label = new Label()
				{
					Text = String.Format("{0:D2}:00", i + HourCount -1)
				};
				MainGrid.Children.Add(label, 0, i + 1);
			}
		}

		private void AddBusyBlock() {
			var ran = new Random();

			for (int colCounter = 0; colCounter < 7; colCounter++)
			{
				for (int rowCounter = 0; rowCounter < HourCount; rowCounter++)
				{
					var crowdPercent = ran.NextDouble();
					var box = new BoxView()
					{
						Color = Color.FromRgb(crowdPercent, 0, 1 - crowdPercent),
						HeightRequest = 30
					};
					MainGrid.Children.Add(box, colCounter + 1, rowCounter + 1);
					var label = new Label()
					{
						FontSize = 11,
						HorizontalTextAlignment = TextAlignment.End,
						HeightRequest = 15
					};
					MainGrid.Children.Add(label, colCounter + 1, rowCounter + 1);
				}
			}
		}
	}
}