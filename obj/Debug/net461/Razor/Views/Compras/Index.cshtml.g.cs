#pragma checksum "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caeb257a188c9ec0bc7ea6afdbfae29ade2b7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compras_Index), @"mvc.1.0.view", @"/Views/Compras/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Compras/Index.cshtml", typeof(AspNetCore.Views_Compras_Index))]
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
#line 1 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\_ViewImports.cshtml"
using PrimerParcial;

#line default
#line hidden
#line 2 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\_ViewImports.cshtml"
using PrimerParcial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4caeb257a188c9ec0bc7ea6afdbfae29ade2b7af", @"/Views/Compras/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531aaafa2fd7595fba3c4c70c34008b9c7fe1c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Compras_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrimerParcial.Models.Entidades.Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fa346e299204009b869f5b011390ade", async() => {
                BeginContext(178, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(192, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(285, 43, false);
#line 16 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(384, 45, false);
#line 19 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FormaPago));

#line default
#line hidden
            EndContext();
            BeginContext(429, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(485, 46, false);
#line 22 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FormaEnvio));

#line default
#line hidden
            EndContext();
            BeginContext(531, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(587, 46, false);
#line 25 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(633, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(689, 47, false);
#line 28 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(792, 44, false);
#line 31 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(836, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(892, 44, false);
#line 34 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(936, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(992, 41, false);
#line 37 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.total));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1151, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1200, 52, false);
#line 46 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.idCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1308, 65, false);
#line 49 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FormaPago.formaPagoDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1429, 67, false);
#line 52 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FormaEnvio.formaEnvioDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1552, 45, false);
#line 55 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1653, 46, false);
#line 58 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1755, 43, false);
#line 61 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1854, 43, false);
#line 64 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1953, 40, false);
#line 67 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.total));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2048, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97aaa1cd99bd436f816839fff612fb1d", async() => {
                BeginContext(2123, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
                                                               WriteLiteral(item.compraID);

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
            BeginContext(2131, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2151, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e79afbc5fdb474b940d39ece34b38b9", async() => {
                BeginContext(2231, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
                                                                    WriteLiteral(item.compraID);

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
            BeginContext(2242, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2262, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25280330b2c4167b92430cba897e602", async() => {
                BeginContext(2338, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
                                                                WriteLiteral(item.compraID);

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
            BeginContext(2348, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2387, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrimerParcial.Models.Entidades.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
