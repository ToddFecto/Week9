#pragma checksum "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9464a613cd69aa46b07f7e519a4ee12be9c53c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistrationThankYou), @"mvc.1.0.view", @"/Views/Home/RegistrationThankYou.cshtml")]
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
#line 1 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\_ViewImports.cshtml"
using Lab9_2_CoffeeHouseReg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\_ViewImports.cshtml"
using Lab9_2_CoffeeHouseReg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9464a613cd69aa46b07f7e519a4ee12be9c53c", @"/Views/Home/RegistrationThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a10305c6d4286b716911704a3ee0f228b95156", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistrationThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
  
    ViewData["Title"] = "RegistrationThankYou";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thank You!</h1>\r\n\r\n<link href=\"/css/styles.css\" rel=\"stylesheet\" />\r\n\r\n<div class=\"ThankYouBox\">\r\n    Thank you ");
#nullable restore
#line 11 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for registering to join GC Coffee Shop!\r\n    <br />\r\n    Please confirm your information or go back to the registration page, if changes are needed:\r\n    <br />\r\n    <ul>\r\n        <li>Name: ");
#nullable restore
#line 16 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
             Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                              Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Email: <a");
            BeginWriteAttribute("href", " href=\"", 478, "\"", 512, 2);
            WriteAttributeValue("", 485, "mailto:", 485, 7, true);
#nullable restore
#line 17 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
WriteAttributeValue(" ", 492, Model.EmailAddress, 493, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                                                    Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        <li>Phone: <a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 595, 2);
            WriteAttributeValue("", 572, "tel:", 572, 4, true);
#nullable restore
#line 18 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
WriteAttributeValue(" ", 576, Model.PhoneNumber, 577, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                                                Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        <li>Password Set: <a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 681, 2);
            WriteAttributeValue("", 661, "tel:", 661, 4, true);
#nullable restore
#line 19 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
WriteAttributeValue(" ", 665, Model.Password, 666, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                                                    Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n    </ul>\r\n    We will contact you at <a");
            BeginWriteAttribute("href", " href=\"", 749, "\"", 783, 2);
            WriteAttributeValue("", 756, "mailto:", 756, 7, true);
#nullable restore
#line 21 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
WriteAttributeValue(" ", 763, Model.EmailAddress, 764, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Dev\Week9\Lab9_2_CoffeeHouseReg\Lab9_2_CoffeeHouseReg\Views\Home\RegistrationThankYou.cshtml"
                                                            Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> with any new updates or specials.\r\n    <br />\r\n    Don\'t forget to come in for your free beverage, for signing up!\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591
