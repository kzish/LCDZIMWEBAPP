#pragma checksum "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a136f407ef313ec768eacc84c144cd823fb2aef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a136f407ef313ec768eacc84c144cd823fb2aef", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 27, true);
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
            EndContext();
#line 6 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(204, 140, true);
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a  class=\"nav-link text-dark\" asp-area=\"Identity\" asp-page=\"/Account/Manage/Index\" title=\"Manage\">Hello ");
            EndContext();
            BeginContext(345, 18, false);
#line 9 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
                                                                                                            Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(363, 126, true);
            WriteLiteral("!</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <form  class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\"");
            EndContext();
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 489, "\"", 558, 1);
#line 12 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 511, Url.Action("Index", "Home", new { area = "" }), 511, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(559, 123, true);
            WriteLiteral(">\r\n            <button  type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n        </form>\r\n    </li>\r\n");
            EndContext();
#line 16 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(694, 272, true);
            WriteLiteral(@"    <li class=""nav-item"">
        <a class=""nav-link text-dark"" asp-area=""Identity"" asp-page=""/Account/Register"">Register</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link text-dark"" asp-area=""Identity"" asp-page=""/Account/Login"">Login</a>
    </li>
");
            EndContext();
#line 25 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
            BeginContext(969, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
