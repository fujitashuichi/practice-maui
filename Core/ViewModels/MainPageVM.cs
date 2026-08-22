using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MauiApp1.Core.ViewModels;

public partial class MainPageVM : ObservableObject
{
    [ObservableProperty]
    private string _text = string.Empty;

    [RelayCommand]
    public void ClearText()
    {
        Text = string.Empty;
    }
}
