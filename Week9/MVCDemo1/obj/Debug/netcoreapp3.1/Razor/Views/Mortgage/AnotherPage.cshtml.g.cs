#pragma checksum "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e31fa40f4fbe743fd228063b976e7f6da01cd31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mortgage_AnotherPage), @"mvc.1.0.view", @"/Views/Mortgage/AnotherPage.cshtml")]
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
#line 1 "C:\Dev\Week9\Week9\MVCDemo1\Views\_ViewImports.cshtml"
using MVCDemo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week9\Week9\MVCDemo1\Views\_ViewImports.cshtml"
using MVCDemo1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e31fa40f4fbe743fd228063b976e7f6da01cd31", @"/Views/Mortgage/AnotherPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7916066170d90a0bf6c72d8f1a5c945e8ec94af6", @"/Views/_ViewImports.cshtml")]
    public class Views_Mortgage_AnotherPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
  
    ViewData["Title"] = "AnotherPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AnotherPage</h1>\r\n\r\n<h2> Here\'s an H2 tag</h2>\r\nHello World!!!\r\n<br />\r\n\r\n<!-- ");
            WriteLiteral("@ -->\r\n\r\n");
#nullable restore
#line 14 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nOur course is called ");
#nullable restore
#line 16 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
                Write(ViewData["Course"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 18 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
Write(5 + 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\nThe amount is ");
#nullable restore
#line 21 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
         Write(ViewData["Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with interest rate ");
#nullable restore
#line 21 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
                                                Write(ViewData["Interest"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<h2>The People:</h2>\r\n\r\n");
#nullable restore
#line 26 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
   
    foreach (string person in ViewData["ThePeople"] as List<string>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"MyPerson\">");
#nullable restore
#line 29 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
                         Write(person);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 30 "C:\Dev\Week9\Week9\MVCDemo1\Views\Mortgage\AnotherPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
