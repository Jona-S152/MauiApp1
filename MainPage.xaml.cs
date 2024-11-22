namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.ContentArea.Content = new Pages.Page().Content;
        }

        public async void ChangeContent(ContentPage page)
        {
            await Navigation.PushAsync(page);
        }
    }

}
