#pragma checksum "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3735437de6cc10ff7bc2fdd087341e02f7a6bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Carrinho), @"mvc.1.0.view", @"/Views/Carrinho/Carrinho.cshtml")]
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
#line 1 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\_ViewImports.cshtml"
using PIE5_VanessaCampos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\_ViewImports.cshtml"
using PIE5_VanessaCampos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3735437de6cc10ff7bc2fdd087341e02f7a6bf7", @"/Views/Carrinho/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4238c84a6284a757e684cdc569c3e1230358e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Carrinho>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">                    \r\n    \r\n<div class=\"col p-md-5 p-sm-0 justify-content-center\">\r\n    <h1 class=\"text-center my-md-3 my-sm-2\" style=\"color: #f06eaa\"><b>CARRINHO DE ORÇAMENTO</b></h1>    \r\n");
#nullable restore
#line 10 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
     if(Model.Count > 0){      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-flex justify-content-center pt-2"">  
            <div class=""table-responsive-sm col-md-10 col-sm-4"">   
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th class=""col-3"">Nome do Produto</th>
                                <th class=""col-3"">Descrição</th>
                                <th class=""col-2"">Tamanho</th>
                                <th class=""col-1 text-center""></th>
                                <th class=""col-1 text-center"">Und</th>
                                <th class=""col-1 text-center""></th>
                                <th class=""col-1 text-center""></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                         foreach (Carrinho car in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"col-3\">");
#nullable restore
#line 28 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                                             Write(car.ProdutoNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                            \r\n                                <td class=\"col-3\">");
#nullable restore
#line 29 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                                             Write(car.ProdutoDescricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                            \r\n                                <td class=\"col-2\">");
#nullable restore
#line 30 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                                             Write(car.ProdutoTamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                            \r\n                                <td class=\"col-1 text-center\"><a class=\"btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 1649, "\"", 1685, 2);
            WriteAttributeValue("", 1656, "/Carrinho/Diminuir?Id=", 1656, 22, true);
#nullable restore
#line 31 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
WriteAttributeValue("", 1678, car.Id, 1678, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">-</a>\r\n                                <td class=\"col-1 text-center\">");
#nullable restore
#line 32 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                                                         Write(car.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1 text-center\"><a class=\"btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 1910, "\"", 1946, 2);
            WriteAttributeValue("", 1917, "/Carrinho/Aumentar?Id=", 1917, 22, true);
#nullable restore
#line 33 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
WriteAttributeValue("", 1939, car.Id, 1939, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">+</a>\r\n                                <td class=\"col-1 text-center\"><a class=\"btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 2087, "\"", 2122, 2);
            WriteAttributeValue("", 2094, "/Carrinho/Excluir?Id=", 2094, 21, true);
#nullable restore
#line 34 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
WriteAttributeValue("", 2115, car.Id, 2115, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\" \r\n                                    onclick=\"return confirm(\'Deseja remover o item do carrinho?\');\">Remover</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 38 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>    \r\n            </div>\r\n    </div>\r\n");
            WriteLiteral("    <ul class=\"pagination col-12 justify-content-md-center\">\r\n");
#nullable restore
#line 45 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
         for (int i = 1; i <= (int)ViewData["Pages"]; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link btn btn-light text-white mx-1\"");
            BeginWriteAttribute("href", " href=\"", 2684, "\"", 2715, 2);
            WriteAttributeValue("", 2691, "/Carrinho/Carrinho/?p=", 2691, 22, true);
#nullable restore
#line 46 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
WriteAttributeValue("", 2713, i, 2713, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">");
#nullable restore
#line 46 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
                                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 47 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
            WriteLiteral(@"    <div class=""col-12 d-flex justify-content-md-center pt-2 mx-3""> 
        <a class=""btn btn-light text-white mx-1"" style=""background-color: #f06eaa;"" href=""/Carrinho/Orcamento"">Concluir Orçamento</a>
        <a class=""btn btn-light text-white mx-1"" style=""background-color: #f06eaa;"" href=""/Carrinho/Produtos"">Continuar Comprando</a>
    </div>                 
");
#nullable restore
#line 54 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
    }else{    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"pt-4\">Nenhum registro encontrado!</p>\r\n");
#nullable restore
#line 56 "D:\Vanessa Campos\Desktop\PIE5_VanessaCampos-\Views\Carrinho\Carrinho.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>      \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Carrinho>> Html { get; private set; }
    }
}
#pragma warning restore 1591