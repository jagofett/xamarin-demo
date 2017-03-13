using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourStops.Pages {
	public partial class BasicsInCodePage {
		public BasicsInCodePage() {

			#region Demo 1
			// There must be a matching class
			// for the x:Class attribute
			#endregion

		}

		#region Demo 2
		private void Demo2() {

			var titleLabel = new Label();
			titleLabel.Text = "Tour Photos";

			var saveButton = new Button();
			saveButton.Text = "Save...";
			saveButton.Clicked += SaveButton_Clicked;
		}
		private void SaveButton_Clicked(object sender, EventArgs e) {
			throw new NotImplementedException();
		}
		#endregion

		#region Demo 3
		private void Demo3() {
			var stepper = new Stepper();
			stepper.Minimum = 15;
			stepper.Maximum = 75;


			var grid = new Grid();
			var colDef = new ColumnDefinition();
			colDef.Width = new GridLength(2, GridUnitType.Star);
			grid.ColumnDefinitions.Add(colDef);
		}
		#endregion

		#region Demo 4
		private void Demo4() {
			var slider = new Slider();
			slider.HorizontalOptions= LayoutOptions.;
		
		}
		#endregion

		#region Demo 5
		private void Demo5() {

			
			var slider = new Slider();
			slider.HorizontalOptions = LayoutOptions.End;

		}
		#endregion

		// Attached Properties (XAML only demo)
		// Binding Expressions (XAML only demo)
		// Value Converters		 (XAML only demo)

	}
}
