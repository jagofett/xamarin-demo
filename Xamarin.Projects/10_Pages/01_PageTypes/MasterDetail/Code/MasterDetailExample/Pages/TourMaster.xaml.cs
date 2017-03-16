using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailExample.Pages {
	public partial class TourMaster : MasterDetailPage {
		public TourMaster() {
			InitializeComponent();
			this.Detail = new Pages.PastryPage();
		}
		public void CoffeeButton_Clicked(object sender, EventArgs e) {

			this.Detail = new Pages.PastryPage();
			// change to the detail page
			this.IsPresented = false;
		}

		public void FountainButton_Clicked(object sender, EventArgs e) {

			this.Detail = new Pages.FountainPage();
			// change to the detail page
			this.IsPresented = false;

		}

		public void ArtButton_Clicked(object sender, EventArgs e) {

			this.Detail = new Pages.ArtPage();
			// change to the detail page
			this.IsPresented = false;
		}

	}
}
