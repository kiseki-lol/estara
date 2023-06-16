using Estara.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Estara.Views;

public sealed partial class CharacterPage : Page
{
    public CharacterViewModel ViewModel
    {
        get;
    }

    public CharacterPage()
    {
        ViewModel = App.GetService<CharacterViewModel>();
        InitializeComponent();
    }
}