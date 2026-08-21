namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public string? UserName { get; private set; } = null;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnTextChanged(object? sender, TextChangedEventArgs e)
	{
		UserName = e.NewTextValue;
	}

	private void OnUserNameApply(object? sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(UserName))
		{
			MainText.Text = "Who are you?";
		}
		else
		{
			MainText.Text = $"Hello {UserName}!";
		}
	}
}
