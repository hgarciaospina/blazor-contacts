#pragma checksum "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9667ab012df09ae17575c77f0822b6f2193da93c"
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
#nullable restore
#line 13 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
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
#nullable restore
#line 6 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
 if(contact == null )
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading....</em></p>");
#nullable restore
#line 9 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                     contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                             Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card");
                __builder2.AddMarkupContent(7, "<h5 class=\"card-header\">Contact Details</h5>\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(16, "<label for>First Name</label>\r\n                            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                                                          contact.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.FirstName = __value, contact.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(25, "<label for>Last Name</label>\r\n                            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 25 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                                                          contact.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.LastName = __value, contact.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "row");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(36, "<label for>Phone</label>\r\n                            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                                                          contact.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Phone = __value, contact.Phone))));
                __builder2.AddAttribute(41, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Phone));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "row");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(47, "<label for>Address</label>\r\n                            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(48);
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                                                              contact.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Address = __value, contact.Address))));
                __builder2.AddAttribute(52, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Address));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "row");
                __builder2.AddMarkupContent(56, "<div class=\"col-md-4 mb-3\"></div>\r\n                        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(59, "<input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\">\r\n                            ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "type", "button");
                __builder2.AddAttribute(62, "class", "btn btn-secondary");
                __builder2.AddAttribute(63, "value", "Cancel");
                __builder2.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
                                                                                                    NavigateHome

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                        <div class=\"col-md-4 mb-3\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 59 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDelete.razor"
       
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
