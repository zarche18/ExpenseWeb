#pragma checksum "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e389faccfb077f4b0ec6bdd55fbe9124032294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expenses_Create), @"mvc.1.0.view", @"/Views/Expenses/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e389faccfb077f4b0ec6bdd55fbe9124032294", @"/Views/Expenses/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f0780f2d3903a2a250a871e2eb1d43c56d8faa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Expenses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expenses.Model.ExpenseModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Create</h2>\r\n");
#nullable restore
#line 4 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4> Expense </h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 10 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
   Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 14 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
   Write(Html.LabelFor(model => model.MoneySpent, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 21 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.TextBoxFor(model => model.MoneySpent, new {  @class = "form-control", onkeypress = "return isNumberKey(event)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.MoneySpent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
   Write(Html.LabelFor(model => model.Category, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 28 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Category, new { @class = "form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Category, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-2\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 38 "D:\ZARCHI_WORKING\Expenses\Expenses.Web\Views\Expenses\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57)) {
            window.alert('Please input the number!');
            return false;
        }
        return true;
    }
</script>");
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
