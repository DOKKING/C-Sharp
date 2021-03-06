#pragma checksum "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d01c973ea95233d2f9dd2c57d2c798f547e0a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarsInTable), @"mvc.1.0.view", @"/Views/Home/CarsInTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarsInTable.cshtml", typeof(AspNetCore.Views_Home_CarsInTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d01c973ea95233d2f9dd2c57d2c798f547e0a4d", @"/Views/Home/CarsInTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c68ae364c423381da5b9eb05d9b2c88f13b9ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarsInTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 306, true);
            WriteLiteral(@"<h1>Таблица всех доступных автомобилей</h1>

<table class=""table table-hover"">
    <tr>
        <td>№ п.п.</td>
        <td>Название</td>
        <td>Краткое описание</td>
        <td>Полное описание</td>
        <td>Фото</td>
        <td>Редактрование</td>
        <td>Удаление</td>
    </tr>
");
            EndContext();
#line 13 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
      
        int i = 1;
        foreach (var car in Model)
        {

#line default
#line hidden
            BeginContext(381, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(420, 13, false);
#line 18 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
               Write(Html.Raw(i++));

#line default
#line hidden
            EndContext();
            BeginContext(433, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(461, 8, false);
#line 19 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
               Write(car.name);

#line default
#line hidden
            EndContext();
            BeginContext(469, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(497, 13, false);
#line 20 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
               Write(car.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(510, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(538, 12, false);
#line 21 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
               Write(car.longDesc);

#line default
#line hidden
            EndContext();
            BeginContext(550, 42, true);
            WriteLiteral("</td>\r\n                <td><img width=\"50\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 592, "\"", 606, 1);
#line 22 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
WriteAttributeValue("", 598, car.img, 598, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 61, true);
            WriteLiteral(" /></td>\r\n                <td><button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 668, "\"", 747, 5);
            WriteAttributeValue("", 678, "location.href", 678, 13, true);
            WriteAttributeValue(" ", 691, "=", 692, 2, true);
            WriteAttributeValue(" ", 693, "\'", 694, 2, true);
#line 23 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
WriteAttributeValue("", 695, Url.Action("EditCar", "Cars", new { _id = car.id}), 695, 51, false);

#line default
#line hidden
            WriteAttributeValue("", 746, "\'", 746, 1, true);
            EndWriteAttribute();
            BeginContext(748, 30, true);
            WriteLiteral(">Редактировать</button></td>\r\n");
            EndContext();
            BeginContext(938, 77, true);
            WriteLiteral("                <td><button class=\"btn btn-danger\">\r\n                        ");
            EndContext();
            BeginContext(1016, 259, false);
#line 26 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"
                   Write(Html.ActionLink(
                            "Удалить", "DeleteCar", "Cars",
                            new { _id = car.id}, new { onclick = "return confirm('Удалить объект?')",
                            @class = "button"}
                            ));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 57, true);
            WriteLiteral("\r\n                    </button></td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\User\Desktop\Новая папка\Magazine_2021\Magazine_2021\Views\Home\CarsInTable.cshtml"

        }
    

#line default
#line hidden
            BeginContext(1352, 10, true);
            WriteLiteral("</table>\r\n");
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
