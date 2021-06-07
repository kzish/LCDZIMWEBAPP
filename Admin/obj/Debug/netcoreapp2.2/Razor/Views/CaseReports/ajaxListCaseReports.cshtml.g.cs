#pragma checksum "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8927bad1532267b8590ad4b4f4e01a7ad8f077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseReports_ajaxListCaseReports), @"mvc.1.0.view", @"/Views/CaseReports/ajaxListCaseReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaseReports/ajaxListCaseReports.cshtml", typeof(AspNetCore.Views_CaseReports_ajaxListCaseReports))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8927bad1532267b8590ad4b4f4e01a7ad8f077", @"/Views/CaseReports/ajaxListCaseReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseReports_ajaxListCaseReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:blue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
  
    var case_reports = (List<Admin.Models.CaseReport>)ViewBag.case_reports;

#line default
#line hidden
            BeginContext(81, 8, true);
            WriteLiteral("<style>\n");
            EndContext();
            BeginContext(145, 127, true);
            WriteLiteral("    .custom-select\n    {\n        height:30px!important;\n        width:50px!important;\n        margin-left:5px!important;\n    }\n");
            EndContext();
            BeginContext(315, 333, true);
            WriteLiteral(@"    .dt-buttons
    {
        margin-left:4px!important;
    }
</style>

<table id=""dt"" class=""table tblsm"">
    <thead>
        <tr>
            <th>Date</th>
            <th>Referer/Institution</th>
            <th>Police Station</th>
            <th>C.R Ref</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
         foreach (var item in case_reports)
        {

#line default
#line hidden
            BeginContext(702, 36, true);
            WriteLiteral("            <tr>\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 738, "\"", 780, 1);
#line 33 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
WriteAttributeValue("", 746, item.Date?.ToString("yyyy-MM-dd"), 746, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(781, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(783, 33, false);
#line 33 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
                                                          Write(item.Date?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(816, 25, true);
            WriteLiteral("</td>\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 841, "\"", 883, 1);
#line 34 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
WriteAttributeValue("", 849, item.ReferredByNameAndInstitution, 849, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(884, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(886, 33, false);
#line 34 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
                                                          Write(item.ReferredByNameAndInstitution);

#line default
#line hidden
            EndContext();
            BeginContext(919, 25, true);
            WriteLiteral("</td>\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 944, "\"", 971, 1);
#line 35 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
WriteAttributeValue("", 952, item.PoliceStation, 952, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(972, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(974, 18, false);
#line 35 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
                                           Write(item.PoliceStation);

#line default
#line hidden
            EndContext();
            BeginContext(992, 25, true);
            WriteLiteral("</td>\n                <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1017, "\"", 1036, 1);
#line 36 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
WriteAttributeValue("", 1025, item.CrRef, 1025, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1039, 10, false);
#line 36 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
                                   Write(item.CrRef);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1096, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb8927bad1532267b8590ad4b4f4e01a7ad8f0777830", async() => {
                BeginContext(1164, 50, true);
                WriteLiteral("\n                        Edit\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1105, "~/CaseReports/EditCaseReport/", 1105, 29, true);
#line 38 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
AddHtmlAttributeValue("", 1134, item.Id, 1134, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1218, 91, true);
            WriteLiteral("\n                    |\n                    <a href=\"javascript:void(0);\" style=\"color:red;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1309, "\"", 1345, 3);
            WriteAttributeValue("", 1319, "confirm_delete(\'", 1319, 16, true);
#line 42 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
WriteAttributeValue("", 1335, item.Id, 1335, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1343, "\')", 1343, 2, true);
            EndWriteAttribute();
            BeginContext(1346, 98, true);
            WriteLiteral(">\n                        Delete\n                    </a>\n                </td>\n            </tr>\n");
            EndContext();
#line 47 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxListCaseReports.cshtml"
        }

#line default
#line hidden
            BeginContext(1454, 681, true);
            WriteLiteral(@"    </tbody>
</table>

<script>

    $('#dt').DataTable({
        select: true,
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
            'copyHtml5',
            'excelHtml5',
            'csvHtml5',
            'pdfHtml5'
        ]
    });


    function confirm_delete(id) {
        $.confirm({
            title: 'Information',
            type: ""red"",
            content: 'Delete this CaseReport?',
            buttons: {
                Yes: function () {
                    window.location = ""../CaseReports/DeleteCaseReport/"" + id;
                },
                No: function () {
                },

            }
        });

    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
