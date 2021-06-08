using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SBDA.Client.Services;
using SBDA.Shared;
namespace SBDA.Client.Pages.Auth
{
    public partial class Login
    {
        [Inject]
        public IAuthenticationService AuthService { get; set; }
        [Inject]
        AuthenticationStateProvider  authenticationStateProvider { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ILocalStorageService storageService { get; set; }
        public string Message { get; set; }

        AlertMessageType messageType = AlertMessageType.Success;
        public LoginViewModel LoginModel { get; set; } = new LoginViewModel();
        
        protected async Task HandleValidRegister()
        {
            var result = await AuthService.LoginUserAsync(LoginModel);
            if (result.IsSuccess)
            {
                //Message = "Welcome to SBDA";
                // messageType = AlertMessageType.Success;
                //var userInfo = new LocalUserInfo()
                //{
                //    AccessToken = result.Message,
                //    UserName = result.UserInfo["UserName"],
                //    Name = result.UserInfo["Name"],
                //    Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier]
                //};
              
                //await storageService.SetItemAsync("User", userInfo);
                //await storageService.SetItemAsync("authToken", userInfo);
                await authenticationStateProvider.GetAuthenticationStateAsync();
                NavigationManager.NavigateTo("/index");
            }
            else
            {
                Message =  result.Message;
                messageType = AlertMessageType.Error;
            }
        }
    }
}
