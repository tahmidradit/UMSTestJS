#pragma checksum "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffb0829c88dead79a4751a31471fdd761cfc5b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/_ViewImports.cshtml"
using UMSTestJS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/_ViewImports.cshtml"
using UMSTestJS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ffb0829c88dead79a4751a31471fdd761cfc5b3", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fea7fbda3b021bb70fdd058f8a6f5944f1c56c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMSTestJS.Models.ViewModels.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
  
    ViewData["Title"] = "Index - Department"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12"">
    <div class=""row"">
        <div class=""col-4"">
            <h2 class=""text-primary"">Departments List</h2>
        </div>
        <div align=""right"" class=""col-8 "">
            <a class=""btn btn-primary text-white form control""><i class=""fas fa-plus""></i> Department</a>
        </div>
    </div>
    <br>

");
#nullable restore
#line 18 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
     if(Model.Departments.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""tbl"" class=""table table-hover bordered table-sm text-center"">
            <thead class=""table table-primary"">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
                 foreach (var item in Model.Departments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                    <td>");
#nullable restore
#line 31 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
                   Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 34 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 37 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No Departments</p>\n");
#nullable restore
#line 41 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Department/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UMSTestJS.Models.ViewModels.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591