#pragma checksum "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f965a768f00b66e3bb9588e334135b5f3498cc87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Curso), @"mvc.1.0.view", @"/Views/Home/Curso.cshtml")]
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
#line 1 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f965a768f00b66e3bb9588e334135b5f3498cc87", @"/Views/Home/Curso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Curso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela.Models.ViewModels.Tbl_CourseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
  
    ViewData["Title"] = "Curso";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />
<script src=""https://kit.fontawesome.com/fab0b1407d.js"" crossorigin=""anonymous""></script>
<style type=""text/css"">
    .div {
        border: 1px solid gray;
        border-radius: 14px;
    }
</style>



<div class=""container-fluid div"" style=""width:max-content; padding-bottom:1em;"">
");
#nullable restore
#line 18 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
     using (Html.BeginForm("Curso", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Curso</h1>\r\n");
            WriteLiteral("        <div class=\"div\" style=\"float:initial;\"></div><br />\r\n");
#nullable restore
#line 24 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
   Write(Html.LabelFor(t => t.title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        <i class=\"fas fa-users\"></i> ");
#nullable restore
#line 25 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
                                Write(Html.TextBoxFor(t => t.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 26 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
   Write(Html.ValidationMessageFor(t => t.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 28 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
   Write(Html.LabelFor(c => c.credits));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("        <i class=\"wow animate__animated animate__bounce fa fa-coins fa-3x\" data-wow-offset=\"10\" data-wow-iteration=\"10\" data-wow-duration=\"2s\"></i> ");
#nullable restore
#line 30 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
                                                                                                                                               Write(Html.TextBoxFor(c => c.credits, new { type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 31 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"
   Write(Html.ValidationMessageFor(c => c.credits));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n");
            WriteLiteral("        <button type=\"submit\" class=\"btn-success animate__animated animate__rubberBand\"");
            BeginWriteAttribute("value", " value=\"", 1258, "\"", 1266, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">Enviar</button>\r\n");
#nullable restore
#line 34 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Home\Curso.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


</div>

<script type=""text/javascript"" src=""https://cdn.boomcdn.com/libs/wow-js/1.3.0/wow.js""></script>
<script src=""js/wow.min.js""></script>
<script>
    new WOW().init();
</script>
<script src=""https://kit.fontawesome.com/8c7710e876.js"" crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela.Models.ViewModels.Tbl_CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
