#pragma checksum "C:\Users\esteb\Desktop\gitkraken\webservices\soap\SoapClient\SoapClient\Views\Home\Saludo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359e59e8c2f5e62ccccecf577e371628916e59a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Saludo), @"mvc.1.0.view", @"/Views/Home/Saludo.cshtml")]
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
#line 3 "C:\Users\esteb\Desktop\gitkraken\webservices\soap\SoapClient\SoapClient\Views\_ViewImports.cshtml"
using SoapClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esteb\Desktop\gitkraken\webservices\soap\SoapClient\SoapClient\Views\_ViewImports.cshtml"
using SoapClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359e59e8c2f5e62ccccecf577e371628916e59a8", @"/Views/Home/Saludo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046238f2806b83e55f926f877309784729f7a721", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Saludo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/verSaludo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\esteb\Desktop\gitkraken\webservices\soap\SoapClient\SoapClient\Views\Home\Saludo.cshtml"
  
    ViewBag.Title = "Saludo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""row d-flex justify-content-center"">
        <div class=""col-11 col-ms-11 col-lg-4 bg-white rounded border shadow-sm mx-1 mb-3 mb-lg-0"">
            <h3 class=""text-uppercase font-weight-bold my-4"">Obtener Saludo</h3>
            <hr>
            <p class=""text-justify my-2 py-3"">
                En esta sección podrás obtener un <a class=""badge badge-primary"">saludo</a> personalizado a partir de tus apellidos, tus nombres y tu sexo.<br><br>Solo ingresa tus datos en los campos disponibles y presiona <a class=""badge badge-success"">enviar</a>.
            </p>
        </div>
        <div class=""col-11 col-ms-11 col-lg-7 bg-white rounded border shadow-sm mx-1"">
            <div class=""row d-flex justify-content-center pt-4"">
                <div class=""col-10"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359e59e8c2f5e62ccccecf577e371628916e59a85032", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\">\r\n                                <div class=\"form-group\">\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 1126, "\"", 1132, 0);
                EndWriteAttribute();
                WriteLiteral(@">Apellido Paterno</label>
                                    <input type=""text"" class=""form-control form-control-sm"" placeholder=""Ingresa tu apellido paterno"" name=""ap"">
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""form-group"">
                                    <label");
                BeginWriteAttribute("for", " for=\"", 1531, "\"", 1537, 0);
                EndWriteAttribute();
                WriteLiteral(@">Apellido Materno</label>
                                    <input type=""text"" class=""form-control form-control-sm"" placeholder=""Ingresa tu apellido paterno"" name=""am"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label");
                BeginWriteAttribute("for", " for=\"", 1903, "\"", 1909, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombres</label>
                            <input type=""text"" class=""form-control form-control-sm"" placeholder=""Ingresa tus nombres"" name=""nombres"">
                        </div>
                        <label>Sexo</label>
                        <br>
                        <div class=""form-check form-check-inline"">
                            <input type=""radio"" name=""sexo"" value=""H"" class=""form-check-input mr-2"">
                            <label class=""form-check-label"">H</label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input type=""radio"" name=""sexo"" value=""M"" class=""form-check-input mr-2"">
                            <label class=""form-check-label"">M</label>
                        </div>
                        <div class=""d-flex justify-content-center"">
                            <button class=""btn btn-success"" type=""submit"">Enviar</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br>\r\n<br>");
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
