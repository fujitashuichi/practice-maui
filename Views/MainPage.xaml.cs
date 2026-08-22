using MauiApp1.Core.ViewModels;

namespace MauiApp1.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageVM();
	}
}
