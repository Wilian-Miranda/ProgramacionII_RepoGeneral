#pragma checksum "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db2893d288d57209a633fa65ffece36f592121c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\_ViewImports.cshtml"
using PracticaPresencialNETCORE2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\_ViewImports.cshtml"
using PracticaPresencialNETCORE2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db2893d288d57209a633fa65ffece36f592121c", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df13ff0280e136539f667937fbf874f5dcd2c47e", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PracticaPresencialNETCORE2.Models.ViewModels.UsuariosViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\" style=\"width:max-content; padding-bottom:1em;margin-top:2em;border:1px solid gray; border-radius:14px; background-color:white;\">\r\n");
#nullable restore
#line 7 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
     using (Html.BeginForm("Index", "Usuarios", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Registro</h2> <br />\r\n");
#nullable restore
#line 11 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.LabelFor(n => n.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 12 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.TextBoxFor(n => n.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 13 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.ValidationMessageFor(n => n.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 15 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.LabelFor(e => e.edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 16 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.TextBoxFor(e => e.edad, new { type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 17 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.ValidationMessageFor(e => e.edad));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 19 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.LabelFor(s => s.sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 20 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.TextBoxFor(s => s.sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 21 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.ValidationMessageFor(s => s.sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 23 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.LabelFor(tp => tp.tipoEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 24 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.TextBoxFor(tp => tp.tipoEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 25 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
   Write(Html.ValidationMessageFor(tp => tp.tipoEstudio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><br />\r\n");
            WriteLiteral("        <input type=\"submit\" name=\"name\" value=\"Enviar\" class=\"btn-success\" style=\"width:100%;\" />\r\n");
#nullable restore
#line 28 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE2\PracticaPresencialNETCORE2\Views\Usuarios\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PracticaPresencialNETCORE2.Models.ViewModels.UsuariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591