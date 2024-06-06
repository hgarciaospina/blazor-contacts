#pragma checksum "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5749a10b1941a8da946cb99104b9469ff2f862"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ContactList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Contacts</h3>\r\n\r\n");
#nullable restore
#line 9 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
__builder.AddContent(1, Message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<table><tbody><tr><td colspan=\"2\"><a href=\"/contactdetails\" class=\"btn btn-primary mb-2\">Add New</a></td></tr></tbody></table>");
#nullable restore
#line 20 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
 if (contacts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading....</em></p>");
#nullable restore
#line 23 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Name</th>\r\n                <th>Phone</th>\r\n                <th>Address</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 37 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
             foreach (var contact in contacts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
#nullable restore
#line 40 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
__builder.AddContent(11, contact.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 41 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
__builder.AddContent(14, contact.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 42 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
__builder.AddContent(17, contact.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/contactdetails/" + (
#nullable restore
#line 43 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
                                                  contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-warning mb-1");
            __builder.AddContent(23, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/contactdelete/" + (
#nullable restore
#line 44 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
                                                 contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-danger mb-1");
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
       
    IEnumerable<Contact> contacts;
    public string Message { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {
            contacts = await ContactService.GetAll();
        }
        catch (Exception e)
        {
            
            Message = "Error..." + e.InnerException.StackTrace;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
