#pragma checksum "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05460c310baff9f4717e206a34c36338ca65e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_VerComentarios), @"mvc.1.0.view", @"/Views/Login/VerComentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/VerComentarios.cshtml", typeof(AspNetCore.Views_Login_VerComentarios))]
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
#line 1 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
using AtividadeFinalPontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05460c310baff9f4717e206a34c36338ca65e72", @"/Views/Login/VerComentarios.cshtml")]
    public class Views_Login_VerComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 210, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n");
            EndContext();
            BeginContext(253, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc34e0906be8438f9b50264d96f42e3f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(315, 12, true);
            WriteLiteral("\r\n<header>\r\n");
            EndContext();
#line 5 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
      
        Html.RenderPartial("_HeadNavBarLogged");
    

#line default
#line hidden
            BeginContext(392, 168, true);
            WriteLiteral("</header>\r\n<table id=\"myTable\">\r\n  <tr class=\"header\">\r\n    <th style=\"width:5%;\">Nome</th>\r\n    <th style=\"width:5%;\">Comentário</th>\r\n  </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
     foreach (var item in ViewData["comentariosaprovados"] as List<ComentarioModel>)
    {

#line default
#line hidden
            BeginContext(653, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(684, 9, false);
#line 19 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(693, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(717, 15, false);
#line 20 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
           Write(item.Comentario);

#line default
#line hidden
            EndContext();
            BeginContext(732, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 22 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\VerComentarios.cshtml"
    }

#line default
#line hidden
            BeginContext(761, 20, true);
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
