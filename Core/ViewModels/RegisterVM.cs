using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MauiApp1.Core.ViewModels;

public partial class RegisterPageVM : ObservableObject
{
    [ObservableProperty]
    private string _name = string.Empty;

    [ObservableProperty]
    private string _email = string.Empty;


    [RelayCommand]
    public void Register()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}");
    }
}
