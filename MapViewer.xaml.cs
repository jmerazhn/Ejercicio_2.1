using Ejercicio_2._1.Models;

namespace Ejercicio_2._1;

public partial class MapViewer : ContentPage
{
    Country PaisSeleccionado;
    public MapViewer(Country country)
	{
		InitializeComponent();
        PaisSeleccionado = country;
    }
}