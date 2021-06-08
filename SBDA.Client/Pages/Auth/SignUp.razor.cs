using Microsoft.AspNetCore.Components;
using SBDA.Client.Services;
using SBDA.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace SBDA.Client.Pages.Auth
{
    public partial class SignUp
    {
        [Inject]
        public IAuthenticationService AuthService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string Message { get; set; }
       
        AlertMessageType messageType = AlertMessageType.Success;
        public RegisterViewModel Register { get; set; } = new RegisterViewModel();
        //protected async override Task OnInitializedAsync()
        //{
        //    Register= new RegisterViewModel
        //    {
        //        //Name = "Nazrul",
        //        RoleName="Admin"
               
        //    };
            
        //}
        protected async Task HandleValidRegister()
        {
            //RegisterViewModel result = null;
           
            var result = await AuthService.CreateUserAsync(Register);
            if (result.IsSuccess)
            {
                Message = result.Message;
                messageType = AlertMessageType.Success;
            }
            else
            {
                Message = result.Errors.FirstOrDefault()??result.Message;
                messageType = AlertMessageType.Error;
            }
        }
        
    }
}
