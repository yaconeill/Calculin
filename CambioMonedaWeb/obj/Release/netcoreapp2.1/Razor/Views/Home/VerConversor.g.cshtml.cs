#pragma checksum "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0f210763ecdd3d8a5abce70476abecfb0b099e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerConversor), @"mvc.1.0.view", @"/Views/Home/VerConversor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/VerConversor.cshtml", typeof(AspNetCore.Views_Home_VerConversor))]
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
#line 1 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\_ViewImports.cshtml"
using CambioMonedaWeb;

#line default
#line hidden
#line 2 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\_ViewImports.cshtml"
using CambioMonedaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0f210763ecdd3d8a5abce70476abecfb0b099e", @"/Views/Home/VerConversor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2781e1b9505cc94216ecc0ba2bebbb16ad36f9e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerConversor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CambioMonedaWeb.ConversionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Cantidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Cantidad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerConversor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUno"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
  ViewData["Title"] = "VerConversor";

#line default
#line hidden
            BeginContext(86, 266, true);
            WriteLiteral(@"
<style>
    form > .form-control, form > .form-group, #sort {
        margin: 5px 0;
    }
</style>
<div class=""jumbotron"">
    <h3 class=""text-center"">Cambio de moneda</h3>
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            ");
            EndContext();
            BeginContext(352, 1302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c64d620e974079bcba5eff4dbcf6c0", async() => {
                BeginContext(411, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(429, 268, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1841dcb1214b40199c59f0bbb38efaa0", async() => {
                    BeginContext(595, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(617, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c91b2c2d46e4b09b9a6d1eb5fa516b5", async() => {
                        BeginContext(643, 18, true);
                        WriteLiteral("Selecciona uno ...");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(670, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 15 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdOrigen);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 16 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@Model.ListaMonedas, "IdentificadorMoneda", "Nombre"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(697, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(715, 269, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c7fb8d5f6c4d8787d8811a7f6fdc19", async() => {
                    BeginContext(882, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(904, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eacdfcf09e074407be41cbb8b61b3b58", async() => {
                        BeginContext(930, 18, true);
                        WriteLiteral("Selecciona uno ...");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(957, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 19 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdDestino);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 20 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@Model.ListaMonedas, "IdentificadorMoneda", "Nombre"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(984, 133, true);
                WriteLiteral("\r\n                <div class=\"input-group\">\r\n                    <span class=\"input-group-addon\">Importe</span>\r\n                    ");
                EndContext();
                BeginContext(1117, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07939876ef6e4ffb9a1f14c6cb7ba341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 25 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Cantidad);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1223, 424, true);
                WriteLiteral(@"
                    <span class=""input-group-addon"">.00</span>
                </div>
                <div class=""form-group"">
                    <input type=""submit"" class=""btn btn-primary"" value=""Convertir"" />
                    <button type=""button"" id=""sort"" class=""btn btn-info btn-sm pull-right""><span class=""glyphicon glyphicon-sort"" aria-hidden=""true""></span></button>

                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1654, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
     if (Model.Resultado != 0)
    {

#line default
#line hidden
            BeginContext(1723, 81, true);
            WriteLiteral("        <hr />\r\n        <h4 class=\"text-center\">Resultado de la conversión</h4>\r\n");
            EndContext();
            BeginContext(1806, 191, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-6 col-sm-offset-3 animated fadeIn\">\r\n                <div class=\"thumbnail\">\r\n                    <div class=\"caption text-center\">\r\n");
            EndContext();
#line 45 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                          
                            if (Model.Resultado == -1)
                            {

#line default
#line hidden
            BeginContext(2112, 303, true);
            WriteLiteral(@"                                <div class=""alert alert-danger"" role=""alert"">
                                    <span class=""glyphicon glyphicon-exclamation-sign"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Error:</span>
                                    ");
            EndContext();
            BeginContext(2416, 14, false);
#line 51 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                               Write(Model.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(2430, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 53 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2568, 41, true);
            WriteLiteral("                                <h3><span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2609, "\"", 2670, 3);
            WriteAttributeValue("", 2617, "currency-flag", 2617, 13, true);
            WriteAttributeValue(" ", 2630, "currency-flag-", 2631, 15, true);
#line 56 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
WriteAttributeValue("", 2645, Model.IdOrigen.ToLower(), 2645, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2671, 23, true);
            WriteLiteral("></span> Origen | <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2694, "\"", 2756, 3);
            WriteAttributeValue("", 2702, "currency-flag", 2702, 13, true);
            WriteAttributeValue(" ", 2715, "currency-flag-", 2716, 15, true);
#line 56 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
WriteAttributeValue("", 2730, Model.IdDestino.ToLower(), 2730, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2757, 107, true);
            WriteLiteral("></span> Destino </h3>\r\n                                <h3>\r\n                                    Importe: ");
            EndContext();
            BeginContext(2865, 14, false);
#line 58 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                        Write(Model.Cantidad);

#line default
#line hidden
            EndContext();
            BeginContext(2879, 8, true);
            WriteLiteral(" <small>");
            EndContext();
            BeginContext(2888, 14, false);
#line 58 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                                               Write(Model.IdOrigen);

#line default
#line hidden
            EndContext();
            BeginContext(2902, 158, true);
            WriteLiteral("</small>\r\n                                    <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\r\n                                    ");
            EndContext();
            BeginContext(3061, 15, false);
#line 60 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                               Write(Model.Resultado);

#line default
#line hidden
            EndContext();
            BeginContext(3076, 8, true);
            WriteLiteral(" <small>");
            EndContext();
            BeginContext(3085, 15, false);
#line 60 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                                       Write(Model.IdDestino);

#line default
#line hidden
            EndContext();
            BeginContext(3100, 49, true);
            WriteLiteral("</small>\r\n                                </h3>\r\n");
            EndContext();
#line 62 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(3207, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3306, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 69 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"

    }

#line default
#line hidden
            BeginContext(3405, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 71 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
     if (Model.Historiales.Count != 0)
    {

#line default
#line hidden
            BeginContext(3452, 862, true);
            WriteLiteral(@"        <hr />
        <h4 class=""text-center"">Historial de búsquedas</h4>
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2 animated fadeIn"">
                <div class=""table-responsive"">
                    <table class=""table table-striped table-hover"" id=""historiales"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Moneda Origen:</th>
                                <th>Moneda Destino:</th>
                                <th>Factor de cambio:</th>
                                <th>Cantidad:</th>
                                <th>Resultado:</th>
                                <th>Fecha de conversión:</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 91 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                             foreach (var h in Model.Historiales)
                            {

#line default
#line hidden
            BeginContext(4412, 111, true);
            WriteLiteral("                                <tr class=\"history\" data-toggle=\"modal\" data-target=\"#modalHistorial\" data-id=\"");
            EndContext();
            BeginContext(4524, 4, false);
#line 93 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                                                                                          Write(h.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4528, 140, true);
            WriteLiteral("\">\r\n                                    <td><span class=\"glyphicon glyphicon-zoom-in\"></span></td>\r\n                                    <td>");
            EndContext();
            BeginContext(4669, 10, false);
#line 95 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.IdOrigen);

#line default
#line hidden
            EndContext();
            BeginContext(4679, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4727, 11, false);
#line 96 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.IdDestino);

#line default
#line hidden
            EndContext();
            BeginContext(4738, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4786, 8, false);
#line 97 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.Factor);

#line default
#line hidden
            EndContext();
            BeginContext(4794, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4842, 10, false);
#line 98 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.Cantidad);

#line default
#line hidden
            EndContext();
            BeginContext(4852, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4900, 11, false);
#line 99 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.Resultado);

#line default
#line hidden
            EndContext();
            BeginContext(4911, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(4959, 36, false);
#line 100 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                                   Write(h.Fecha.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(4995, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 102 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
                            }

#line default
#line hidden
            BeginContext(5072, 2587, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""modal fade"" id=""modalHistorial"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                        <h4 class=""modal-title"">Detalles del historial</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-md-8 col-md-offset-2"">
                                    <label for=""monedaOrigen"">Moneda de origen</label>
                                    <output id=""monedaOrigen"" />

                                </div>
                                <div class=""col-md-8 col-md-offset-2"">
        ");
            WriteLiteral(@"                            <label for=""monedaDestino"">Moneda de destino </label>
                                    <output id=""monedaDestino"" />

                                </div>
                                <div class=""col-md-8 col-md-offset-2"">
                                    <label for=""factorCambio"">Factor de cambio</label>
                                    <output id=""factorCambio"" />

                                </div>
                                <div class=""col-md-8 col-md-offset-2"">
                                    <label for=""cantidad"">Cantidad</label>
                                    <output id=""cantidad"" />

                                </div>
                                <div class=""col-md-8 col-md-offset-2"">
                                    <label for=""resultado"">Resultado </label>
                                    <output id=""resultado"" />

                                </div>
                                <div class=""col-md-8 col");
            WriteLiteral(@"-md-offset-2"">
                                    <label for=""fecha"">Fecha de conversión</label>
                                    <output id=""fecha"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 156 "C:\Users\usuario\Desktop\Proyecto calculin-final\Proyecto calculin\CambioMonedaWeb\Views\Home\VerConversor.cshtml"
    }

#line default
#line hidden
            BeginContext(7666, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7696, 2436, true);
                WriteLiteral(@"
    <script>
        $(document).ready(() => {
            $('#formUno #IdOrigen').change((self) => hideSelected(self, $('#formUno #IdDestino').children()));

            $('#formLista #IdOrigen')
                .change((self) => hideSelected(self, $('#formLista #monedaDestino').find('input')));

            function hideSelected(self, selector) {
                const selected = self.target.selectedOptions[0].value;
                selector.each((i, o) => {
                    o.type === ""checkbox"" ? $(o).parent().parent().show() : $(o).show();
                });
                selector.each(function(i, o) {
                    if (o.value === selected && o.value !== ""Selecciona uno ..."")
                        o.type === ""checkbox"" ? $(o).parent().parent().hide() : $(o).hide();
                });
            }

            $('#formUno #Cantidad').focusout(function() {
                let value = $(this).val();
                $(this).val(value.replace(/\./, ','));
            });");
                WriteLiteral(@"

            let sort = document.getElementById('sort');
            sort.addEventListener('click',
                () => {
                    let origen = document.getElementById('IdOrigen');
                    let destino = document.getElementById('IdDestino');
                    let prevOrigen = origen.selectedIndex;
                    let prevDestino = destino.selectedIndex;
                    origen.selectedIndex = prevDestino;
                    destino.selectedIndex = prevOrigen;
                });

            $("".history"").click(function() {
                let id = $(this).data('id');
                fetch(`${window.location.origin}/api/historiales/${id}`)
                    .then(r => r.json())
                    .then(data => {
                        let fecha = new Date(data.fecha);
                        $('.modal #monedaOrigen').val(data.idOrigen);
                        $('.modal #monedaDestino').val(data.idDestino);
                        $('.modal #factorCa");
                WriteLiteral(@"mbio').val(data.factor);
                        $('.modal #cantidad').val(data.cantidad);
                        $('.modal #resultado').val(data.resultado);
                        $('.modal #fecha').val(`${fecha.getDate()}-${fecha.getMonth()}-${fecha.getFullYear()} ${fecha.getHours()}:${fecha.getMinutes()}`);
                    });
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CambioMonedaWeb.ConversionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
