#pragma checksum "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e290e1d792bdf74ab9fe8235e01f765f171da85a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e290e1d792bdf74ab9fe8235e01f765f171da85a", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 13, true);
            WriteLiteral("\n<h1>Vendor, ");
            EndContext();
            BeginContext(14, 20, false);
#line 2 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
       Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(34, 37, true);
            WriteLiteral("</h3>\n\n<h2>Order Details.</h1>\n\n\n<h3>");
            EndContext();
            BeginContext(72, 20, false);
#line 7 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
Write(Model["order"].Title);

#line default
#line hidden
            EndContext();
            BeginContext(92, 15, true);
            WriteLiteral("</h2>\n<ul>\n<li>");
            EndContext();
            BeginContext(108, 26, false);
#line 9 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
Write(Model["order"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(134, 11, true);
            WriteLiteral("</li>\n<li>$");
            EndContext();
            BeginContext(146, 20, false);
#line 10 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
Write(Model["order"].Price);

#line default
#line hidden
            EndContext();
            BeginContext(166, 15, true);
            WriteLiteral("</li>\n<li>Due. ");
            EndContext();
            BeginContext(182, 19, false);
#line 11 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
    Write(Model["order"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(201, 16, true);
            WriteLiteral("</li>\n</ul>\n\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 217, "\'", 261, 3);
            WriteAttributeValue("", 224, "/vendor/", 224, 8, true);
#line 15 "/Users/Guest/Desktop/VendorsOrdersCsharp/Bakery/Views/Orders/Show.cshtml"
WriteAttributeValue("", 232, Model["vendor"].Id, 232, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 251, "/order/new", 251, 10, true);
            EndWriteAttribute();
            BeginContext(262, 63, true);
            WriteLiteral(">Add another order.</a>\n<a href=\'/vendor\'>View all vendors.</a>");
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
