using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowLayout.Pages {
	public partial class StackPage2 : ContentPage {
		public StackPage2() {
			InitializeComponent();
		}

		private void PaddingStepper_ValueChanged(object sender, ValueChangedEventArgs e) {
			StackLayout1.Padding = new Thickness(PaddingStepper.Value);
			
		}

		private void SpacingStepper_ValueChanged(object sender, ValueChangedEventArgs e) {
			StackLayout1.Spacing = SpacingStepper.Value; 
		}

		private void OrientationSwitch_Toggled(object sender, ToggledEventArgs e) {
			if (e.Value)
			{
				StackLayout1.Orientation = StackOrientation.Horizontal;
			}
			else
			{
				StackLayout1.Orientation = StackOrientation.Vertical;
			}

		}
	}
}
