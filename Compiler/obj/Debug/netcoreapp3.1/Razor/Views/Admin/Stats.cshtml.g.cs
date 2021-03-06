#pragma checksum "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104e952f1aa07b588488a38687a2ea0e9440b026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Stats), @"mvc.1.0.view", @"/Views/Admin/Stats.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\_ViewImports.cshtml"
using Compiler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\_ViewImports.cshtml"
using Compiler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\_ViewImports.cshtml"
using Compiler.Domain.Entities.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\_ViewImports.cshtml"
using Compiler.Domain.Entities.Logs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\_ViewImports.cshtml"
using Compiler.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104e952f1aa07b588488a38687a2ea0e9440b026", @"/Views/Admin/Stats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39ff93acdd44ab088184b28e037f940f8a6399c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Stats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Attempt>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
 if (Model.Count() != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div class=\"fs-3 text-center mb-5\">\r\n            ");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
        Write($"{Model.FirstOrDefault().User.FirstName} {Model.FirstOrDefault().User.LastName}\t{Model.FirstOrDefault().User.Group}\t({Model.FirstOrDefault().User.UserName})");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">??????????????</th>
                        <th scope=""col"">?????????? ??????????????</th>
                        <th scope=""col"">????????????????????????</th>
                        <th scope=""col"">????????????</th>
                    </tr>
                </thead>
");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                            Write($"{item.Kata.Name}\t({item.Kata.Language.Name}");

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                            <td>");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                           Write(item.MaxAttempts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                           Write(item.CurrentAttempts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                             if (item.IsSolved)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"fs-3 text-success\">\r\n                                    ????\r\n                                </td>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"fs-3 text-danger\">\r\n                                    ??????\r\n                                </td>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>   \r\n                    </tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>?????? ????????????</h3>\r\n");
#nullable restore
#line 46 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\Stats.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Attempt>> Html { get; private set; }
    }
}
#pragma warning restore 1591
