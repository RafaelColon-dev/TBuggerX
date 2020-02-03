#pragma checksum "C:\Users\Rafae\source\repos\TBuggerX\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6cdcebf12870b6123f89808c1f0e4903bbc138"
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
#line 3 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Login.razor"
using TBuggerX.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : LoginLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n        \r\n        <div class=\"container-fluid float-left\">\r\n            <div class=\"row loginSection\">\r\n                <div class=\"col loginArt\">\r\n                    <img src=\"../../assets/signup_art.png\" alt>\r\n                </div>\r\n                <div class=\"col loginForm\">\r\n                    <h2>Log In</h2>\r\n                    <form v-on:submit.prevent=\"loginFunc\">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"input_username\">Username</label>\r\n                            <input type=\"username\" class=\"form-control\" id=\"input_username\" placeholder=\"Enter username\" v-model=\"this.login.username\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"input_password\">Password</label>\r\n                            <input type=\"password\" class=\"form-control\" id=\"input_password\" placeholder=\"Password\" v-model=\"this.login.password\">\r\n                        </div>\r\n                        <small class=\"accountRecovery\">\r\n                            Forgot your\r\n                            <a href=\"#\">username</a> or\r\n                            <a href=\"#\">password</a>?\r\n                        </small>\r\n                        <div class=\"form-group\">\r\n                            <button type=\"submit\" class=\"btn btn-primary loginButton float-right\">\r\n                                Log In\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"form-group bottom\">\r\n                            <p>\r\n                                <img class=\"forgotIcon\" src=\"../../assets/exclamation.png\" alt>\r\n                                Don\'t have an account?\r\n                                <a href=\"/#/signup\">Sign Up!</a>\r\n                            </p>\r\n                            <br>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Rafae\source\repos\TBuggerX\Pages\Login.razor"
       
    string username;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
