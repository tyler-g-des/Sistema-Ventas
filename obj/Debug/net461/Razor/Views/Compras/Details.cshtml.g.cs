#pragma checksum "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c8cde97f1c645cb56e7a51943a36223a234418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compras_Details), @"mvc.1.0.view", @"/Views/Compras/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Compras/Details.cshtml", typeof(AspNetCore.Views_Compras_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c8cde97f1c645cb56e7a51943a36223a234418", @"/Views/Compras/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531aaafa2fd7595fba3c4c70c34008b9c7fe1c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Compras_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimerParcial.ViewModels.CompraView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "idArticulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "idCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "borrarDetalleConfirmacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ValidarImprimir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var id = Model.Compra.compraID;

#line default
#line hidden
            BeginContext(126, 579, true);
            WriteLiteral(@"
<h2>Details</h2>

<div class=""modal fade"" id=""adicionarArticulo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""gridSystemModalLabel"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""gridSystemModalLabel"">Adicionar Artículo</h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(706, 157, false);
#line 18 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
           Write(await Html.PartialAsync("AddCompra", Model.CompraDetalle, new ViewDataDictionary(ViewData)
                {
                 {"id",id}
                }));

#line default
#line hidden
            EndContext();
            BeginContext(863, 221, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Cerrar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n    ");
            EndContext();
            BeginContext(1085, 25, false);
#line 29 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
Write(Html.Raw(TempData["msg"]));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 102, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Compra</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1213, 50, false);
#line 36 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Compra.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1307, 53, false);
#line 39 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayFor(model => model.Compra.Cliente.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1404, 52, false);
#line 42 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Compra.FormaPago));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1500, 69, false);
#line 45 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayFor(model => model.Compra.FormaPago.formaPagoDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1613, 53, false);
#line 48 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Compra.FormaEnvio));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1710, 71, false);
#line 51 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayFor(model => model.Compra.FormaEnvio.formaEnvioDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1825, 53, false);
#line 54 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Compra.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1922, 49, false);
#line 57 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayFor(model => model.Compra.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2015, 54, false);
#line 60 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Compra.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2113, 50, false);
#line 63 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
       Write(Html.DisplayFor(model => model.Compra.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 917, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>

<div class=""form-group"">
    <!-- modal -->
    <button type=""button"" class=""btn btn-success btn-large"" data-toggle=""modal"" data-target=""#adicionarArticulo"">Compra Articulo</button>
</div>

<div class=""x_content"">
   
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card-box table-responsive"">
                    <table id=""grid"" name=""grid"" class=""table table-striped table-bordered"">
                        <thead>
                            <tr>
                                <th>Codigo</th>
                                <th>Nombre</th>
                                <th>Precio</th>
                                <th>Cantidad</th>
                                <th>Precio Total</th>
                            </tr>
                        </thead>

                        <tbody class=""data"">

");
            EndContext();
#line 91 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                             foreach (var item in Model.Articulos)
                            {

#line default
#line hidden
            BeginContext(3179, 110, true);
            WriteLiteral("                              <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3290, 54, false);
#line 95 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Articulo.idArticulo));

#line default
#line hidden
            EndContext();
            BeginContext(3344, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3460, 50, false);
#line 98 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Articulo.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3510, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3626, 41, false);
#line 101 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
            EndContext();
            BeginContext(3667, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3783, 43, false);
#line 104 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(3826, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3944, 50, false);
#line 108 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Compra.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3994, 151, true);
            WriteLiteral("\r\n                                </td>\r\n                                \r\n                                <td>\r\n\r\n                                    ");
            EndContext();
            BeginContext(4145, 649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3acfc94452e4738b463d6041305f6ce", async() => {
                BeginContext(4190, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 114 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                         using (Html.BeginForm())
                                        {

#line default
#line hidden
                BeginContext(4302, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4346, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e7b8dc465e445f3a418b010159d39a4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 116 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                                                              WriteLiteral(item.Articulo.idArticulo);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 116 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Articulo.idArticulo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4457, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4503, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c0453290524496da55a43e5edfec7bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 117 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                                                            WriteLiteral(item.compraID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 117 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Compra.compraID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4597, 109, true);
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 119 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"

                                        }

#line default
#line hidden
                BeginContext(4751, 36, true);
                WriteLiteral("                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4794, 82, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n\r\n                              </tr>\r\n");
            EndContext();
#line 126 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"

                            }

#line default
#line hidden
            BeginContext(4909, 201, true);
            WriteLiteral("                        </tbody>\r\n\r\n                        <tbody class=\"data\">\r\n                            <tr>\r\n                                <td>\r\n                                    SubTotal:  ");
            EndContext();
            BeginContext(5111, 51, false);
#line 133 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model.Compra.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(5162, 197, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>\r\n                                    Impuesto:  ");
            EndContext();
            BeginContext(5360, 51, false);
#line 139 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model.Compra.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(5411, 195, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>\r\n                                    Total:   ");
            EndContext();
            BeginContext(5607, 48, false);
#line 145 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => Model.Compra.total));

#line default
#line hidden
            EndContext();
            BeginContext(5655, 232, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n\r\n\r\n\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   \r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5887, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e966053bfffe49f3b99eb419256e516e", async() => {
                BeginContext(5961, 14, true);
                WriteLiteral("Imprimir Orden");
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
#line 160 "C:\Users\tyler.diaz\Documents\DevOps\Practicas\Codigo\Sistema-Ventas\Views\Compras\Details.cshtml"
                                                             WriteLiteral(id);

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
            BeginContext(5979, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(5985, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c665d95a44784b9e8a2cf19443c9231e", async() => {
                BeginContext(6031, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6047, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimerParcial.ViewModels.CompraView> Html { get; private set; }
    }
}
#pragma warning restore 1591
