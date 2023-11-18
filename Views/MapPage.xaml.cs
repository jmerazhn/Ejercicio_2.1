using Ejercicio_2._1.Models;

namespace Ejercicio_2._1.Views;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

public partial class MapPage : ContentPage
{
    Country PaisSeleccionado;
    public MapPage(Country country)
	{
		InitializeComponent();
        PaisSeleccionado = country;
    }
}