using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Services;

public class AuthService
{
    private const string AuthStateKey = "AuthState";

    public async Task<bool> IsAuthenticatedAsync()
    {
        await Task.Delay(1000);

        var authState = Preferences.Default.Get<bool>(AuthStateKey, false);
        return authState;
    }

    public void Login()
    {
        Preferences.Default.Set<bool>(AuthStateKey, true);
    }

    public void Logout() 
    {
        Preferences.Default.Remove(AuthStateKey);
    }
}
