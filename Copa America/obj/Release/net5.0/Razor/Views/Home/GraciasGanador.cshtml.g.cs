#pragma checksum "C:\Users\santi\ORT\Prg\TP6\Views\Home\GraciasGanador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315e58021cf83e7b25db3cc65ad46e66c37d8147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GraciasGanador), @"mvc.1.0.view", @"/Views/Home/GraciasGanador.cshtml")]
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
#line 1 "C:\Users\santi\ORT\Prg\TP6\Views\_ViewImports.cshtml"
using TP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\santi\ORT\Prg\TP6\Views\_ViewImports.cshtml"
using TP6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"315e58021cf83e7b25db3cc65ad46e66c37d8147", @"/Views/Home/GraciasGanador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee68b3f41481072e20cd15dbb6b2317f1062dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GraciasGanador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\santi\ORT\Prg\TP6\Views\Home\GraciasGanador.cshtml"
  
    ViewData["Title"] = "Gracias";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <h2 class=""titulo"">¡Gracias!</h2>
                <div class=""descripcion"">
                    <p>Gracias por partcipar de la encuesta!. Tu opinion es muy valiosa</p>
                    <p>");
#nullable restore
#line 11 "C:\Users\santi\ORT\Prg\TP6\Views\Home\GraciasGanador.cshtml"
                  Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", gracias por contarnos quien pensas que será el ganador de esta edición.</p>\r\n                    <p>Tu Candidato: ");
#nullable restore
#line 12 "C:\Users\santi\ORT\Prg\TP6\Views\Home\GraciasGanador.cshtml"
                                Write(ViewBag.Ganador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n            <center>\r\n                <img");
            BeginWriteAttribute("src", " src=", 677, "", 729, 1);
#nullable restore
#line 20 "C:\Users\santi\ORT\Prg\TP6\Views\Home\GraciasGanador.cshtml"
WriteAttributeValue("", 682, "/img/banderas/" + @ViewBag.Ganador + ".png", 682, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"banderaGanador\">\r\n        </div>\r\n    </div>\r\n</div>");
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
