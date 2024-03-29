#pragma checksum "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876c4dfebfa65af03bad64655c1af87575caa631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseReports_ajaxJustificationReports), @"mvc.1.0.view", @"/Views/CaseReports/ajaxJustificationReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaseReports/ajaxJustificationReports.cshtml", typeof(AspNetCore.Views_CaseReports_ajaxJustificationReports))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876c4dfebfa65af03bad64655c1af87575caa631", @"/Views/CaseReports/ajaxJustificationReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseReports_ajaxJustificationReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
   var items = (List<Admin.Models.CaseReportJustificationReportForAttendedCases>)ViewBag.caseReportJustificationReportForAttendedCases; 

#line default
#line hidden
            BeginContext(138, 8, true);
            WriteLiteral("<style>\n");
            EndContext();
            BeginContext(202, 127, true);
            WriteLiteral("    .custom-select\n    {\n        height:30px!important;\n        width:50px!important;\n        margin-left:5px!important;\n    }\n");
            EndContext();
            BeginContext(372, 673, true);
            WriteLiteral(@"    .dt-buttons
    {
        margin-left:4px!important;
    }
</style>

<table id=""dt"" class=""table tblsm"">
    <thead>
        <tr>
            <th>Name Of Beneficiary</th>
            <th>Place of Origin/Residence</th>
            <th>Place Of Activity</th>
            <th>Date Of Assistance</th>
            <th>Logistical Support</th>
            <th>Home Visit</th>
            <th>Disability Expert</th>
            <th>Summary Of Activity</th>
            <th>Outcome</th>
            <th>Date of Court Hearing</th>
            <th>Prepared By</th>
            <th>Prepared By Date</th>
            <th>Approved By Date</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 36 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
         foreach (var item in items)
        {

#line default
#line hidden
            BeginContext(1092, 12, true);
            WriteLiteral("<tr>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1104, "\"", 1135, 1);
#line 39 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1112, item.NameOfBeneficiary, 1112, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1138, 22, false);
#line 39 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                   Write(item.NameOfBeneficiary);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1173, "\"", 1209, 1);
#line 40 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1181, item.PlaceOfOriginResidence, 1181, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1210, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1212, 27, false);
#line 40 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                        Write(item.PlaceOfOriginResidence);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1252, "\"", 1281, 1);
#line 41 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1260, item.PlaceOfActivity, 1260, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1282, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1284, 20, false);
#line 41 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                 Write(item.PlaceOfActivity);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1317, "\"", 1364, 1);
#line 42 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1325, item.DateWhenTheBeneficiaryWasAssisted, 1325, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1367, 38, false);
#line 42 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                                   Write(item.DateWhenTheBeneficiaryWasAssisted);

#line default
#line hidden
            EndContext();
            BeginContext(1405, 46, true);
            WriteLiteral("</td>\n    <td title=\"\"><input type=\"checkbox\" ");
            EndContext();
            BeginContext(1453, 57, false);
#line 43 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                    Write(item.TypeOfAssistanceLogisticalSupport==true?"checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(1511, 48, true);
            WriteLiteral("/></td>\n    <td title=\"\"><input type=\"checkbox\" ");
            EndContext();
            BeginContext(1561, 49, false);
#line 44 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                    Write(item.TypeOfAssistanceHomeVisit==true?"checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(1611, 48, true);
            WriteLiteral("/></td>\n    <td title=\"\"><input type=\"checkbox\" ");
            EndContext();
            BeginContext(1661, 56, false);
#line 45 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                    Write(item.TypeOfAssistanceDisabilityExpert==true?"checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(1718, 15, true);
            WriteLiteral("/></td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1733, "\"", 1764, 1);
#line 46 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1741, item.SummaryOfActivity, 1741, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1765, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1767, 22, false);
#line 46 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                   Write(item.SummaryOfActivity);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1802, "\"", 1823, 1);
#line 47 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1810, item.Outcome, 1810, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1824, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1826, 12, false);
#line 47 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                         Write(item.Outcome);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 14, true);
            WriteLiteral(" </td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1852, "\"", 1908, 1);
#line 48 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1860, item.DateOfCourtHearing?.ToString("yyyy-MM-dd"), 1860, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1909, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1911, 47, false);
#line 48 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                                            Write(item.DateOfCourtHearing?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1971, "\"", 1995, 1);
#line 49 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 1979, item.PreparedBy, 1979, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1996, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1998, 15, false);
#line 49 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                            Write(item.PreparedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2013, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2026, "\"", 2078, 1);
#line 50 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 2034, item.PreparedByDate?.ToString("yyyy-MM-dd"), 2034, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2079, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2081, 43, false);
#line 50 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                                        Write(item.PreparedByDate?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2137, "\"", 2161, 1);
#line 51 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 2145, item.ApprovedBy, 2145, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2162, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2164, 15, false);
#line 51 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                            Write(item.ApprovedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2179, 13, true);
            WriteLiteral("</td>\n    <td");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2192, "\"", 2244, 1);
#line 52 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
WriteAttributeValue("", 2200, item.ApprovedByDate?.ToString("yyyy-MM-dd"), 2200, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2245, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2247, 43, false);
#line 52 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
                                                        Write(item.ApprovedByDate?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 12, true);
            WriteLiteral("</td>\n</tr>\n");
            EndContext();
#line 54 "C:\.NetProjects\LCDZIMWEPAPP\Admin\Views\CaseReports\ajaxJustificationReports.cshtml"
}

#line default
#line hidden
            BeginContext(2304, 681, true);
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
