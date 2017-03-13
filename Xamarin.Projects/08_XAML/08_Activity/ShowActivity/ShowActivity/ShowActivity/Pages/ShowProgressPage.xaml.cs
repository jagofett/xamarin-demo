using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShowActivity.Pages {
	public partial class ShowProgressPage : ContentPage {
		public ShowProgressPage() {
			InitializeComponent();
		}

		private string loadedText;
		public async void Button_Clicked(object sender, EventArgs e) {
			for (int i = 0; i < 50; i++)
			{
			await WaitAndExecute(130, UpdateText);
				Progress1.Progress = i / 50.0;
				ResultMessage.Text = i.ToString();
			}
		}
		private void UpdateText()
		{
			loadedText += "*";
		}
		private async Task WaitAndExecute(int timeToWaitInMs, Action actionToExecute) {
			await Task.Delay(timeToWaitInMs);
			actionToExecute();
		}
	}
}
