
using Xamarin.Forms;

namespace ShowDataBinding.Pages {
	public partial class DataTemplatePage : ContentPage {
		public DataTemplatePage() {
			InitializeComponent();

			TourStopsListView.BindingContext = Models.TourSource.TourStops;
		}
	}
}
