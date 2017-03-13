using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourStops.Pages;
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

			// The root page of your application
			MainPage = new FirstPage();
				//new ContentPage
				//{
				//	Content = new StackLayout
				//	{
				//		VerticalOptions = LayoutOptions.Start,
				//		Children = {
				//		new Label {
				//			HorizontalTextAlignment = TextAlignment.Center,
				//			Text = "Tailor-made Tour Stops",
				//			FontSize = 24
				//		},
				//		new Label {
				//			HorizontalTextAlignment = TextAlignment.Center,
				//			Text = TourStops.Models.TourSource.First().Name,
				//				FontSize = 20,
				//		}}}};
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
