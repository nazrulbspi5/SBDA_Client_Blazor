#pragma checksum "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f2d803f28323738990b49310e7f0a8f4f3907f"
// <auto-generated/>
#pragma warning disable 1591
namespace SBDA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using SBDA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using SBDA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\_Imports.razor"
using SBDA.Component;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Welcome to your new app.");
                __builder2.AddContent(4, 
#nullable restore
#line 5 "F:\Web Project\Blazor\SBDAWebProject\SBDA.Client\Pages\Index.razor"
                                     context.User.FindFirst("Name")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(5, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
