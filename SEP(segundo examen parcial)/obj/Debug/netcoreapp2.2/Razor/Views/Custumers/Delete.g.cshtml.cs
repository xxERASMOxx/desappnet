#pragma checksum "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232694c03e341c2c3c971af90bae10aa7e85dafd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custumers_Delete), @"mvc.1.0.view", @"/Views/Custumers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Custumers/Delete.cshtml", typeof(AspNetCore.Views_Custumers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232694c03e341c2c3c971af90bae10aa7e85dafd", @"/Views/Custumers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b1a04a1cfc506777f3ebba83a61dfe0dc29209", @"/Views/_ViewImports.cshtml")]
    public class Views_Custumers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamenParcial2.Models.Custumers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 170, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Custumers</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(250, 48, false);
#line 15 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(298, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(359, 44, false);
#line 18 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(403, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(463, 53, false);
#line 21 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(516, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(577, 49, false);
#line 24 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(626, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(686, 52, false);
#line 27 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(738, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(799, 48, false);
#line 30 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(847, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(907, 47, false);
#line 33 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(954, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1015, 43, false);
#line 36 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1118, 57, false);
#line 39 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1236, 53, false);
#line 42 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1349, 55, false);
#line 45 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1465, 51, false);
#line 48 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1576, 59, false);
#line 51 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1696, 55, false);
#line 54 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1811, 61, false);
#line 57 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1933, 57, false);
#line 60 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2050, 56, false);
#line 63 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2167, 52, false);
#line 66 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2279, 53, false);
#line 69 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2393, 49, false);
#line 72 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2502, 57, false);
#line 75 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2620, 53, false);
#line 78 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2673, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2733, 55, false);
#line 81 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2788, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2849, 51, false);
#line 84 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2900, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(2934, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232694c03e341c2c3c971af90bae10aa7e85dafd14981", async() => {
                BeginContext(2960, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(2969, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "232694c03e341c2c3c971af90bae10aa7e85dafd15371", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\proyectos\SEP(segundo examen parcial)\Views\Custumers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3013, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(3094, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232694c03e341c2c3c971af90bae10aa7e85dafd17272", async() => {
                    BeginContext(3116, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3132, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3144, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamenParcial2.Models.Custumers> Html { get; private set; }
    }
}
#pragma warning restore 1591
