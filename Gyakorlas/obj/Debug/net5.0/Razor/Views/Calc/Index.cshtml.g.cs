#pragma checksum "C:\Codecool\Gyakorlas\Gyakorlas\Views\Calc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d022fd3ac4ed1622f52a016c7819a6b18bde222c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_Index), @"mvc.1.0.view", @"/Views/Calc/Index.cshtml")]
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
#line 1 "C:\Codecool\Gyakorlas\Gyakorlas\Views\_ViewImports.cshtml"
using Gyakorlas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Codecool\Gyakorlas\Gyakorlas\Views\_ViewImports.cshtml"
using Gyakorlas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d022fd3ac4ed1622f52a016c7819a6b18bde222c", @"/Views/Calc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbfce5d659bd2bc3181d31d09e4e7efd64542fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalcModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Codecool\Gyakorlas\Gyakorlas\Views\Calc\Index.cshtml"
 using (Html.BeginForm("Sum", "Calc", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Enter a number!</span> ");
#nullable restore
#line 9 "C:\Codecool\Gyakorlas\Gyakorlas\Views\Calc\Index.cshtml"
                            Write(Html.TextBoxFor(m => m.A));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <span>Enter a number!</span> ");
#nullable restore
#line 11 "C:\Codecool\Gyakorlas\Gyakorlas\Views\Calc\Index.cshtml"
                            Write(Html.TextBoxFor(m => m.B));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" name=\"sbmt\" value=\"submit\" />\r\n");
#nullable restore
#line 13 "C:\Codecool\Gyakorlas\Gyakorlas\Views\Calc\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalcModel> Html { get; private set; }
    }
}
#pragma warning restore 1591