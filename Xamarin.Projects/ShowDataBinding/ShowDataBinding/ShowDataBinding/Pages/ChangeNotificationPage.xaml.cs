using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class ChangeNotificationPage : ContentPage {
		public ChangeNotificationPage() {
			InitializeComponent();
			var guide = new Models.Guide();
			guide.GuideName = "Jennie";
			guide.HomeCity = "Miami";
			guide.NumberOfToursLed = 67;

			this.BindingContext = guide;
		}
	}
}
