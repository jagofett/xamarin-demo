using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }



        private async void LoadCustom_ClickedAsync(object sender, EventArgs e)
        {
            filmList1.ItemsSource = new List<string>();
            filmList2.BindingContext = await Data.Data.GetFilmsAsync();
        }

        private async void LoadSimple_ClickedAsync(object sender, EventArgs e)
        {
            filmList2.BindingContext = new List<Data.FilmsDatabase>();
            filmList1.ItemsSource = await Data.Data.GetFilmsAsync();
        }
    }
}
