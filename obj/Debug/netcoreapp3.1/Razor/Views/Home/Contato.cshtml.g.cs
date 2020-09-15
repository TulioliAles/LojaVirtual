#pragma checksum "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14cda92f0ed6d61a7efc8f6b8e118b20e0afd226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14cda92f0ed6d61a7efc8f6b8e118b20e0afd226", @"/Views/Home/Contato.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-sm-6"">

                <h4 class=");
            WriteLiteral("\"subtitle-doc\">\r\n                    # Contato\r\n                </h4>\r\n                <div>\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n");
#nullable restore
#line 40 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-success\">");
#nullable restore
#line 42 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-danger\">");
#nullable restore
#line 47 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\work\aspnet\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <form role=""form"" method=""post"" action=""ContatoAction"">
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""nome"" id=""nome""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2299, "\"", 2313, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", "\r\n                                               required=\"", 2314, "\"", 2373, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""email"" id=""email""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3036, "\"", 3050, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%""></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div> <!-- row.// -->
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            </form>
                        </div> <!-- ca");
            WriteLiteral("rd-body.// -->\r\n                    </article> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
