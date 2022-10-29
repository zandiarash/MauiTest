namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	bool alt = false;
	private void OnCounterClicked(object sender, EventArgs e)
	{
		TxtMessage.HorizontalTextAlignment = alt ? TextAlignment.Start : TextAlignment.End;
		TxtMessage.VerticalTextAlignment = alt ? TextAlignment.Start : TextAlignment.End;
		alt = !alt;
    }
}

