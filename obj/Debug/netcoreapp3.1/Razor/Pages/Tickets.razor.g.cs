#pragma checksum "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ed39ecd3d1757652a9313445f5c9e45c66fecd"
// <auto-generated/>
#pragma warning disable 1591
namespace TBuggerX.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using TBuggerX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rafae\source\repos\TBuggerX\_Imports.razor"
using TBuggerX.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
using TBuggerX.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets")]
    public partial class Tickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tickets</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h3><b>Enter Author Information</b></h3>\r\n    <hr>\r\n\r\n    \r\n    \r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                      user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                            SaveUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-12 row");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<label class=\"col-2 font-weight-bold\">first name :</label>\r\n            ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control col-3");
                __builder2.AddAttribute(16, "placeholder", "first name");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                                                             user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FirstName = __value, user.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(19, (__value) => {
#nullable restore
#line 17 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                         firstNameTextBox = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            &nbsp;");
                __Blazor.TBuggerX.Pages.Tickets.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 18 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                            () => user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-12 row");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<label class=\"col-2 font-weight-bold\">last name :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control col-3");
                __builder2.AddAttribute(31, "placeholder", "last name");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                                               user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.LastName = __value, user.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            &nbsp;");
                __Blazor.TBuggerX.Pages.Tickets.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 24 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                            () => user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        <br>\r\n        <br>\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-12 row");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.AddMarkupContent(43, "<label class=\"col-2 font-weight-bold\">email address :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control col-3");
                __builder2.AddAttribute(46, "placeholder", "email address");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                                               user.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.EmailAddress = __value, user.EmailAddress))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            &nbsp;");
                __Blazor.TBuggerX.Pages.Tickets.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 31 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                            () => user.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-12 row");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.AddMarkupContent(58, "<label class=\"col-2 font-weight-bold\">JobLevel :</label>\r\n            ");
                __Blazor.TBuggerX.Pages.Tickets.TypeInference.CreateInputNumber_3(__builder2, 59, 60, "form-control col-3", 61, 
#nullable restore
#line 36 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                                                 user.JobLevel

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.JobLevel = __value, user.JobLevel)), 63, () => user.JobLevel);
                __builder2.AddMarkupContent(64, "\r\n            &nbsp;");
                __Blazor.TBuggerX.Pages.Tickets.TypeInference.CreateValidationMessage_4(__builder2, 65, 66, 
#nullable restore
#line 37 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                            () => user.JobLevel

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(69, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>

    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
       
    public user user { get; set; }

    public List<user> userList { get; set; }

    ElementReference firstNameTextBox;

    private async Task SaveUser()
    {
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Tickets.razor"
                                                                                   
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TBuggerX.Pages.Tickets
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591