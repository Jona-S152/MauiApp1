namespace MauiApp1.Pages;

public partial class Page : ContentPage
{
	public Page()
	{
		InitializeComponent();
	}

    private async void btnMainPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}