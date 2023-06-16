using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class HostPage : Page
{
    public HostViewModel ViewModel
    {
        get;
    }

    public HostPage()
    {
        ViewModel = App.GetService<HostViewModel>();
        InitializeComponent();
    }
}