#pragma checksum "C:\Users\Rafae\source\repos\TBuggerX\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0acec69287adf0ff90f49f4179034d663b2c52"
// <auto-generated/>
#pragma warning disable 1591
namespace TBuggerX.Shared
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
    public partial class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<div class=\"top-row px-4\">\r\n            \r\n            <link rel=\"stylesheet\" href=\"css/bootstrap/bootstrap.min.css\">\r\n            <link href=\"~/css/StyleSheet.css\" rel=\"stylesheet\">\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.AddContent(7, 
#nullable restore
#line 11 "C:\Users\Rafae\source\repos\TBuggerX\Shared\LoginLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
