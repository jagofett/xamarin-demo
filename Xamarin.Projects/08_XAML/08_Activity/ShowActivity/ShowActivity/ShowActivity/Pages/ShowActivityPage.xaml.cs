using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowActivity.Pages {
	public partial class ShowActivityPage : ContentPage {
		public ShowActivityPage() {
			InitializeComponent();
		}

		public void Button_Clicked(object sender, EventArgs e) {
			Activity1.IsRunning = !Activity1.IsRunning;
		}

		public async void WebButton_Clicked(object sender, EventArgs e) {
			var urlString = "http://www.rouxacademy.com/";
			var httpClient = new HttpClient();
			Activity2.IsRunning = true;
			var responseMessage = await httpClient.GetAsync(urlString);

			if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
			{
				await Task.Delay(2500);  // add delay in demo, to see the effect.
				WebTextLabel.Text = await responseMessage.Content.ReadAsStringAsync();
			
			}
			Activity2.IsRunning = false;

		}

	}
}
