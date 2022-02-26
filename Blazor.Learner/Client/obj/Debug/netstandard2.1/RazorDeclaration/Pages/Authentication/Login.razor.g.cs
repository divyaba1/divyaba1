// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Learner.Client.Pages.Authentication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\divya\Source\Repos\Blazor.Learner\Blazor.Learner\Client\Pages\Authentication\Login.razor"
      
    LoginRequest loginRequest { get; set; } = new LoginRequest();
    string error { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await authStateProvider.Login(loginRequest);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
