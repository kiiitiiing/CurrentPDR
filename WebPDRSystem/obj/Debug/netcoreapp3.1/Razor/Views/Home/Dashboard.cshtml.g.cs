#pragma checksum "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a18284cb890130c7943ccf85068a1cb82d2bdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a18284cb890130c7943ccf85068a1cb82d2bdd", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0de6f509fd11d1eacc1af603f29baa90bb40be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--DASHBOARD-->
<div class=""row"" style=""background-color:aliceblue; padding:20px"">

    <!--Table Column-->
    <div class=""col-md-12"">

        <div class=""panel user-panel"">
            <div class=""panel-heading"">
                <strong style=""color: #f0ad4e;font-size:medium;"">Patient list</strong>
                <span class=""fa-pull-right badge badge-success"">
                    Total: ");
#nullable restore
#line 16 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml"
                      Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </span>
            </div>
            <div class=""clearfix""></div>
            <div class=""page-divider""></div>
            <div class=""panel-body"">
                <!-- SEARCH FORM-->
                <div class=""form-group form-inline"">
                    <input type=""text"" name=""searchDetail"" class=""form-control"" placeholder=""Search"" id=""searchDetail""");
            BeginWriteAttribute("onkeypress", " onkeypress=\"", 851, "\"", 864, 0);
            EndWriteAttribute();
            WriteLiteral(@" autofocus> <!--Input Name to Search-->
                    <button class=""btn btn-default searchPatient"" id=""searchbutton"" onclick=""SearchPatient();"">
                        <i class=""fa fa-search""></i> Search
                    </button>
                    <!--Search Button-->
                </div>
                <div class=""clearfix""></div>
                <div class=""page-divider""></div>

                <!--Patient LISTS-->
                <div class=""patient-list"">
                    <table  class=""table table-list table-hover table-responsive table-striped"" style=""height: 350px; overflow: auto;"">
                        <thead>
                            <tr>
                                <th class=""text-center"">Bed Number</th>
                                <th class=""text-center"">Name </th>
                                <th class=""text-center"">Age </th>
                                <th class=""text-center"">Sex </th>
                                <th class=""text-cente");
            WriteLiteral(@"r"">Municipal</th>
                                <th class=""text-center"">Admiting Diagnosis</th>
                                <th class=""text-center"">Date and Time of Admission</th>
                                <th class=""text-center"">Date VS taken </th>
                                <th class=""text-center"">BP </th>
                                <th class=""text-center"">HR </th>
                                <th class=""text-center"">RR </th>
                                <th class=""text-center"">T</th>
                                <th class=""text-center"">O2Sat </th>
                                <th class=""text-center"">Subjective Complaints</th>
                                <th class=""text-center"">Pertinent PE </th>
                                <th class=""text-center""> Diagnostic test</th>
                                <th class=""text-center""> Lab Results</th>
                                <th class=""text-center"">Medications/ Therapeutics</th>
                         ");
            WriteLiteral(@"       <th class=""text-center"">Consultant Referral </th>
                                <th class=""text-center"">Other remarks </th>
                            </tr>
                        </thead>
                        <tbody id=""dashboard_table"">
                            <tr>
                                <td colspan=""20"">
                                    Loading....
                                </td>
                            </tr>
                        </tbody>

                    </table>
                </div>

            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        LoadDashboard('');
    })

    function SearchPatient() {
        var search = $('#searchDetail').val();
        LoadDashboard(search);
        $('#placeholder').empty();
        $('#daily_monitoring_form').empty();
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
