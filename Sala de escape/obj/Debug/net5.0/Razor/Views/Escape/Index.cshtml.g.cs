#pragma checksum "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Escape\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de68586eea14fc9cd8bb2c7ab92926803d36cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escape_Index), @"mvc.1.0.view", @"/Views/Escape/Index.cshtml")]
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
#line 1 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\_ViewImports.cshtml"
using TP7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\_ViewImports.cshtml"
using TP7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de68586eea14fc9cd8bb2c7ab92926803d36cad", @"/Views/Escape/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2dee2682a229adccc76d28c7514d60cd2d99bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Escape_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Escape\Index.cshtml"
  
    ViewData["Title"] = "Introduccion";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
<div class= ""tam"">
<div class= ""fondo"">
    <section class=""cover bg-black text-white overflow-hidden"">
      <div class=""container foreground"">
        <div class=""row align-items-center justify-content-center vh-100"">
          <div class=""col-lg-10 text-center text-shadow"">
            <h4 class=""eyebrow""><span class=""eyebrow font-weight-bold"">¿Estas listo?</span></h4>
            <h1 class=""display-1 font-weight-bold mt-2 mb-5"">Reglas <span class=""d-lg-block"">del juego</span></h1>
            <p class= ""text""> Estás por comenzar el juego, son cuatro habitaciones de las que deberás escapar, en cada una de ellas obtendrás una clave que necesitaras para pasar a la sala siguiente. En la última de las mismas deberás buscar la llave que te permita salir completamente del shopping. Te deseamos mucha suerte y esperamos que puedas escapar! Hasta la próxima!</p>
            <br>
<br>
<center>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de68586eea14fc9cd8bb2c7ab92926803d36cad4611", async() => {
                WriteLiteral(@"
<div class=""input-group ml-0.9 mr-0.9 mb-0"">
  <input type=""text"" class=""form-control"" name= ""nombreUs"" placeholder=""Ingrese su nombre"" aria-label=""clave"" aria-describedby=""button-addon2"">
  <div class=""input-group-append"">
    <button class=""btn btn-danger"" type=""submit"">Enviar</button>
 </div>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 17 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Escape\Index.cshtml"
AddHtmlAttributeValue("", 984, Url.Action("Habitacion1","Escape"), 984, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br>
          </div>
        </div>
      </div>

      <div class=""canvas aos-init aos-animate"" data-aos=""fade-in"" data-aos-delay=""250"">
        <div class=""container-fluid showcase"">
          <div class=""row gutter-2 gutter-md-4 gutter-lg-6"">
            <div class=""col-6 col-md-4 col-lg-3 skrollable skrollable-between"" data-top-top=""transform: translateY(0%);"" data-top-bottom=""transform: translateY(-10%);"" style=""transform: translateY(-0.322581%);"">
              <img class=""mb-2 mb-md-4 mb-lg-6"" src=""assets/images/demo/preview/section-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1918, "\"", 1924, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2022, "\"", 2028, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2126, "\"", 2132, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2230, "\"", 2236, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2334, "\"", 2340, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2438, "\"", 2444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-6 col-md-4 col-lg-3 skrollable skrollable-between"" data-top-top=""transform: translateY(0%);"" data-top-bottom=""transform: translateY(10%);"" style=""transform: translateY(1.15207%);"">
              <img class=""mb-2 mb-md-4 mb-lg-6"" src=""assets/images/demo/preview/section-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2772, "\"", 2778, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2876, "\"", 2882, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2980, "\"", 2986, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3084, "\"", 3090, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3188, "\"", 3194, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""d-none d-md-block col-md-4 col-lg-3 skrollable skrollable-between"" data-top-top=""transform: translateY(0%);"" data-top-bottom=""transform: translateY(-10%);"" style=""transform: translateY(-1.98157%);"">
              <img class=""mb-2 mb-md-4 mb-lg-6"" src=""assets/images/demo/preview/section-8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3536, "\"", 3542, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3640, "\"", 3646, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3744, "\"", 3750, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-10.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3849, "\"", 3855, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3953, "\"", 3959, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4057, "\"", 4063, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""d-none d-lg-block col-lg-3 skrollable skrollable-between"" data-top-top=""transform: translateY(0%);"" data-top-bottom=""transform: translateY(10%);"" style=""transform: translateY(10%);"">
              <img class=""mb-2 mb-md-4 mb-lg-6"" src=""assets/images/demo/preview/section-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4389, "\"", 4395, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4493, "\"", 4499, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-9.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4597, "\"", 4603, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-8.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4701, "\"", 4707, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4805, "\"", 4811, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              <img class=\"mb-2 mb-md-4 mb-lg-6\" src=\"assets/images/demo/preview/section-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4909, "\"", 4915, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n\r\n      <span class=\"scroll-down\"></span>\r\n    </section>\r\n  </div>\r\n  </div>\r\n  <center>");
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
