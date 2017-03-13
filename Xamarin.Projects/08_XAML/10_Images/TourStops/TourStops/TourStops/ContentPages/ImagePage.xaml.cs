using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourStops.Pages {
	public partial class ImagePage : ContentPage {
		public ImagePage() {
			InitializeComponent();
		}

		private void AspectFitButton_Clicked(object sender, EventArgs e) {

			// Scale the image to fit the view. Some parts may be left empty (letter boxing).
			Image1.Aspect = Image2.Aspect = Aspect.AspectFit;
		}
		private void AspectFillButton_Clicked(object sender, EventArgs e)
		{
			// Scale the image to fill the view. Some parts may be clipped in order to fill
			//     the view.
			Image1.Aspect = Image2.Aspect = Aspect.AspectFill;

		}
		private void FillButton_Clicked(object sender, EventArgs e)
		{
			// Scale the image so it exactly fill the view.Scaling may not be uniform in X and Y
			Image1.Aspect = Image2.Aspect = Aspect.Fill;
		}

	
	}
}
