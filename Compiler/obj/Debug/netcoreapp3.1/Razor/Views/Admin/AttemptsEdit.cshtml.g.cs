#pragma checksum "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a78d1a0664a1dfe0021930b51c51d86bda9cdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AttemptsEdit), @"mvc.1.0.view", @"/Views/Admin/AttemptsEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a78d1a0664a1dfe0021930b51c51d86bda9cdf", @"/Views/Admin/AttemptsEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39ff93acdd44ab088184b28e037f940f8a6399c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AttemptsEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Attempt>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
 if (Model.Count!=0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div class=""fs-3 text-center mb-5"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Задание</th>
                    <th scope=""col"">Всего попыток</th>
                    <th scope=""col"">Использовано</th>
                    <th scope=""col"">Добавить:</th>
                </tr>
            </thead>
");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
                        Write($"{item.Kata.Name}\t({item.Kata.Language.Name}");

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
                       Write(item.MaxAttempts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
                       Write(item.CurrentAttempts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a78d1a0664a1dfe0021930b51c51d86bda9cdf5924", async() => {
                WriteLiteral("\r\n                                <input class=\"form-control\" type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 918, 1);
#nullable restore
#line 25 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
WriteAttributeValue("", 906, item.UserId, 906, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input class=\"form-control\" type=\"hidden\" name=\"kataId\"");
                BeginWriteAttribute("value", " value=\"", 1011, "\"", 1031, 1);
#nullable restore
#line 26 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
WriteAttributeValue("", 1019, item.KataId, 1019, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <input class=""form-control"" type=""number"" name=""number"" min=""0"" step=""1"" value=""1"">
                                <button class=""form-control btn btn-primary"" type=""submit"">Добавить</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
            }   

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Нет данных</h3>\r\n");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\Compiler\Compiler\Views\Admin\AttemptsEdit.cshtml"
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
