namespace MauiApp1.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushModalAsync(new MainPage());
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}