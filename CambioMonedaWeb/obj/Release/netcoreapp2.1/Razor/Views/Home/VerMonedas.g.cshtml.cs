#pragma checksum "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2317a589b224d8ba3862bdb3594a9b4b70e8cd4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerMonedas), @"mvc.1.0.view", @"/Views/Home/VerMonedas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/VerMonedas.cshtml", typeof(AspNetCore.Views_Home_VerMonedas))]
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
#line 1 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\_ViewImports.cshtml"
using CambioMonedaWeb;

#line default
#line hidden
#line 2 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\_ViewImports.cshtml"
using CambioMonedaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2317a589b224d8ba3862bdb3594a9b4b70e8cd4c", @"/Views/Home/VerMonedas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2781e1b9505cc94216ecc0ba2bebbb16ad36f9e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerMonedas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CambioMonedaWeb.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleMoneda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 105, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h4 class=\"text-center\">Listado de monedas</h4>\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 7 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"
         foreach (var moneda in Model.ListaMonedas)
        {

#line default
#line hidden
            BeginContext(207, 135, true);
            WriteLiteral("            <div class=\"col-sm-4 col-lg-4 col-md-4 animated fadeIn\">\r\n                <div class=\"thumbnail\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 342, "\"", 367, 1);
#line 11 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"
WriteAttributeValue("", 348, Model.ImagenMoneda, 348, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(368, 131, true);
            WriteLiteral(" alt=\"\">\r\n                    <div class=\"caption\">\r\n                        <h3 class=\"pull-right\"><span class=\"label label-info\">");
            EndContext();
            BeginContext(500, 26, false);
#line 13 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"
                                                                         Write(moneda.IdentificadorMoneda);

#line default
#line hidden
            EndContext();
            BeginContext(526, 72, true);
            WriteLiteral("</span></h3>\r\n                        <h3>\r\n                            ");
            EndContext();
            BeginContext(598, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2701aa73c294eed88855ce3e9ad9521", async() => {
                BeginContext(677, 26, false);
#line 15 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"
                                                                                                     Write(moneda.IdentificadorMoneda);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"
                                                                                  WriteLiteral(moneda.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(707, 33, true);
            WriteLiteral("\r\n                        </h3>\r\n");
            EndContext();
            BeginContext(791, 72, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\usuario\Desktop\Proyecto calculin-temp\Proyecto calculin\CambioMonedaWeb\Views\Home\VerMonedas.cshtml"

        }

#line default
#line hidden
            BeginContext(876, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CambioMonedaWeb.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
