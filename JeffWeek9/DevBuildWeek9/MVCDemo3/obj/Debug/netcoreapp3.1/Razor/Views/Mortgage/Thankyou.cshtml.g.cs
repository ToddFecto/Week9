#pragma checksum "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\Mortgage\Thankyou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de245059879de416486683b68da25f65bb465c8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mortgage_Thankyou), @"mvc.1.0.view", @"/Views/Mortgage/Thankyou.cshtml")]
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
#line 1 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\_ViewImports.cshtml"
using MVCDemo3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\_ViewImports.cshtml"
using MVCDemo3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de245059879de416486683b68da25f65bb465c8c", @"/Views/Mortgage/Thankyou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2cc19211dea355ec28e1d8208e9a4653337243", @"/Views/_ViewImports.cshtml")]
    public class Views_Mortgage_Thankyou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- The model line above SPECIFIES THE TYPE of the object in the Model variable -->\r\n");
#nullable restore
#line 3 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\Mortgage\Thankyou.cshtml"
  
    ViewData["Title"] = "Thankyou";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- We could have done this but it\'s annoying. So we made a Cust variable instead -->\r\n<h1>Thank you ");
#nullable restore
#line 8 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\Mortgage\Thankyou.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\Mortgage\Thankyou.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for your registration!</h1>\r\n\r\nPassword is ");
#nullable restore
#line 10 "C:\Dev\Week9\JeffWeek9\DevBuildWeek9\MVCDemo3\Views\Mortgage\Thankyou.cshtml"
       Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral(" .\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591