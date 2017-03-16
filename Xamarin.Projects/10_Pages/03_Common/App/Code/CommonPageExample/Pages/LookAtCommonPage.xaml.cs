using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CommonPageExample.Pages {
	public partial class LookAtCommonPage : ContentPage {
		public LookAtCommonPage() { 
			InitializeComponent();
		}

		private async void AlertButton_Clicked(object sender, EventArgs e) {
			await this.DisplayAlert(title: "Tour notice.",
															message: "Looks like that tour is full.", 
															cancel: "Okay. I understand.");
		}

		private async void ActionSheetButton_Clicked(object sender, EventArgs e) {
			var result = await this.DisplayActionSheet(title: "Share this moment via: ",
																								 cancel: "Nevermind. I don't want to share.", 
																								 destruction: null, 
																				 buttons: new string[] { "Email", "Twitter", "Facebook", "Instagram" });
			MessageLabel.Text = result;
		}

		private void BusyButton_Clicked(object sender, EventArgs e) {
			this.IsBusy = !this.IsBusy;
		}
	}
}
