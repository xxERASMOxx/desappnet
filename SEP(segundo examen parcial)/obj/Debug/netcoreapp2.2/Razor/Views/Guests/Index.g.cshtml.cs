#pragma checksum "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be5c845e0062754f2f480aea7b871cd7abc8bd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guests_Index), @"mvc.1.0.view", @"/Views/Guests/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Guests/Index.cshtml", typeof(AspNetCore.Views_Guests_Index))]
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
#line 1 "C:\proyectos\SEP(segundo examen parcial)\Views\_ViewImports.cshtml"
using ExamenParcial2;

#line default
#line hidden
#line 2 "C:\proyectos\SEP(segundo examen parcial)\Views\_ViewImports.cshtml"
using ExamenParcial2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be5c845e0062754f2f480aea7b871cd7abc8bd7", @"/Views/Guests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b1a04a1cfc506777f3ebba83a61dfe0dc29209", @"/Views/_ViewImports.cshtml")]
    public class Views_Guests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamenParcial2.Models.Guests>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(113, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be5c845e0062754f2f480aea7b871cd7abc8bd74658", async() => {
                BeginContext(136, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(150, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(237, 45, false);
#line 16 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestTile));

#line default
#line hidden
            EndContext();
            BeginContext(282, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(335, 50, false);
#line 19 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(385, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(438, 49, false);
#line 22 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(487, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(540, 45, false);
#line 25 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestsDOB));

#line default
#line hidden
            EndContext();
            BeginContext(585, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(638, 54, false);
#line 28 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(692, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(745, 52, false);
#line 31 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(797, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(850, 56, false);
#line 34 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(906, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(959, 58, false);
#line 37 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1070, 53, false);
#line 40 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 46 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1234, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1281, 44, false);
#line 49 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestTile));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1378, 49, false);
#line 52 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1480, 48, false);
#line 55 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1581, 44, false);
#line 58 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestsDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1678, 53, false);
#line 61 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1784, 51, false);
#line 64 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1888, 55, false);
#line 67 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1943, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1996, 57, false);
#line 70 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2106, 52, false);
#line 73 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2210, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be5c845e0062754f2f480aea7b871cd7abc8bd713789", async() => {
                BeginContext(2260, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
                                       WriteLiteral(item.GuestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2268, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2287, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be5c845e0062754f2f480aea7b871cd7abc8bd716125", async() => {
                BeginContext(2340, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
                                          WriteLiteral(item.GuestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2351, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2370, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be5c845e0062754f2f480aea7b871cd7abc8bd718467", async() => {
                BeginContext(2422, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
                                         WriteLiteral(item.GuestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2432, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 81 "C:\proyectos\SEP(segundo examen parcial)\Views\Guests\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2467, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamenParcial2.Models.Guests>> Html { get; private set; }
    }
}
#pragma warning restore 1591
