#pragma checksum "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d527720d49174f0820c19538b43423c71df0c3c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
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
#line 1 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d527720d49174f0820c19538b43423c71df0c3c9", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc97c32dfe48aa425fe0c6abcb3a59c49fa1e282", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все заказы</h1>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
Write(Model.CurrPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\"> ");
#nullable restore
#line 3 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
                              /*отступ сверху и снизу*/ 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
      
        foreach (var product in Model.AllProducts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\r\n");
#nullable restore
#line 8 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
              /*количество колонок занимаемых блоком (из 12)*/ 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>Задача: ");
#nullable restore
#line 9 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
                   Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 367, "\"", 385, 1);
#nullable restore
#line 10 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
WriteAttributeValue("", 373, product.Img, 373, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 386, "\"", 403, 1);
#nullable restore
#line 10 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
WriteAttributeValue("", 392, product.Id, 392, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <p>Цена: ");
#nullable restore
#line 11 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"
                Write(product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p><a class=\"btn btn-warning\" href=\"#\">Подробнее</a></p>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\Acer\OneDrive\Документы\5 семестр\c#\Новая папка (2)\WebApplication1\Views\Products\List.cshtml"

        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
