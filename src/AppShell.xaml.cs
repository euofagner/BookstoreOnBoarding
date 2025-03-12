using src.Views;

namespace src;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        ////Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        //Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    }
}
