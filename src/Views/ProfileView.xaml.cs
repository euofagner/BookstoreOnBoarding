namespace src.Views;

public partial class ProfileView : ContentPage
{
	public ProfileView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}