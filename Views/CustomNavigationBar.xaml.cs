namespace MauiApp1.Views;

public partial class CustomNavigationBar : ContentView
{
	public CustomNavigationBar()
	{
		InitializeComponent();
	}

    private async void HomeButton_Clicked(object sender, EventArgs e)
    {
        await (Application.Current.MainPage as NavigationPage)?.Navigation.PushAsync(new Pages.Page());
    }

    private async void SearchButton_Clicked_1(object sender, EventArgs e)
    {
        await (Application.Current.MainPage as NavigationPage)?.Navigation.PushAsync(new Pages.Page1());
    }

    private async void OverviewKeyButton_Clicked_2(object sender, EventArgs e)
    {
        await (Application.Current.MainPage as NavigationPage)?.Navigation.PushAsync(new Pages.Page3());
    }
}