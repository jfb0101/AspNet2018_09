#pragma checksum "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4389859fd8ccc0f84353111e12a40ddb10e59b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_List), @"mvc.1.0.view", @"/Views/Films/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/List.cshtml", typeof(AspNetCore.Views_Films_List))]
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
#line 1 "C:\Users\Treinar\2018-09\Sakila\Views\_ViewImports.cshtml"
using Sakila;

#line default
#line hidden
#line 2 "C:\Users\Treinar\2018-09\Sakila\Views\_ViewImports.cshtml"
using Sakila.Models;

#line default
#line hidden
#line 2 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4389859fd8ccc0f84353111e12a40ddb10e59b5", @"/Views/Films/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454714200a5356a788c1d7220ef9f802b990cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sakila.DB.Model.Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(126, 15, true);
            WriteLiteral("\r\n<h2>\r\n    Hi ");
            EndContext();
            BeginContext(142, 62, false);
#line 6 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
  Write(HttpContextAccessor.HttpContext.Session.GetString("FirstName"));

#line default
#line hidden
            EndContext();
            BeginContext(204, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(206, 61, false);
#line 6 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                                                                  Write(HttpContextAccessor.HttpContext.Session.GetString("LastName"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 15, true);
            WriteLiteral("\r\n</h2>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(282, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93bdc140c4e7440d93ec0eb02818b990", async() => {
                BeginContext(360, 16, true);
                WriteLiteral("\r\n    New film\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(380, 346, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-6"">
        <table id=""tblFilms"" class=""table"" >
            <thead>
                <tr >
                    <th>ID</th>
                    <th>Title</th>
                    <th>Language</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 27 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                 foreach(var film in Model) {

#line default
#line hidden
            BeginContext(773, 23, true);
            WriteLiteral("                    <tr");
            EndContext();
            BeginWriteAttribute("film-id", " film-id=\"", 796, "\"", 814, 1);
#line 28 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
WriteAttributeValue("", 806, film.Id, 806, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 63, true);
            WriteLiteral(" >\r\n                        <td> \r\n                            ");
            EndContext();
            BeginContext(879, 7, false);
#line 30 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                       Write(film.Id);

#line default
#line hidden
            EndContext();
            BeginContext(886, 92, true);
            WriteLiteral(" \r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(979, 10, false);
#line 33 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                       Write(film.Title);

#line default
#line hidden
            EndContext();
            BeginContext(989, 87, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                        ");
            EndContext();
            BeginContext(1078, 47, false);
#line 36 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                    Write(film.Language != null ? film.Language.Name : "");

#line default
#line hidden
            EndContext();
            BeginContext(1126, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1217, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d91eb24ca714c69929376d66e726c37", async() => {
                BeginContext(1295, 91, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                                                                                    WriteLiteral(film.Id);

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
            BeginContext(1390, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1420, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d10e58cf824bcb978b8991a6f33208", async() => {
                BeginContext(1490, 96, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-trash-alt\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                                                                            WriteLiteral(film.Id);

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
            BeginContext(1590, 62, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Treinar\2018-09\Sakila\Views\Films\List.cshtml"
                }

#line default
#line hidden
            BeginContext(1671, 805, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div clas=""col-md-6"">
        <div id=""filmDetails"" data-spy=""affix"" >

        </div>
    </div>
</div>

<script>
    $(document).ready(() => {
        $(""#tblFilms tr"").click(e => {
            var clickedRow = $(e.target).closest(""tr"")
            var filmId = clickedRow.attr(""film-id"")
            
            $(""#filmDetails"").load(""/Films/GetFilmDetails?filmId="" + filmId)
            $(""#filmDetails"").affix();
        })
        $(""#tblFilms tr"").hover(() => {
            $(this).addClass(""hover"")
        },() => {
            $(this).removeClass(""hover"")
        })

        
    })
</script>

<style>
    #tblFilms tr:hover {
        cursor: pointer;
        background-color: aliceblue;
    }
</style>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sakila.DB.Model.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
