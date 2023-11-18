using Ejercicio_2._1.Controllers;
using Ejercicio_2._1.Models;
using Ejercicio_2._1.Views;
//using Microsoft.UI.Xaml.Controls;

namespace Ejercicio_2._1
{
    public partial class MainPage : ContentPage
    {

        ApiRest countriesApi;
        List<Country> listCountries;
        public MainPage()
        {
            InitializeComponent();
            countriesApi = new ApiRest();
            listCountries = new List<Country>();
        }

        private async void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var region = cmbRegion.SelectedItem as string;

            var internetAccess = Connectivity.NetworkAccess;
            if (internetAccess == NetworkAccess.Internet)
            {
                listCountries = await countriesApi.GetCountries(region);
                ListCountries.ItemsSource = listCountries;

            }
            else
            {
                await DisplayAlert("Error", "Verifica que tengas acceso a internet", "OK");
            }
        }

        private async void ListCountries_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var country = (Country)e.Item;
            MapViewer pageDetailCountry = new MapViewer(country);
            pageDetailCountry.BindingContext = country;
            await Navigation.PushAsync(pageDetailCountry);
        }
    }
}