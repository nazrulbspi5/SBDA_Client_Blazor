using SBDA.Client.Services;
using SBDA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AKSoftware.WebApi.Client;

namespace SBDA.Client.Repository
{
    public class AuthenticationRepository : IAuthenticationService
    {
        private string _baseUrl;
        ServiceClient _client = new ServiceClient();
        public AuthenticationRepository(string url)
        {
            _baseUrl = url;
        }
        public async Task<UserManagerResponse> CreateUserAsync(RegisterViewModel model)
        {
            var response=  await _client.PostAsync<UserManagerResponse>($"{_baseUrl}api/auth/register", model);
            return response.Result;
        }
        public async Task<UserManagerResponse> LoginUserAsync(LoginViewModel model)
        {
            var response = await _client.PostAsync<UserManagerResponse>($"{_baseUrl}api/auth/login", model);
            return response.Result;
        }
    }
}
