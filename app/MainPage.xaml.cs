namespace MauiStateMvvmDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnIncrementClicked(object? sender, EventArgs e)
	{
		count++;
		UpdateCount();
	}

	private void OnDecrementClicked(object? sender, EventArgs e)
	{
		count--;
		UpdateCount();
	}

	private void OnResetClicked(object? sender, EventArgs e)
	{
		count = 0;
		UpdateCount();
	}

	private void UpdateCount()
	{
		CountLabel.Text = $"Count: {count}";
		SemanticScreenReader.Announce(CountLabel.Text);
	}
}
