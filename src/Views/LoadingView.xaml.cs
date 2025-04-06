using src.Services;

namespace src.Views;

public partial class LoadingView : ContentPage
{
    private AuthService _authService;

	public LoadingView(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticatedAsync())
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        else
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}