using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourStops.Pages
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage()
		{
			InitializeComponent();
			this.Appearing += FirstPage_Appearing;
		}

		private void FirstPage_Appearing(object sender, EventArgs e)
		{
			TourName.Text = TourStops.Models.TourSource.First().Name;
		}
	}
}
