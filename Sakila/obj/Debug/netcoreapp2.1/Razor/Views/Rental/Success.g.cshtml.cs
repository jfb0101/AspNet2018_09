#pragma checksum "C:\Users\Treinar\2018-09\Sakila\Views\Rental\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd2305c551e134db354d68e133b9241798fe71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rental_Success), @"mvc.1.0.view", @"/Views/Rental/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rental/Success.cshtml", typeof(AspNetCore.Views_Rental_Success))]
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
#line 1 "C:\Users\Treinar\2018-09\Sakila\Views\Rental\Success.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd2305c551e134db354d68e133b9241798fe71b", @"/Views/Rental/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454714200a5356a788c1d7220ef9f802b990cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Rental_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 9, true);
            WriteLiteral("\r\n<h2>\r\n ");
            EndContext();
            BeginContext(94, 62, false);
#line 5 "C:\Users\Treinar\2018-09\Sakila\Views\Rental\Success.cshtml"
Write(HttpContextAccessor.HttpContext.Session.GetString("FirstName"));

#line default
#line hidden
            EndContext();
            BeginContext(156, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(158, 61, false);
#line 5 "C:\Users\Treinar\2018-09\Sakila\Views\Rental\Success.cshtml"
                                                            Write(HttpContextAccessor.HttpContext.Session.GetString("LastName"));

#line default
#line hidden
            EndContext();
            BeginContext(219, 32, true);
            WriteLiteral(", rent made successfully\r\n </h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591