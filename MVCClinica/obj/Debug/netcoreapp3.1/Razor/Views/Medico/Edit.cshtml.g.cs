#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc78316d3cd69b329f4c26676c410dbb15856cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Edit), @"mvc.1.0.view", @"/Views/Medico/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc78316d3cd69b329f4c26676c410dbb15856cb1", @"/Views/Medico/Edit.cshtml")]
    #nullable restore
    public class Views_Medico_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCClinica.Models.Medico>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
  
    ViewData["Title"] = "Edit Medico";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Editar médico</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
     using (Html.BeginForm("Edit", "Medico", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n            ");
#nullable restore
#line 12 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.LabelFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
            WriteLiteral("            <p>\r\n            ");
#nullable restore
#line 18 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.LabelFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
            WriteLiteral("            <p>\r\n            ");
#nullable restore
#line 24 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.LabelFor(model => model.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
            WriteLiteral("            <input type=\"submit\" action=\"Edit\" />\r\n");
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
   Write(Html.ActionLink("Volver a ver médicos", "Index", "Medico"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\tp grupal 27-1\SLNClinica\MVCClinica\Views\Medico\Edit.cshtml"
                                                                   

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCClinica.Models.Medico> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
