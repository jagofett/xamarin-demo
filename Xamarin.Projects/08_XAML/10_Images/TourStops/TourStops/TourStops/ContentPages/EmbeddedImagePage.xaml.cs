using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourStops.Pages {
	public partial class EmbeddedImagePage : ContentPage {
		public EmbeddedImagePage() {
			InitializeComponent();
		}
		private void AddImageButton_Clicked(object sender, EventArgs e) {
			
			Image1.Source = ImageSource.FromResource("TourStops.StopArtInstitute.jpg");
		}
		private void UrlButton_Clicked(object sender, EventArgs e) {
			
			Image1.Source = ImageSource.FromUri(new Uri("http://www.rouxacademy.com/_images/featured_student.jpg"));
		}
	}
	
}
