#pragma checksum "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8828b82f61faa780d67ae58cb4dbeae40f0c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
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
#line 1 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\_ViewImports.cshtml"
using Monster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\_ViewImports.cshtml"
using Monster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8828b82f61faa780d67ae58cb4dbeae40f0c26", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5f1d7c004a2c1df0622f95be0bf254effde7ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.Pokemon.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml"
  
  ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pokemon</h1>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml"
   foreach (var item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-xs-6 col-sm-4 col-md-3"">
      <div class=""pokecard card p-0 mt-3"" style=""box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19); cursor: pointer"">
        <div class=""card-header bg-info text-white text-center""
             style=""padding: 5px 0;"">
          <strong>");
#nullable restore
#line 15 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml"
             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </div>\r\n        <div class=\"card-body text-center p-0\">\r\n          <img");
            BeginWriteAttribute("src", " src=\"", 584, "\"", 601, 1);
#nullable restore
#line 18 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 590, item.Thumb, 590, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 150px; height: 150px;\" />\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Probe\Documents\Development\Projects\Monster\Monster\Views\Pokemon\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.Pokemon.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
