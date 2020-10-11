#pragma checksum "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6b7d1bc40c1ecaace099ecb2cd61e715b7d588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6b7d1bc40c1ecaace099ecb2cd61e715b7d588", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fea7fbda3b021bb70fdd058f8a6f5944f1c56c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMSTestJS.Models.ViewModels.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_registerStudentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_addDepartmentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
  
    ViewData["Title"] = "Index - Student";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12"">
    <div class=""row"">
        <div class=""col-4"">
            <h2 class=""text-primary"">Students List</h2>
        </div>
        <div align=""right"" class=""col-8 "">
            <a data-toggle=""modal"" style=""cursor: pointer;"" data-target=""#addDepartmentPageModal"" class=""btn btn-primary text-white form control""><i class=""fas fa-plus""></i> Department</a>
            <a data-toggle=""modal"" style=""cursor: pointer;"" data-target=""#createStudentPageModal"" class=""btn btn-primary text-white form control""><i class=""fas fa-plus""></i> Student</a>
        </div>
    </div>
    <br>

");
#nullable restore
#line 19 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
     if(Model.Students.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""tbl"" class=""table table-hover bordered table-sm text-center"">
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
#line 30 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                 foreach (var item in Model.Students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                    <td>");
#nullable restore
#line 33 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                   Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                   Write(Html.DisplayFor(m => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 37 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 40 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No Students</p>\n");
#nullable restore
#line 44 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""createStudentPageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""StudentLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""StudentLabel"">Register New Student</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db6b7d1bc40c1ecaace099ecb2cd61e715b7d5887438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 57 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Student;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""addDepartmentPageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DepartmentLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""DepartmentLabel"">Add New Department</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db6b7d1bc40c1ecaace099ecb2cd61e715b7d5889663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 72 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Department;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
 <script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>
 <script>
    $(document).ready(function() {
       
            $(""#register"").click(function() {
                 var url = '");
#nullable restore
#line 82 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
                       Write(Url.Action("RegisterStudent","Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    var Name = $(""#name"").val();
    var Department = $(""#department"").val();
    var formData = $(""#form"").serialize();
    var dataString = ""Name=""+Name+""&Department=""+Department ;
    if(Name != """" && Department != """"){
        $.ajax({
            type:'GET',
            url: url,
            data:  dataString,
            success:function() {
                $('#createStudentPageModal').modal('toggle');
                document.getElementById(""name"").value = """";
                document.getElementById(""department"").value = """";
                $(""#tbl"").load("" #tbl"");
            },
            error:function() {
                alert(""Error"");
            }
        });
    }
    else{
        $(""#ValMess"").append(""You can't leave any fields empty"").css('color', 'red');
        setTimeout(function(){
        $(""#ValMess"").html("""");
        },3000);
    }
        
    });

});
  
</script>


<script>
    $(document).ready(function (){
    $(""#addDeptButton"").click(function() {
    var urls = ");
#nullable restore
#line 120 "/home/tahmid/Desktop/Projects/GitRepo/UMSTestJS/Views/Student/Index.cshtml"
          Write(Url.Action("AddDepartment","Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var DeptName = $(""#deptName"").val();
    var datastring = ""DeptName=""+DeptName;
    if(DeptName != """"){
        $.ajax({
            type:'GET',
            url: urls,
            data: datastring,
            success:function() {
                $('#addDepartmentPageModal').modal('toggle');
                document.getElementById(""deptName"").value = """";
            },
            error:function() {
                alert(""Error"");
            }
        });
    }
    else{
        $(""#ValMsg"").append(""You can't leave any fields empty"").css('color', 'red');
        setTimeout(function(){
        $(""#ValMsg"").html("""");
        },3000);
    }
        
    }); 
}); 
</script>");
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
