namespace src.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();

        Shell.SetBackgroundColor(this, Color.FromArgb("#eaeac3"));
        Shell.SetTitleColor(this, Color.FromArgb("#333333"));
        Shell.SetNavBarHasShadow(this, true);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(Library)}");
    }
}
