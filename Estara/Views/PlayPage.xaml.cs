using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class PlayPage : Page
{
    public PlayViewModel ViewModel
    {
        get;
    }

    public PlayPage()
    {
        ViewModel = App.GetService<PlayViewModel>();
        InitializeComponent();
    }
}