#pragma checksum "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e400ef22d6f40a24ea017ff60fc264376061cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FormularioPizza), @"mvc.1.0.view", @"/Views/Home/FormularioPizza.cshtml")]
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
#line 1 "C:\xampp\htdocs\files\ORT\tp09\Views\_ViewImports.cshtml"
using tp09;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\files\ORT\tp09\Views\_ViewImports.cshtml"
using tp09.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e400ef22d6f40a24ea017ff60fc264376061cd", @"/Views/Home/FormularioPizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c674ad5638262737f89e79c8a10d17848665a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FormularioPizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Grande", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mediana", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Chica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
  
    ViewData["Title"] = "Agregar Pizza";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
  
    bool editing = ViewBag.editing;
    string estado = editing ? "Actualizar" : "Agregar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"cuadro\">\r\n    <h1>Agregar Nueva Pizza</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e400ef22d6f40a24ea017ff60fc264376061cd5069", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-sm-12 col-lg-6"">
                <div class=""form-group"">
                    <label>Nombre</label>
                    <input class=""form-control"" name=""nombre"" required />
                </div>

                <div class=""form-group"">
                    <label>Precio</label>
                    <input class=""form-control"" type=""number"" name=""precio"" required />
                </div>

                <div class=""form-group"">
                    <label>Tamano</label>
                    <select class=""form-control"" name=""tamano"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e400ef22d6f40a24ea017ff60fc264376061cd5992", async() => {
                    WriteLiteral("Grande");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e400ef22d6f40a24ea017ff60fc264376061cd7239", async() => {
                    WriteLiteral("Mediana");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e400ef22d6f40a24ea017ff60fc264376061cd8487", async() => {
                    WriteLiteral("Chica");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>

                <div class=""form-group"">
                    <label>Url Foto</label>
                    <input class=""form-control"" name=""urlfoto"" required />
                </div>
            </div>

            <div class=""col-sm-12 col-lg-6"">
                <div class=""form-group"">
                    <div class=""row"">
");
#nullable restore
#line 46 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
                         foreach (Ingrediente Ingrediente in ViewBag.Ingredientes){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12 col-md-4\">\r\n                                <label style=\"cursor:pointer;\" class=\"ingrediente\">\r\n                                    <input type=\"checkbox\" name=\"ingredientes\"");
                BeginWriteAttribute("value", " value=\"", 1827, "\"", 1854, 1);
#nullable restore
#line 49 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
WriteAttributeValue("", 1835, Ingrediente.Nombre, 1835, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 50 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
                               Write(Ingrediente.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <img height=\"130px\" width=\"100%\"");
                BeginWriteAttribute("src", " src=\"", 1985, "\"", 2011, 1);
#nullable restore
#line 51 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
WriteAttributeValue("", 1991, Ingrediente.UrlFoto, 1991, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"disabled\" />\r\n                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 54 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <a");
                BeginWriteAttribute("href", " href=\'", 2277, "\'", 2312, 1);
#nullable restore
#line 61 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
WriteAttributeValue("", 2284, Url.Action("Index", "Home"), 2284, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\">Volver</a>\r\n            <button type=\"submit\" class=\"btn btn-primary\">\r\n                ");
#nullable restore
#line 63 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
           Write(estado);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Pizza\r\n            </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 15 "C:\xampp\htdocs\files\ORT\tp09\Views\Home\FormularioPizza.cshtml"
AddHtmlAttributeValue("", 275, Url.Action("GuardarPizza", "Home"), 275, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral(@"<script src=""https://code.jquery.com/jquery-3.3.1.min.js"" integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="" crossorigin=""anonymous""></script>

<script>
    $("".ingrediente"").click(function(e) {
        if(this.children[1].classList.contains(""disabled""))
        {
            this.children[0].checked = true;
            this.children[1].classList.remove(""disabled"");
        }
        else
        {
            this.children[0].checked = false;
            this.children[1].classList.add(""disabled"");
        }
        e.preventDefault();
    });
</script>");
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
