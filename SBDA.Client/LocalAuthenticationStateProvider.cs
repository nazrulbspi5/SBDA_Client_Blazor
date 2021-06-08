using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using SBDA.Shared;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SBDA.Client
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _storageService;
        private readonly IJSRuntime _jsRuntime;
        public LocalAuthenticationStateProvider(ILocalStorageService localStorage, IJSRuntime jSRuntime)
        {
            _storageService = localStorage;
            _jsRuntime = jSRuntime;
        }
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (await _storageService.ContainKeyAsync("User"))
            {
                var userInfo = _storageService.GetItemAsync<LocalUserInfo>("User");
                var claims = new[]
                {
                   new Claim("UserName",userInfo.Result.UserName),
                   new Claim(ClaimTypes.NameIdentifier,userInfo.Result.Id),
                   new Claim("AccessToken",userInfo.Result.AccessToken),
                   new Claim("Name",userInfo.Result.Name)
                };
                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);
                return new AuthenticationState(user);
            }
            return new AuthenticationState(new ClaimsPrincipal());
        }

    }
}
