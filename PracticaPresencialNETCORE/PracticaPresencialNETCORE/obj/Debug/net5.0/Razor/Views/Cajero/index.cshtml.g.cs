#pragma checksum "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d923801eae0fdfdaa2cdec9bf50196e704b206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cajero_index), @"mvc.1.0.view", @"/Views/Cajero/index.cshtml")]
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
#line 1 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\_ViewImports.cshtml"
using PracticaPresencialNETCORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\_ViewImports.cshtml"
using PracticaPresencialNETCORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d923801eae0fdfdaa2cdec9bf50196e704b206", @"/Views/Cajero/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1f32114fe370d1fa9b06ef9cd364b46c51d4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Cajero_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PracticaPresencialNETCORE.Models.ViewModels.CajeroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
  
    ViewBag.Title = "index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\" style=\"width:max-content; border:1px solid gray;margin-top:2em;padding-bottom:1em;border-radius:14px;background-color:aliceblue;\">\r\n");
#nullable restore
#line 8 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
     using (Html.BeginForm("index", "Cajero", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Cajero</h2> <br />\r\n");
#nullable restore
#line 11 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
   Write(Html.LabelFor(m => m.monto));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 12 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
   Write(Html.TextBoxFor(t => t.monto));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 13 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
   Write(Html.ValidationMessageFor(e => e.monto));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br /><br />\r\n");
            WriteLiteral("        <input type=\"submit\"");
            BeginWriteAttribute("name", " name=\"", 567, "\"", 574, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Enviar\" class=\"btn-success\" />\r\n");
#nullable restore
#line 17 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\PracticaPresencialNETCORE\PracticaPresencialNETCORE\Views\Cajero\index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PracticaPresencialNETCORE.Models.ViewModels.CajeroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591