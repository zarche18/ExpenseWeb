#pragma checksum "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c74180cd33d922702031505871885a9a50801f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expenses_Details), @"mvc.1.0.view", @"/Views/Expenses/Details.cshtml")]
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
#line 1 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\_ViewImports.cshtml"
using Expenses.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\_ViewImports.cshtml"
using Expenses.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c74180cd33d922702031505871885a9a50801f", @"/Views/Expenses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f0780f2d3903a2a250a871e2eb1d43c56d8faa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Expenses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expenses.Model.ExpenseModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Details</h2> \r\n<div>\r\n    <h4>Expense</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 8 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 11 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MoneySpent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.MoneySpent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 31 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
Write(Html.ActionLink("Edit","Edit",new  { id= Model.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 32 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Details.cshtml"
Write(Html.ActionLink("Back To List","Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expenses.Model.ExpenseModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
