#pragma checksum "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0c30c208ba47d5fcbe16498916568dcc1f50c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Show), @"mvc.1.0.view", @"/Views/Vendor/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendor/Show.cshtml", typeof(AspNetCore.Views_Vendor_Show))]
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
#line 1 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0c30c208ba47d5fcbe16498916568dcc1f50c8", @"/Views/Vendor/Show.cshtml")]
    public class Views_Vendor_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 59, true);
            WriteLiteral("\r\n<h3>Here are all the order in this vendor:</h3>\r\n\r\n<ol>\r\n");
            EndContext();
#line 6 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
            BeginContext(129, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 137, "\'", 189, 4);
            WriteAttributeValue("", 144, "/vendors/", 144, 9, true);
#line 8 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
WriteAttributeValue("", 153, Model["vendor"].Id, 153, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 172, "/orders/", 172, 8, true);
#line 8 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
WriteAttributeValue("", 180, order.Id, 180, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(190, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(192, 14, false);
#line 8 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
                                                         Write(order.newOrder);

#line default
#line hidden
            EndContext();
            BeginContext(206, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 9 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
}

#line default
#line hidden
            BeginContext(220, 18, true);
            WriteLiteral("</ol>\r\n\r\n\r\n\r\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 238, "\'", 284, 3);
            WriteAttributeValue("", 245, "/vendors/", 245, 9, true);
#line 14 "C:\Users\Action\desktop\bakery2\bakery\Views\Vendor\Show.cshtml"
WriteAttributeValue("", 254, Model["vendor"].Id, 254, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 273, "/orders/new", 273, 11, true);
            EndWriteAttribute();
            BeginContext(285, 121, true);
            WriteLiteral(">Add a new order</a></p>\r\n<p><a href=\'/vendors\'>Return to vendor list</a></p>\r\n<p><a href=\'/\'>Return to Main Page</a></p>");
            EndContext();
        }
        #pragma warning restore 1998
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