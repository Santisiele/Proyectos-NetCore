#pragma checksum "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a79fb6bbeb7eec33db7199463b6ba0df39e27e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2dee2682a229adccc76d28c7514d60cd2d99bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Escape"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e6580", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 7 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Sala de escape</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e7221", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e8399", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <style>
      .bs-example{
          margin: 20px;
        }
    </style>
   <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta charset=""utf-8"">
    <meta name=""keywords"" content=""Homemade Restaurant, about, Learn Cooking Online, 1, 2, 1, Asian Food, m fe ia st hand"">
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 1093, "\"", 1103, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""page_type"" content=""np-template-header-footer-from-plugin"">
    <title>Home 1</title>
    <link rel=""stylesheet"" href=""nicepage.css"" media=""screen"">
    <link rel=""stylesheet"" href=""Home-1.css"" media=""screen"">
    <script class=""u-script"" type=""text/javascript"" src=""jquery-1.9.1.min.js""");
                BeginWriteAttribute("defer", " defer=\"", 1414, "\"", 1422, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script class=\"u-script\" type=\"text/javascript\" src=\"nicepage.js\"");
                BeginWriteAttribute("defer", " defer=\"", 1504, "\"", 1512, 0);
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <meta name=""generator"" content=""Nicepage 3.20.8, nicepage.com"">
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">
    <link id=""u-page-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Playfair+Display:400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"">
    

    <meta name=""theme-color"" content=""#4c137c"">
    <meta property=""og:title"" content=""Home 1"">
    <meta property=""og:type"" content=""website"">
     <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta charset=""utf-8"">
    <meta name=""keywords"" content=""CreativeAgency"">
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 2323, "\"", 2333, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""page_type"" content=""np-template-header-footer-from-plugin"">
    <title>Page 3</title>
    <link rel=""stylesheet"" href=""nicepage.css"" media=""screen"">
    <link rel=""stylesheet"" href=""Page-3.css"" media=""screen"">
    <script class=""u-script"" type=""text/javascript"" src=""jquery-1.9.1.min.js""");
                BeginWriteAttribute("defer", " defer=\"", 2644, "\"", 2652, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script class=\"u-script\" type=\"text/javascript\" src=\"nicepage.js\"");
                BeginWriteAttribute("defer", " defer=\"", 2734, "\"", 2742, 0);
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <meta name=""generator"" content=""Nicepage 3.21.0, nicepage.com"">
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">
    <link id=""u-page-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"">
    
    
    <meta name=""theme-color"" content=""#4c137c"">
    <meta property=""og:title"" content=""Page 3"">
    <meta property=""og:type"" content=""website"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e14419", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 59 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
      
      if (ViewBag.MostrarNavBarJuego == false){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          <nav class=""navbar navbar-expand-lg navbar-dark"" style= ""background-color:#23272a;"">
              <div class= ""container"">
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                  <span class=""navbar-toggler-icon""></span>
                </button>
                  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                      <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                          <a class=""navbar-brand""");
                BeginWriteAttribute("href", " href=\'", 4210, "\'", 4244, 1);
#nullable restore
#line 69 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4217, Url.Action("Index","Home"), 4217, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sala de escape</a>\r\n                        </li>\r\n                        <li class=\"nav-item active\">\r\n                          <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\'", 4400, "\'", 4437, 1);
#nullable restore
#line 72 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4407, Url.Action("Tutorial","Home"), 4407, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Tutorial</a>\r\n                        </li>\r\n                        <li class=\"nav-item active\">\r\n                          <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\'", 4587, "\'", 4623, 1);
#nullable restore
#line 75 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4594, Url.Action("Index","Escape"), 4594, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Jugar</a>\r\n                        </li>\r\n                      </ul>\r\n                  </div>\r\n              </div>\r\n          </nav>\r\n");
#nullable restore
#line 81 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
    } 
    else {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <nav class=\"navbar navbar-expand-lg navbar-dark\" style= \"background-color: #23272a;\">\r\n            <div class= \"container\">\r\n              <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\'", 4948, "\'", 4982, 1);
#nullable restore
#line 85 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4955, Url.Action("Index","Home"), 4955, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Sala de escape </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                  <span class=""navbar-toggler-icon""></span>
                </button>
              <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                  <li class=""nav-item active"">
                  ");
#nullable restore
#line 92 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
             Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                  </li>\r\n                </ul>\r\n");
#nullable restore
#line 95 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                        
                        if(ViewBag.Habitacion1 == true){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"btn btn-outline-info my-2 my-sm-0\"");
                BeginWriteAttribute("href", " href=\'", 5727, "\'", 5763, 1);
#nullable restore
#line 97 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5734, Url.Action("Index","Escape"), 5734, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Volver al inicio</a>\r\n");
#nullable restore
#line 98 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                      }
                        else if (ViewBag.Habitacion2 == true){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"btn btn-outline-info my-2 my-sm-0\"");
                BeginWriteAttribute("href", " href=\'", 5948, "\'", 5990, 1);
#nullable restore
#line 100 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5955, Url.Action("Habitacion1","Escape"), 5955, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Volver a la sala 1</a>\r\n");
#nullable restore
#line 101 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                        }
                        else if (ViewBag.Habitacion3 == true){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"btn btn-outline-info my-2 my-sm-0\"");
                BeginWriteAttribute("href", " href=\'", 6179, "\'", 6221, 1);
#nullable restore
#line 103 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6186, Url.Action("Habitacion1","Escape"), 6186, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Volver a la sala 1</a>\r\n");
#nullable restore
#line 104 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                        }
                        else if (ViewBag.Habitacion4 == true){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"btn btn-outline-info my-2 my-sm-0\"");
                BeginWriteAttribute("href", " href=\'", 6410, "\'", 6452, 1);
#nullable restore
#line 106 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6417, Url.Action("Habitacion1","Escape"), 6417, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Volver a la sala 1</a>\r\n");
#nullable restore
#line 107 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                        }
                      

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n    </nav>\r\n    <br>\r\n    <div class=\"container\">\r\n        <label for=\"nombreuS\"  style=\"color: white; font-size: 1.5rem;\">Nombre del jugador: ");
#nullable restore
#line 114 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
                                                                                       Write(ViewBag.nombreUsuario);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <label for=\"timert\" style=\"color: white; font-size: 1.5rem; margin-left:30rem;\">Tiempo restante:</label>\r\n        <label for=\"timer\" class=\"ml-3\" id=\"timer\" style=\"color: white; font-size: 1.5rem;\">15:00</label>\r\n    </div>\r\n");
#nullable restore
#line 118 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
    }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container-fluid body-content\">\r\n            <main role=\"main\" class=\"pb-3\">\r\n                ");
#nullable restore
#line 122 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>
        </div>

        <div class=""modal fade"" id=""defeat-msg"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content modal-st"">
                <div class=""modal-header modal-st-ctn"">
                    <h5 class=""modal-title"">Se te acabo el tiempo!</h5>
                </div>  
                <div class=""modal-body white"">
                    <span id=""decoded-msg"">
                        Al parecer no pudiste superar la prueba en el tiempo propuesto...
                    </span>
                    <span id=""encoded-msg""></span>
                </div>
                <div class=""modal-footer modal-st-noctn"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e24302", async() => {
                    WriteLiteral("\r\n                        <input type=\"submit\" value=\"Reiniciar\" class=\"btn btn-black\">\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <!--Footer-->
    <div class=""container-fluid"" style=""padding: 0px;"">
      
        <footer class=""text-center text-white"">
          <!-- Grid container -->
          <div class=""text-center p-3"" style=""background-color: #23272a;"">
          <div class=""container p-4 pb-0"">
            <!-- Section: Social media -->
            <section class=""mb-0"">
              <div class=""social-buttons"">
                <a href=""https://www.facebook.com/"" target=""blank_"" class=""social-buttons__button social-button social-button--facebook"">
                <span class=""social-button__inner"">
                <svg aria-hidden=""true"" focusable=""false"" data-prefix=""fab"" data-icon=""facebook-f"" class=""svg-inline--fa fa-facebook-f fa-w-10"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 320 512""><path fill=""currentColor"" d=""M279.14 288l14.22-92.66h-88.91v-60.13c0-25.35 12.42-50.06 52.24-50.06h40.42V6.26S260.43 0 225.36 0c-73.");
                WriteLiteral(@"22 0-121.08 44.38-121.08 124.72v70.62H22.89V288h81.39v224h100.17V288z""></path></svg>
                </span>
                </a>
                <a href=""https://twitter.com/home"" target=""blank_"" class=""social-buttons__button social-button social-button--twitter"">
                <span class=""social-button__inner"">
                <svg aria-hidden=""true"" focusable=""false"" data-prefix=""fab"" data-icon=""twitter"" class=""svg-inline--fa fa-twitter fa-w-16"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512""><path fill=""currentColor"" d=""M459.37 151.716c.325 4.548.325 9.097.325 13.645 0 138.72-105.583 298.558-298.558 298.558-59.452 0-114.68-17.219-161.137-47.106 8.447.974 16.568 1.299 25.34 1.299 49.055 0 94.213-16.568 130.274-44.832-46.132-.975-84.792-31.188-98.112-72.772 6.498.974 12.995 1.624 19.818 1.624 9.421 0 18.843-1.3 27.614-3.573-48.081-9.747-84.143-51.98-84.143-102.985v-1.299c13.969 7.797 30.214 12.67 47.431 13.319-28.264-18.843-46.781-51.005-46.781-87.391 0-19.492 5.197-37.36 14.294-");
                WriteLiteral(@"52.954 51.655 63.675 129.3 105.258 216.365 109.807-1.624-7.797-2.599-15.918-2.599-24.04 0-57.828 46.782-104.934 104.934-104.934 30.213 0 57.502 12.67 76.67 33.137 23.715-4.548 46.456-13.32 66.599-25.34-7.798 24.366-24.366 44.833-46.132 57.827 21.117-2.273 41.584-8.122 60.426-16.243-14.292 20.791-32.161 39.308-52.628 54.253z""></path></svg>
                </span>
                </a>
                <a href=""https://www.instagram.com/"" target=""blank_"" class=""social-buttons__button social-button social-button--instagram"">
                <span class=""social-button__inner"">
                <svg aria-hidden=""true"" focusable=""false"" data-prefix=""fab"" data-icon=""instagram"" class=""svg-inline--fa fa-instagram fa-w-14"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 448 512""><path fill=""currentColor"" d=""M224.1 141c-63.6 0-114.9 51.3-114.9 114.9s51.3 114.9 114.9 114.9S339 319.5 339 255.9 287.7 141 224.1 141zm0 189.6c-41.1 0-74.7-33.5-74.7-74.7s33.5-74.7 74.7-74.7 74.7 33.5 74.7 74.7-33.6 74.7-74.7 74.7z");
                WriteLiteral(@"m146.4-194.3c0 14.9-12 26.8-26.8 26.8-14.9 0-26.8-12-26.8-26.8s12-26.8 26.8-26.8 26.8 12 26.8 26.8zm76.1 27.2c-1.7-35.9-9.9-67.7-36.2-93.9-26.2-26.2-58-34.4-93.9-36.2-37-2.1-147.9-2.1-184.9 0-35.8 1.7-67.6 9.9-93.9 36.1s-34.4 58-36.2 93.9c-2.1 37-2.1 147.9 0 184.9 1.7 35.9 9.9 67.7 36.2 93.9s58 34.4 93.9 36.2c37 2.1 147.9 2.1 184.9 0 35.9-1.7 67.7-9.9 93.9-36.2 26.2-26.2 34.4-58 36.2-93.9 2.1-37 2.1-147.8 0-184.8zM398.8 388c-7.8 19.6-22.9 34.7-42.6 42.6-29.5 11.7-99.5 9-132.1 9s-102.7 2.6-132.1-9c-19.6-7.8-34.7-22.9-42.6-42.6-11.7-29.5-9-99.5-9-132.1s-2.6-102.7 9-132.1c7.8-19.6 22.9-34.7 42.6-42.6 29.5-11.7 99.5-9 132.1-9s102.7-2.6 132.1 9c19.6 7.8 34.7 22.9 42.6 42.6 11.7 29.5 9 99.5 9 132.1s2.7 102.7-9 132.1z""></path></svg>
                </span>
                </a>
                <a href=""https://www.youtube.com/"" target=""blank_"" class=""social-buttons__button social-button social-button--youtube"">
                <span class=""social-button__inner"">
                <svg aria-hidden=""true"" focusable=");
                WriteLiteral(@"""false"" data-prefix=""fab"" data-icon=""youtube"" class=""svg-inline--fa fa-youtube fa-w-18"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 576 512""><path fill=""currentColor"" d=""M549.655 124.083c-6.281-23.65-24.787-42.276-48.284-48.597C458.781 64 288 64 288 64S117.22 64 74.629 75.486c-23.497 6.322-42.003 24.947-48.284 48.597-11.412 42.867-11.412 132.305-11.412 132.305s0 89.438 11.412 132.305c6.281 23.65 24.787 41.5 48.284 47.821C117.22 448 288 448 288 448s170.78 0 213.371-11.486c23.497-6.321 42.003-24.171 48.284-47.821 11.412-42.867 11.412-132.305 11.412-132.305s0-89.438-11.412-132.305zm-317.51 213.508V175.185l142.739 81.205-142.739 81.201z""></path></svg>
                </span>
                </a>
              </div>
            </section>
          </div>
            ????? 2021 Copyright: Santiago Sielecki, Antonella Savelski, Ilan Raijel
          </div>
        </footer>
        
    </div>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e31306", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e32410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a79fb6bbeb7eec33db7199463b6ba0df39e27e33514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 187 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 188 "F:\AHYA\ORT\Prg\TP7 Raijel-Savelski-Sielecki\Views\Shared\_Layout.cshtml"
   Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <script>$(\"#terminal\").modal()</script>\r\n        <script type=\"text/javascript\">\r\n        window.onload = () => { startTimer(\'15:00\') };\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
