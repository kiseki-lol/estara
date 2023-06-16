using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class PlacesPage : Page
{
    public PlacesViewModel ViewModel
    {
        get;
    }

    public PlacesPage()
    {
        ViewModel = App.GetService<PlacesViewModel>();
        InitializeComponent();
    }
}