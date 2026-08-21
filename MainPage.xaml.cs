using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp1;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	private string _text = string.Empty;

	public string Text
	{
		get => _text;
		set
		{
			if (_text != value) {
				_text = value;
				OnPropertyChanged();
			}
		}
	}

	public ICommand ClearTextCommand { get; }


	public MainPage()
	{
		InitializeComponent();

		ClearTextCommand = new Command(() =>
		{
			Text = string.Empty;
		});
		BindingContext = this;
	}


	public new event PropertyChangedEventHandler? PropertyChanged;

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
