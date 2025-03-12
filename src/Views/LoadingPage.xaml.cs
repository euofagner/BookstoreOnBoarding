using src.Services;
using System.Threading.Tasks;

namespace src.Views;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;

	public LoadingPage(AuthService authService)
	{
		InitializeComponent();

		_authService = authService;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if(await _authService.IsAuthenticatedAsync())
        {
            await Shell.Current.GoToAsync($"{nameof(HomePage)}");
        } 
        else
        {
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
        }
    }
}