#pragma checksum "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c5bd5014a556edbca334e97ea9c7841183dab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sedes), @"mvc.1.0.view", @"/Views/Home/Sedes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c5bd5014a556edbca334e97ea9c7841183dab1", @"/Views/Home/Sedes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee68b3f41481072e20cd15dbb6b2317f1062dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sedes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml"
  
    ViewData["Title"] = "Sedes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <h2 class=""titulo"">Sedes</h2>
                <div class=""descripcion"">
                    <p>En este espacio encontrarás las 5 sedes en las que se jugará esta Copa América</p>
                </div>
        </div>
    </div>


<div class=""row"">
");
#nullable restore
#line 17 "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml"
      
        for(int i=0;i<ViewBag.verSedes.Length;i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class= \"col-lg-4 col-md-6 col-sm-12\">\r\n                <div class=\"card bg-warning\" style=\"width: 18rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 632, "\"", 675, 3);
            WriteAttributeValue("", 638, "/img/Sedes/", 638, 11, true);
#nullable restore
#line 22 "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml"
WriteAttributeValue("", 649, ViewBag.verSedes[i], 649, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 671, ".jpg", 671, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml"
                                          Write(ViewBag.verSedes[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\santi\ORT\Prg\TP6\Views\Home\Sedes.cshtml"
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
