using CommunityToolkit.Maui.Views;

namespace MauiLottiePopupExample;

public partial class ExampleLottiePopup : Popup
{
    public ExampleLottiePopup()
    {
        InitializeComponent();
        // initialize this `InitializeLottieAsync()`
        Initialization = InitializeLottieAsync();
    }

    public Task Initialization { get; private set; }

    public async Task InitializeLottieAsync()
    {
        await Task.Delay(50);
        LottieAnimation.IsAnimationEnabled = true;
        await Task.Delay(6500);
        Close();
    }
}