#pragma checksum "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40c7ba82761d005c89ab1454fab8d1ae7405705a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custumers_Index), @"mvc.1.0.view", @"/Views/Custumers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Custumers/Index.cshtml", typeof(AspNetCore.Views_Custumers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c7ba82761d005c89ab1454fab8d1ae7405705a", @"/Views/Custumers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b1a04a1cfc506777f3ebba83a61dfe0dc29209", @"/Views/_ViewImports.cshtml")]
    public class Views_Custumers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamenParcial2.Models.Custumers>>
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
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(116, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c7ba82761d005c89ab1454fab8d1ae7405705a4685", async() => {
                BeginContext(139, 10, true);
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
            BeginContext(153, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(240, 48, false);
#line 16 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(288, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(341, 53, false);
#line 19 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(394, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(447, 52, false);
#line 22 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(499, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(552, 47, false);
#line 25 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(599, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(652, 57, false);
#line 28 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(709, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(762, 55, false);
#line 31 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(817, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(870, 59, false);
#line 34 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(929, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(982, 61, false);
#line 37 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1096, 56, false);
#line 40 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1205, 53, false);
#line 43 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1311, 57, false);
#line 46 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1421, 55, false);
#line 49 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 55 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1587, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1634, 47, false);
#line 58 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1734, 52, false);
#line 61 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1839, 51, false);
#line 64 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1943, 46, false);
#line 67 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1989, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2042, 56, false);
#line 70 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(2098, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2151, 54, false);
#line 73 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2258, 58, false);
#line 76 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2369, 60, false);
#line 79 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2482, 55, false);
#line 82 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2537, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2590, 52, false);
#line 85 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2695, 56, false);
#line 88 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2804, 54, false);
#line 91 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2858, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2910, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c7ba82761d005c89ab1454fab8d1ae7405705a16418", async() => {
                BeginContext(2963, 4, true);
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
#line 94 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
                                       WriteLiteral(item.CustomerId);

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
            BeginContext(2971, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2990, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c7ba82761d005c89ab1454fab8d1ae7405705a18760", async() => {
                BeginContext(3046, 7, true);
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
#line 95 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
                                          WriteLiteral(item.CustomerId);

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
            BeginContext(3057, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(3076, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c7ba82761d005c89ab1454fab8d1ae7405705a21108", async() => {
                BeginContext(3131, 6, true);
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
#line 96 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
                                         WriteLiteral(item.CustomerId);

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
            BeginContext(3141, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 99 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3176, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamenParcial2.Models.Custumers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
