using System;
using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class WithoutBinding : ContentPage {
		public WithoutBinding() {
			InitializeComponent();

			// Text property set by direct assignment
			Label2.Text = "From a C# String";

			var guide = new Models.Guide();

			guide.GuideName = "Jennie";
			guide.HomeCity = "Miami";
			guide.NumberOfToursLed = 67;

			// Text property set from a Guide property
			// this is _not_ data binding!
			Label2.Text = guide.GuideName;




		}
	}


}
