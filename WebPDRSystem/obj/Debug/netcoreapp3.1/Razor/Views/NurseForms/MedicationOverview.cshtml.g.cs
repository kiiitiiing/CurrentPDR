#pragma checksum "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2919866c44fb09d4ad5aed326b09ce9eab72493"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NurseForms_MedicationOverview), @"mvc.1.0.view", @"/Views/NurseForms/MedicationOverview.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2919866c44fb09d4ad5aed326b09ce9eab72493", @"/Views/NurseForms/MedicationOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5a22c6d35617c1e3ce08ff0048f0e904e4c32a", @"/Views/_ViewImports.cshtml")]
    public class Views_NurseForms_MedicationOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medications>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
   
    var dayss = Model.GroupBy(x => x.Day)
        .Select(x => new
        {
            day = (int)x.Key
        })
        .ToList();

    var days = new List<int>();

    foreach(var item in dayss)
    {
        days.Add(item.day);
    }
    days.Sort();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""medovv"" style=""font-size: 14px; font-weight:500;"">
    <div class=""modal-dialog modal-xl"" role=""document"">
        <div class=""modal-content clearfix"">
            <div class=""modal-header"">
                <h4>Medications taken by ");
#nullable restore
#line 24 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                    Write(ViewBag.Patient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\">\r\n                    <span aria-hidden=\"true\">×</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n");
#nullable restore
#line 30 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                 if (Model.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered table-hover table-responsive"">
                        <thead>
                            <tr style=""text-align: center !important; vertical-align: central !important;"">
                                <th rowspan=""2"">
                                    MEDICATION<br />
                                    <small>
                                        (DOSAGE, ROUTE & FREQUENCY)
                                    </small>
                                </th>
");
#nullable restore
#line 41 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                 for(int x = 0; x < days.Count(); x++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th>\r\n                                        DAY ");
#nullable restore
#line 44 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                       Write(days[x]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n");
#nullable restore
#line 46 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n                            <tr>\r\n");
#nullable restore
#line 49 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                 for (int x = 0; x < days.Count(); x++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th>\r\n                                        <small>\r\n                                            ");
#nullable restore
#line 53 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                       Write(Model.Where(c => c.Day == days[x]).FirstOrDefault().CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </small>\r\n                                    </th>\r\n");
#nullable restore
#line 56 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                             foreach(var med in Model.GroupBy(x=>x.MedName))
                            {
                                var meddss = med.Key.Split(new[] { ' ' }, 2);
                                var medname = meddss[0];
                                var medparams = meddss[1];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"word-wrap: break-word !important;\">\r\n                                        ");
#nullable restore
#line 67 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                   Write(medname);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                        <small>\r\n                                            ");
#nullable restore
#line 69 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                       Write(medparams);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </small>\r\n                                    </td>\r\n");
#nullable restore
#line 72 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                     for(int x = 0; x<days.Count();x++)
                                    {
                                        var curDay = Model.Where(c => c.Day == days[x]);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n");
#nullable restore
#line 76 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                             foreach(var dates in med.OrderBy(x=>x.CreatedAt).Where(c=>c.Day == days[x]))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                 if (dates.Discontinued)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>//</span>\r\n");
#nullable restore
#line 81 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                     if (!string.IsNullOrEmpty(dates.Comments))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <pre>");
#nullable restore
#line 83 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                        Write(dates.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n");
#nullable restore
#line 84 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br />\r\n");
#nullable restore
#line 88 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                     
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <small>\r\n                                                        ");
#nullable restore
#line 93 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                   Write(dates.CreatedAt.ToString("hh:mm tt", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 93 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                                                                                         Write(dates.SignatureNurseNavigation.Initials);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </small>\r\n");
#nullable restore
#line 95 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                     if (!string.IsNullOrEmpty(dates.Comments))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <pre>");
#nullable restore
#line 97 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                        Write(dates.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n");
#nullable restore
#line 98 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br />\r\n");
#nullable restore
#line 102 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                     
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n");
#nullable restore
#line 106 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 108 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 111 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-danger\">No Records found!</span>\r\n");
#nullable restore
#line 115 "C:\Users\Keith\Desktop\doh\WebPDRSystem\WebPDRSystem\Views\NurseForms\MedicationOverview.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Medications>> Html { get; private set; }
    }
}
#pragma warning restore 1591