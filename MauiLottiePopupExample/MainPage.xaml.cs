using CommunityToolkit.Maui.Views;

namespace MauiLottiePopupExample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		var popup = new ExampleLottiePopup();
		this.ShowPopup(popup);
	}
}

