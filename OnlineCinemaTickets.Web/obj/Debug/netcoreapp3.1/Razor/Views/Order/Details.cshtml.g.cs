#pragma checksum "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93e1bf981404fd0d1d39539af1e1ea94dbd1ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\_ViewImports.cshtml"
using OnlineCinemaTickets.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\_ViewImports.cshtml"
using OnlineCinemaTickets.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93e1bf981404fd0d1d39539af1e1ea94dbd1ccd", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb0561c4a5dc17f3b8177f0d3d17f93a6b77c7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineCinemaTickets.Domain.DomainModels.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container\">\n\n    <p>\n        <a class=\"btn btn-warning\">");
#nullable restore
#line 6 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                              Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 6 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                  Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                                        Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n    </p>\n\n");
#nullable restore
#line 9 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.TicketInOrders.Count(); i++)
    {
        var item = Model.TicketInOrders.ElementAt(i);

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 16 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"col-md-3 m-4\">\n                      <div class=\"card\" style=\"width: 15rem; height: 25rem;\">\n                          <div class=\"card-header\">\n                              <h3>");
#nullable restore
#line 21 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                             Write(item.Ticket.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                          </div>\n\n                          <div class=\"card-body\">\n                              <h4 class=\"card-title\">Release year: ");
#nullable restore
#line 25 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                              Write(item.Ticket.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                              <p class=\"card-text\">Description: ");
#nullable restore
#line 26 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                           Write(item.Ticket.MovieDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                              <p class=\"card-text\">Seat: ");
#nullable restore
#line 27 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                    Write(item.Ticket.SeatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                              <p class=\"card-text\">Genre: ");
#nullable restore
#line 28 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                     Write(item.Ticket.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                              <h6 class=\"pt-3\">Price: $");
#nullable restore
#line 30 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                                  Write(item.Ticket.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                              <h6>Quantity: ");
#nullable restore
#line 31 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                              <h6>Total: $");
#nullable restore
#line 32 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
                                      Write(item.Ticket.TicketPrice * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                          </div>\n                      </div>\n                  </div>\n");
#nullable restore
#line 36 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"


            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\n");
#nullable restore
#line 41 "C:\Users\mtodo\OneDrive\Desktop\OnlineCinemaTickets_201083\OnlineCinemaTickets.Web\Views\Order\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineCinemaTickets.Domain.DomainModels.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
