using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TourStops {
	public class App : Application {
		public App() {

			#region Create Main UI
			// To define the Main UI of the Xamarin.Form app
			// Instantiate a Page class
			// Populate it with Layouts and Controls
			// Assign to the App.MainPage property
			#endregion

			#region Markup as UI definition
			// Modern UI frameworks default to markup languages for UI definition
			// HTML, AXML, .XIB, .Storyboard, XAML
			#endregion
			#region Navigation Page
			// 	
			#endregion
			// The root page of your application
			MainPage = new NavigationPage(new Pages.StartPage());
		
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}
