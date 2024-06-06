// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/contactdelete/{id:int}")]
    public partial class ContactDelete : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Proyectos\blazor-contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
       
    public Contact contact;

    [Parameter]
    public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        contact = await ContactService.GetDetails(id);
    }

    protected async Task Delete()
    {
        await ContactService.DeleteContact(id);
        NavigateHome();
    }

    private void NavigateHome()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
