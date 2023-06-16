using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class VersionsPage : Page
{
    public VersionsViewModel ViewModel
    {
        get;
    }

    public VersionsPage()
    {
        ViewModel = App.GetService<VersionsViewModel>();
        InitializeComponent();
    }
}