#pragma checksum "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a8f11f7ff98b37ec52fb0cefa1cf45d6540a71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
#line 1 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#line 2 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a8f11f7ff98b37ec52fb0cefa1cf45d6540a71d", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af391b36d1a8c1f3333b24496fb6aafa3a82354", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 25, true);
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
            EndContext();
            BeginContext(55, 13, false);
#line 3 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(68, 25, true);
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
   foreach (var p in Model)
  {

#line default
#line hidden
            BeginContext(127, 85, true);
            WriteLiteral("    <div class=\"col-md-3\">\r\n      <div class=\"border bg-light rounded p-1\">\r\n        ");
            EndContext();
            BeginContext(212, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4e3b9b2e1a2426abca05abb948917fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 222, "~/img/", 222, 6, true);
#line 9 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 228, p.ArtId, 228, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 238, ".jpg", 238, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 267, p.Title, 267, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(279, 14, true);
            WriteLiteral("\r\n        <h3>");
            EndContext();
            BeginContext(294, 10, false);
#line 10 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
       Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(304, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(308, 6, false);
#line 10 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                     Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("</h3>\r\n        <ul>\r\n          <li>Price: $");
            EndContext();
            BeginContext(358, 7, false);
#line 12 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                 Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(365, 29, true);
            WriteLiteral("</li>\r\n          <li>Artist: ");
            EndContext();
            BeginContext(395, 8, false);
#line 13 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                 Write(p.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(403, 28, true);
            WriteLiteral("</li>\r\n          <li>Title: ");
            EndContext();
            BeginContext(432, 7, false);
#line 14 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(439, 34, true);
            WriteLiteral("</li>\r\n          <li>Description: ");
            EndContext();
            BeginContext(474, 16, false);
#line 15 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                      Write(p.ArtDescription);

#line default
#line hidden
            EndContext();
            BeginContext(490, 121, true);
            WriteLiteral("</li>\r\n        </ul>\r\n        <button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\r\n      </div>    \r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\jonat\Documents\Dropbox\IT\DutchTreat\07\demos\after\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
  }

#line default
#line hidden
            BeginContext(616, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
