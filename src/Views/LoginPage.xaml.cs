using src.Services;
using System.Threading.Tasks;

namespace src.Views;

public partial class LoginPage : ContentPage
{
    private AuthService _authService;

	public LoginPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.IsChecked)
                _authService.Login();
        }
    }
}