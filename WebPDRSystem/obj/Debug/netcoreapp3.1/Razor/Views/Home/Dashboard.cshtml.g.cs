#pragma checksum "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a291cb0794a205f3132c4b11bbbedf62fc373d38"
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
#line 1 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using WebPDRSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a291cb0794a205f3132c4b11bbbedf62fc373d38", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5a22c6d35617c1e3ce08ff0048f0e904e4c32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top: 20px;"">
    <div class=""card"">
        <div class=""card-header"">
            <div style=""display: flex;"">
                <div class=""col-md-6"">
                    <h3 class=""card-title"">
                        Patient List
                    </h3><br />
                    <span class=""text-sm text-muted"">TOTAL: <span class=""total_number""></span></span>
                </div>
                <div class=""col-md-6"">
                    <div class=""fa-pull-right form-inline ml-3"">
                        <!-- INPUT -->
                        <input class=""form-control form-control-sm""
                               name=""search""
                               id=""searchDetail""
                               placeholder=""Lastname""
                               type=""text""");
            BeginWriteAttribute("value", "\r\n                               value=\"", 892, "\"", 953, 1);
#nullable restore
#line 24 "C:\Users\DOH\Source\Repos\kiiitiiing\WebPDRSystem\WebPDRSystem\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 932, ViewBag.SearchFilter, 932, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

                        <button id=""searchPatientBtn"" type=""button"" class=""btn btn-sm btn-success"">

                            <i class=""fa fa-search""></i>

                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card-body"" id=""list_patient"" style=""margin-bottom: 50px !important;"">
            <div class=""overlay d-flex justify-content-center align-items-center"">
                <i class=""fas fa-2x fa-sync fa-spin""></i>
            </div>
            <br />
            <br />

        </div>
        <div id=""home-patients"" style=""margin: auto; margin-bottom: 20px;""></div>
    </div>
</div>


<script>
    var vessel = $('#home-patients');
    var last = '';
    $(function () {
        var q = [];
        q.push('');
        q.push('');
        LoadPatients(q, vessel, 'Home', 'PatientsJson');

        $('#searchPatientBtn').on('click', function (event) {
            event.preventDefault();");
            WriteLiteral(@"
            event.stopImmediatePropagation();
            var s = [];
            s.push($('#searchDetail').val());
            s.push('');
            LoadPatients(s, vessel, 'Home', 'PatientsJson');
        });
    })
    function Sort(filter) {
        if (last == filter) {
            last = last + '_desc';
        }
        else {
            last = filter;
        }
        var f = [];
        f.push($('#searchDetail').val());
        f.push(last);
        LoadPatients(f, vessel, 'Home', 'PatientsJson');
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
