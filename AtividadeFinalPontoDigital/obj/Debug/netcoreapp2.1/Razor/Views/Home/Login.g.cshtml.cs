#pragma checksum "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b9acb4735cce704e3fc1e2c33ada89cee78708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b9acb4735cce704e3fc1e2c33ada89cee78708", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 210, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n");
            EndContext();
            BeginContext(210, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c1c815a60714963a4aa7c91fbdd63bb", async() => {
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
            BeginContext(272, 12, true);
            WriteLiteral("\r\n<header>\r\n");
            EndContext();
#line 4 "C:\Users\45579480814\Desktop\PontoDigital-master\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Home\Login.cshtml"
      
        Html.RenderPartial("_HeadNavBar");
    

#line default
#line hidden
            BeginContext(343, 1473, true);
            WriteLiteral(@"<style type=""text/css"">
/* div para obrigar o OK na caixa */
.div{
position:absolute;
top:0;
left:0;
z-index:1;
background-color:#ffffff;
filter:Alpha(Opacity=0,FinishOpacity=0,Style=2,StartX=100,StartY=100,FinishX=100,FinishY=1);
-moz-opacity:0.0;opacity:0.0;
width:100%;
height:100%;
display:none;
}
 
/* esse é o div da caixa de alerta */
.div2 {
position:absolute;
top:45%;
left:45%;
z-index:2;
display:none;
}
 
/* esse é o div onde vai aparecer o conteúdo */
.conteudo {
background-color:#f9f9f9;
width:100px;
height:100px;
font-family:arial;
font-size:8pt;
color:#696969;
padding: 5px 5px 5px 5px;
border:1px solid #cccccc;
}
</style>
<script>
function verifica() {
var ident = document.form;
 
/* verificando campo nome, se vazio */
if(ident.email.value=="""") {
document.getElementById(""div"").style.display=""block"";
document.getElementById(""div2"").style.display=""block"";
document.getElementById(""alerta"").innerHTML=""Coloque o nome"";
return false;
}
 
/* verificando cam");
            WriteLiteral(@"po e-mail, se vazio */
if(ident.senha.value=="""") {
document.getElementById(""div"").style.display=""block"";
document.getElementById(""div2"").style.display=""block"";
document.getElementById(""alerta"").innerHTML=""Coloque o e-mail"";
return false;
}
 
}
 
/* fecha a caixa de alerta */
function fechar_alerta() {
document.getElementById(""div"").style.display=""none"";
document.getElementById(""div2"").style.display=""none"";
}
</script>
</header>
");
            EndContext();
            BeginContext(1816, 922, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed91aa49bae4233966583c37a892aa9", async() => {
                BeginContext(1822, 909, true);
                WriteLiteral(@"
    <div class=""container"">
   
    <form action=""/Login/Logar"" method=""POST"" enctype=""multipart/form-data"" onsubmit= return verifica();>
     <h2>Fazer login!</h2>
        <div class=""form-group"">
            <label for=""email"">Email</label>
            <input type=""text"" name=""email"" value="""" class=""form-control"">
            <label for=""senha"">Senha</label>
            <input type=""password"" name=""senha"" value=""""class=""form-control"">
            <input type=""submit"" value=""Logar"" class=""btn btn-secondary btn-lg btn-block"">
            <div class=""div"" id=""div""></div>
 
<div class=""div2"" id=""div2"" style=""display:none;"">
<table>
<tr>
<td valign=""center"" align=""center"" class=""conteudo"" id=""alerta""></td>
</td>
</tr>
<tr><td valign=""center"" align=""center""><input type=""button"" value=""OK"" onClick=""fechar_alerta()""></td></tr>
</table>
</div>
        </div>
    </form>
</div>
");
                EndContext();
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
