#pragma checksum "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67dd970e2989d5d892453515914480e252c253ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ChiTietLichSu), @"mvc.1.0.view", @"/Views/Cart/ChiTietLichSu.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\_ViewImports.cshtml"
using ASM_PS18412;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\_ViewImports.cshtml"
using ASM_PS18412.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67dd970e2989d5d892453515914480e252c253ee", @"/Views/Cart/ChiTietLichSu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d058c016b45918ecf6f6da9975696a4ac32ebcec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_ChiTietLichSu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASM_PS18412.Models.CartDetails>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutSanPham.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chi Tiết Giỏ Hàng</h1>

<table class=""table"">
  <thead>
        <tr>
            <th>
             TÊN MÓN
            </th>
            <th>
               SỐ LƯỢNG
            </th>
            <th>
               HÌNH ẢNH
            </th>
            <th>
               GIÁ
            </th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 30 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodMount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67dd970e2989d5d892453515914480e252c253ee5936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 889, "~/TaiLieu/", 889, 10, true);
#nullable restore
#line 40 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
AddHtmlAttributeValue("", 899, item.FoodImage, 899, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Documents\QLBH\New folder\ASM_PS18412 - Copy\ASM_PS18412\Views\Cart\ChiTietLichSu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASM_PS18412.Models.CartDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
