#pragma checksum "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\Mortgage\MyPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4be90e8d88e09ac316b874224c85f3b68ec1438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mortgage_MyPage), @"mvc.1.0.view", @"/Views/Mortgage/MyPage.cshtml")]
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
#line 1 "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\_ViewImports.cshtml"
using Lab9_2_MVC2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\_ViewImports.cshtml"
using Lab9_2_MVC2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4be90e8d88e09ac316b874224c85f3b68ec1438", @"/Views/Mortgage/MyPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0503f4c3536dac5ad89cd13784f09b5e098db2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Mortgage_MyPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\Mortgage\MyPage.cshtml"
  
    ViewData["Title"] = "MyPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyPage</h1>\r\n\r\n<h2>Here\'s your name:</h2>\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\Mortgage\MyPage.cshtml"
Write(ViewData["FirstName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Dev\Week9\Lab9_2_MVC2\Lab9_2_MVC2\Views\Mortgage\MyPage.cshtml"
                  Write(ViewData["Lastname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
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
