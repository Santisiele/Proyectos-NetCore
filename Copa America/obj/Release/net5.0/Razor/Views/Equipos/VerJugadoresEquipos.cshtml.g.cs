#pragma checksum "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6f3015a8c57f3dbb35e7d447dd7b0717b5d11c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipos_VerJugadoresEquipos), @"mvc.1.0.view", @"/Views/Equipos/VerJugadoresEquipos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6f3015a8c57f3dbb35e7d447dd7b0717b5d11c", @"/Views/Equipos/VerJugadoresEquipos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee68b3f41481072e20cd15dbb6b2317f1062dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipos_VerJugadoresEquipos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
  
    ViewData["Title"] = "Jugadores";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
        <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <h2 class=""titulo"">Equipos</h2>
                <div class=""descripcion"">
                    <p>En esta página podrás encontrar los jugadores de ");
#nullable restore
#line 9 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
                                                                    Write(ViewBag.Equipos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Los links llevan a la wikipedia del jugador</p>\r\n                </div>\r\n        </div>\r\n    </div>\r\n\r\n<div class=\"row\" style=\"justify-content: center\">\r\n<div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n\r\n<center>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 615, 3);
            WriteAttributeValue("", 578, "/img/seleccion/", 578, 15, true);
#nullable restore
#line 19 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
WriteAttributeValue("", 593, ViewBag.Equipos, 593, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 611, ".jpg", 611, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" id=\"seleccion\" alt=\"Responsive image\">\r\n</center>\r\n<br><br><br><br>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 24 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
 for (int i = 0; i < ViewBag.Jugadores.Length;i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-md-6 col-sm-12 my-3\">\r\n<center>\r\n          <div class=\"card\" style=\"width: 15rem;\" >\r\n           <div class=\"card-body\"> \r\n              <h4 class=\"card-title\">");
#nullable restore
#line 29 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
                                Write(ViewBag.Jugadores[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n              <p class=\"card-text\"> ");
#nullable restore
#line 30 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
                               Write(ViewBag.EquiJugadores[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <a");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1138, 2);
            WriteAttributeValue("", 1087, "https://es.wikipedia.org/wiki/", 1087, 30, true);
#nullable restore
#line 31 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
WriteAttributeValue("", 1117, ViewBag.Jugadores[i], 1117, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Ver Info. Jugador</a>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\santi\ORT\Prg\TP6\Views\Equipos\VerJugadoresEquipos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
