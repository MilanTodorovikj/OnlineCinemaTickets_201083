#pragma checksum "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Account\AddRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d38b981eb5a816a606578757ab616f61d06829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AddRole), @"mvc.1.0.view", @"/Views/Account/AddRole.cshtml")]
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
#nullable restore
#line 1 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\_ViewImports.cshtml"
using OnlineCinemaTickets.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\_ViewImports.cshtml"
using OnlineCinemaTickets.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d38b981eb5a816a606578757ab616f61d06829", @"/Views/Account/AddRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce60df7df4f1bfc03bc39281ccc6dbcf587eb46", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_AddRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineCinemaTickets.Domain.Identity.AddRoleModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Account\AddRole.cshtml"
 using (Html.BeginForm("AddRole", "Account"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group w-50\">\r\n        ");
#nullable restore
#line 7 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Account\AddRole.cshtml"
   Write(Html.DropDownListFor(x => x.Username, new SelectList(Model.usernames), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group w-50\">\r\n        ");
#nullable restore
#line 10 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Account\AddRole.cshtml"
   Write(Html.DropDownListFor(x => x.SelectedRole, new SelectList(Model.roles), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-outline-secondary\">Save</button>\r\n");
#nullable restore
#line 13 "E:\Fakultet\III GODINA\VI SEMESTAR\Milan\Integrirani sistemi\Domasno\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Account\AddRole.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineCinemaTickets.Domain.Identity.AddRoleModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591