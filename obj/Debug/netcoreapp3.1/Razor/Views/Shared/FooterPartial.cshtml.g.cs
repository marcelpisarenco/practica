#pragma checksum "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "852d42626863dc0a0385c446f8972877466ac58f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 2 "D:\University\Semestru 4\Practica\CompanyServices\Views\_ViewImports.cshtml"
using CompanyServices.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\University\Semestru 4\Practica\CompanyServices\Views\_ViewImports.cshtml"
using CompanyServices.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\University\Semestru 4\Practica\CompanyServices\Views\_ViewImports.cshtml"
using CompanyServices.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\University\Semestru 4\Practica\CompanyServices\Views\_ViewImports.cshtml"
using CompanyServices.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852d42626863dc0a0385c446f8972877466ac58f", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"904a7ad39fe6b9431898749f61dfdaf406239700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""footer"" class=""wrapper"">
    <div class=""title"">Company Contacts</div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6 col-12-medium"">

                <section>
                    <h3 class=""icon solid fa-envelope"">Email</h3>
                    <p>
                        ");
#nullable restore
#line 11 "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml"
                   Write(Config.CompanyEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </section>\r\n\r\n                <section>\r\n                    <h3 class=\"icon solid fa-phone\">Phone</h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 18 "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml"
                   Write(Config.CompanyPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </section>
            </div>
            <div class=""col-6 col-12-medium"">

                <section class=""feature-list small"">
                    <div class=""row"">
                        <div class=""col-6 col-12-small"">
                            <section>
                                <h3 class=""icon solid fa-home"">Mailing Address</h3>
                                <p>
                                    ");
#nullable restore
#line 30 "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml"
                               Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
                                    str.Stefan cel Mare<br />
                                    Chisinau, Moldova
                                </p>
                            </section>
                        </div>
                        <div class=""col-6 col-12-small"">
                            <section>
                                <h3 class=""icon solid fa-comment"">Social</h3>
                                <p>
                                    <a href=""#"">facebook.com/");
#nullable restore
#line 40 "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml"
                                                        Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </p>
                            </section>
                        </div>

                    </div>
                </section>

            </div>
        </div>
        <div id=""copyright"">
            <ul>
                <li>&copy; ");
#nullable restore
#line 52 "D:\University\Semestru 4\Practica\CompanyServices\Views\Shared\FooterPartial.cshtml"
                      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(". All rights reserved</li>\r\n                <li>Design: <a href=\"http://html5up.net\">HTML5 UP</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</section>");
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
