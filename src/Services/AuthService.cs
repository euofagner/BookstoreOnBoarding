using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Services;

public class AuthService
{
    public async Task<bool> IsAuthenticatedAsync()
    {
        await Task.Delay(2000);
        return false;
    }
}
