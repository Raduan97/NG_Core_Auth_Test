using System;
using Microsoft.AspNetCore.Identity;

namespace NG_Core_Auth.Controllers
{
    internal class SignManager<T>
    {
        public static implicit operator SignManager<T>(SignInManager<IdentityUser> v)
        {
            throw new NotImplementedException();
        }
    }
}