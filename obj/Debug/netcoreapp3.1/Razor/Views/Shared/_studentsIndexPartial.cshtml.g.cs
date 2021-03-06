#pragma checksum "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e84885f5a18bae81fbdd2e13da1662a442d7166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__studentsIndexPartial), @"mvc.1.0.view", @"/Views/Shared/_studentsIndexPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e84885f5a18bae81fbdd2e13da1662a442d7166", @"/Views/Shared/_studentsIndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fea7fbda3b021bb70fdd058f8a6f5944f1c56c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__studentsIndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div id=\"studentsTable\" class=\"col-md-6 col-sm-3\">\n    <h3 class=\"text-primary\">Students List</h3><br>\n");
#nullable restore
#line 5 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
     if(Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover bordered table-sm text-center"">
            <thead class=""table table-primary"">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Department</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 16 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 19 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
                       Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 20 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 21 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
                       Write(Html.DisplayFor(m => item.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 23 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 26 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No Students</p>\n");
#nullable restore
#line 30 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Shared/_studentsIndexPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
