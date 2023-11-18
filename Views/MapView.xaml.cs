using Ejercicio_2._1.Models;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Net.NetworkInformation;

namespace Ejercicio_2._1.Views;
using Map = Microsoft.Maui.Controls.Maps.Map;
public partial class MapView : ContentPage
{
    Country PaisSeleccionado;
    public MapView(Country country)
	{
        PaisSeleccionado = country;
        InitializeComponent();
        //loadConfiguration();
        Map map = new Map();
        Content = map;


    }

    private void loadConfiguration()
    {

        var pin = new Pin()
        {
            Type = PinType.SavedPin,
            Location = new Location(PaisSeleccionado.latlng[0], PaisSeleccionado.latlng[1]),
            Label = PaisSeleccionado.NameCountry.official,
            Address = "Capital: " + PaisSeleccionado.capital
        };

        mapa.Pins.Add(pin);
        mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(PaisSeleccionado.latlng[0], PaisSeleccionado.latlng[1]), Distance.FromKilometers(41)));

        mapa.Pins.Add(pin);
        mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(PaisSeleccionado.latlng[0], PaisSeleccionado.latlng[1]), Distance.FromKilometers(41)));
    }
}