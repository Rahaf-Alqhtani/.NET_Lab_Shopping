#pragma checksum "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1017ae653d08cfe5268e63cff5097330c019a06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1017ae653d08cfe5268e63cff5097330c019a06c", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
  
    var Product = (ProductModel) ViewData["Product"]; 



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Available</h3>

<table class=""table table-hover"" align=""center"">
    <thead>
        <tr>
            <th scope=""col"">BOOK'S ID</th>
            <th scope=""col"">BOOK'S NAME</th>
            <th scope=""col"">BOOK'S PRICE</th>
            <th scope=""col"">BOOK'S IMAGE</th>
        </tr>
    </thead>
    <tbody>
        <tr");
            BeginWriteAttribute("style", " style=\"", 405, "\"", 459, 2);
            WriteAttributeValue("", 413, "background-color:", 413, 17, true);
#nullable restore
#line 19 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 430, (string)ViewData["Color"], 431, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <th>");
#nullable restore
#line 20 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
           Write(Product.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
           Write(Product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 22 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
            Write(Product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 591, "\"", 611, 1);
#nullable restore
#line 23 "C:\Users\hiro1\source\repos\Shopping\Shopping\Views\Products\Details.cshtml"
WriteAttributeValue("", 597, Product.Image, 597, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" alt=\"product image\" /></td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<button type=\"button\" class=\"btn btn-info\"><a href=\"/products\">Back</a></button>\r\n");
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