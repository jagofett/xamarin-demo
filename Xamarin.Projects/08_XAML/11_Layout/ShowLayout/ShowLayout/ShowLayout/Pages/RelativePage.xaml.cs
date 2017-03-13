using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowLayout.Pages
{
	public partial class RelativePage : ContentPage
	{
		public RelativePage()
		{
			InitializeComponent();
		}
		private void HCenterButton_Clicked(object sender, EventArgs e) {
		
			Navigation.PushAsync(new Pages.RelativeLayoutMovedPage());
		
	}

		
	}
}
