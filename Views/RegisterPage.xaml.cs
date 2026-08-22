using MauiApp1.Core.ViewModels;

namespace MauiApp1.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterPageVM();
    }
}
