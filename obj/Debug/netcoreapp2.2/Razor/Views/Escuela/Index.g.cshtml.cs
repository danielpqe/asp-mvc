#pragma checksum "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a203a5e2628925a9f6fb89ab65512b20765dd6ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "/home/dan/develop/asp-mvc/Views/_ViewImports.cshtml"
using asp_mvc;

#line default
#line hidden
#line 2 "/home/dan/develop/asp-mvc/Views/_ViewImports.cshtml"
using asp_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a203a5e2628925a9f6fb89ab65512b20765dd6ec", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fe8a822d80bf1d402854d224d42476b6330eb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
  
    ViewData["Title"] = "Información de Escuela";

#line default
#line hidden
            BeginContext(77, 32, true);
            WriteLiteral("\r\n<h1>Escuela</h1>\r\n<h2>Nombre: ");
            EndContext();
            BeginContext(110, 12, false);
#line 8 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(122, 28, true);
            WriteLiteral("</h2>\r\n<h3>Tipo de Escuela: ");
            EndContext();
            BeginContext(151, 17, false);
#line 9 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(168, 36, true);
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Dirección: ");
            EndContext();
            BeginContext(205, 15, false);
#line 11 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(220, 19, true);
            WriteLiteral("</p>\r\n    <p>País: ");
            EndContext();
            BeginContext(240, 10, false);
#line 12 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(250, 21, true);
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
            EndContext();
            BeginContext(272, 12, false);
#line 13 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(284, 58, true);
            WriteLiteral("</p>\r\n</address>  \r\n<p><strong>Año de Fundación: </strong>");
            EndContext();
            BeginContext(343, 19, false);
#line 15 "/home/dan/develop/asp-mvc/Views/Escuela/Index.cshtml"
                                 Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(362, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
