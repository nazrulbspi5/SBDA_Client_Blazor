using SBDA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SBDA.Client.Services
{
   
    public interface IAuthenticationService
    {
        Task<UserManagerResponse> CreateUserAsync(RegisterViewModel model);
        Task<UserManagerResponse> LoginUserAsync(LoginViewModel model);
    }
}
