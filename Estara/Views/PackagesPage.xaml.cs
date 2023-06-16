using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class PackagesPage : Page
{
    public PackagesViewModel ViewModel
    {
        get;
    }

    public PackagesPage()
    {
        ViewModel = App.GetService<PackagesViewModel>();
        InitializeComponent();
    }
}